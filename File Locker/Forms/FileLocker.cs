using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Data.SQLite;
using System.ComponentModel;
using System.Threading;

namespace File_Locker
{
    public partial class FileLocker : Form
    {
        string File_Path = "Files";
        string Zip_Path = "Files.zip";
        string Backup_Path = "Backup";
        string Empty_Path = "Data/Empty";
        string Encrypt_Path = "Encrypted Files";
        string Encrypt_Path_Zip = "Encrypted Files.zip";
        string Decrypt_Path = "Decrypted Files";
        string Current_File;

        BackgroundWorker background_Worker = new BackgroundWorker();
        BackgroundWorker background_Worker_V = new BackgroundWorker();

        public FileLocker()
        {
            InitializeComponent();

            if (!Directory.Exists(File_Path)) { Directory.CreateDirectory(File_Path); }
            if (!Directory.Exists(Backup_Path)) { Directory.CreateDirectory(Backup_Path); }
            if (!Directory.Exists(Empty_Path)) { Directory.CreateDirectory(Empty_Path); }
            if (!Directory.Exists(Encrypt_Path)) { Directory.CreateDirectory(Encrypt_Path); }
            if (!Directory.Exists(Decrypt_Path)) { Directory.CreateDirectory(Decrypt_Path); }

            if (!File.Exists(Zip_Path)) { ZipFile.CreateFromDirectory(Empty_Path, Zip_Path); }
            if (!File.Exists(Encrypt_Path_Zip)) { ZipFile.CreateFromDirectory(Empty_Path, Encrypt_Path_Zip); }

            background_Worker.ProgressChanged += Background_Worker_ProgressChanged;
            background_Worker.RunWorkerCompleted += Background_Worker_RunWorkerCompleted;
            background_Worker.WorkerReportsProgress = true;
        }

        private void Background_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgbFileStatus.Value = 0;
            ttlProgressStatus.Text = "Ready";
            AppendLog("Operation complete!", "Log");
            tabMainTabs.Enabled = true;
        }

        private void Background_Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbFileStatus.Value = e.ProgressPercentage;
            AppendLog(Current_File, "Log");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cleanup remaining files?", "Backup Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CleanupFiles("All");
            }
        }

        private void btnZipFiles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to compress the Files folder?", "Compress Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackupFiles("Files");
                AppendLog("Compressing files...", "Log");
                ttlProgressStatus.Text = "Compressing files...";
                background_Worker.DoWork += CompressFiles;
                background_Worker.RunWorkerAsync();
                tabMainTabs.Enabled = false;             
            }
        }

        private void btnUnzipFiles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to decompress the Files zip?", "Decompress Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackupFiles("Zip");
                AppendLog("Decompressing files...", "Log");
                ttlProgressStatus.Text = "Decompressing files...";
                background_Worker.DoWork += DecompressFiles;
                background_Worker.RunWorkerAsync();
                tabMainTabs.Enabled = false;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to encrypt the Files folder?", "Encrypt Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackupFiles("Files");
                BackupFiles("Zip");
                AppendLog("Encrypting files...", "Log");
                ttlProgressStatus.Text = "Encrypting files...";
                background_Worker.DoWork += EncryptFiles;
                background_Worker.RunWorkerAsync();
                tabMainTabs.Enabled = false;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to decrypt the Encrypted Files folder?", "Encrypt Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackupFiles("Crypto");
                AppendLog("Decrypting files...", "Log");
                ttlProgressStatus.Text = "Decrypting files...";
                background_Worker.DoWork += DecryptFiles;
                background_Worker.RunWorkerAsync();
                tabMainTabs.Enabled = false;
            }
        }

        private void DecryptFiles(object sender, DoWorkEventArgs e)
        {
            int current_progress = 0;
            if (!Directory.Exists(Decrypt_Path)) { Directory.CreateDirectory(Decrypt_Path); }
            try
            {
                foreach (string file in Directory.GetFiles(Encrypt_Path))
                {
                    string fileName = file.Remove(0, 16);
                    string ffileName = Decrypt_Path + "/" + fileName.Remove(fileName.Length - 4, 4);
                    if (!File.Exists(ffileName))
                    {
                        string crypt = GetEncryptedPasswordFromDatabase();
                        if (crypt != "Error")
                        {
                            Encryption.DecryptFile(file, ffileName, crypt);
                            Current_File = file;
                            ttlProgressStatus.Text = "Decrypting - " + Current_File;
                            if (current_progress <= 90) { current_progress += 1; }
                            background_Worker.ReportProgress(current_progress);
                            Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(exc.Message + "\n" + "HResult: " + exc.HResult, "Fatal Error"); }
            }
        }

        private void EncryptFiles(object sender, DoWorkEventArgs e)
        {
            int current_progress = 0;
            if (!Directory.Exists(Encrypt_Path)) { Directory.CreateDirectory(Encrypt_Path); }
            try
            {
                foreach (string file in Directory.GetFiles(File_Path))
                {
                    if (!File.Exists(Encrypt_Path + "/" + file.Remove(0, 6) + ".efl"))
                    {
                        string crypt = GetEncryptedPasswordFromDatabase();
                        if (crypt != "Error")
                        {
                            Encryption.EncryptFile(file, Encrypt_Path + "/" + file.Remove(0, 6) + ".efl", crypt);
                            Current_File = file;
                            ttlProgressStatus.Text = "Encrypting - " + Current_File;
                            if (current_progress <= 90) { current_progress += 1; }
                            background_Worker.ReportProgress(current_progress);
                            Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(exc.Message + "\n" + "HResult: " + exc.HResult, "Fatal Error"); }
            }
        }

        private void DecompressFiles(object sender, DoWorkEventArgs e)
        {
            int current_progress = 0;
            if (!File.Exists(Zip_Path)) { MessageBox.Show("Files.zip doesnt exist! Cancelling decompression!", "Fatal Error"); return; }
            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(Zip_Path))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (!File.Exists("Files/" + entry.FullName))
                        {
                            entry.ExtractToFile("Files/" + entry.FullName);
                            Current_File = entry.FullName;
                            ttlProgressStatus.Text = "Decompressing - " + Current_File;
                            if (current_progress <= 90) { current_progress += 1; }
                            background_Worker.ReportProgress(current_progress);
                            Thread.Sleep(100);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(exc.Message + "\n" + "HResult: " + exc.HResult, "Fatal Error"); }
            }
        }

        private void CompressFiles(object sender, DoWorkEventArgs e)
        {
            int current_progress = 0;
            if (!File.Exists(Zip_Path)) { ZipFile.CreateFromDirectory(Empty_Path, Zip_Path); }
            try
            {
                using (FileStream ziptoTopen = new FileStream(Zip_Path, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(ziptoTopen, ZipArchiveMode.Update))
                    {
                        foreach (string file in Directory.GetFiles(File_Path))
                        {
                            bool Existing_Entry = false;
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName == file.Remove(0, 6))
                                {
                                    Existing_Entry = true;
                                    break;
                                }
                            }

                            if (!Existing_Entry)
                            {
                                ZipArchiveEntry zipArchiveEntry = archive.CreateEntryFromFile(file, file.Remove(0, 6));
                                Current_File = file;
                                ttlProgressStatus.Text = "Compressing - " + file;
                                if (current_progress <= 90) { current_progress += 1; }
                                background_Worker.ReportProgress(current_progress);
                                Thread.Sleep(100);
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(exc.Message + "\n" + "HResult: " + exc.HResult, "Fatal Error"); }
            }
        }

        private void BackupFiles(string backupType)
        {
            AppendLog("Creating backups...", "Log");

            switch (backupType)
            {
                case "Files":
                    foreach (string file in Directory.GetFiles(File_Path))
                    {
                        File.Copy(file, Backup_Path + "/" + file.Remove(0, 6), true);
                        AppendLog(Backup_Path + "/" + file.Remove(0, 6), "Log");
                    }
                    break;

                case "Zip":
                    File.Copy(Zip_Path, Backup_Path + "/" + Zip_Path, true);
                    AppendLog(Backup_Path + "/" + Zip_Path, "Log");

                    File.Copy(Encrypt_Path_Zip, Backup_Path + "/" + Encrypt_Path_Zip, true);
                    AppendLog(Backup_Path + "/" + Encrypt_Path_Zip, "Log");
                    break;

                case "Crypto":
                    foreach (string file in Directory.GetFiles(Encrypt_Path))
                    {
                        File.Copy(file, Backup_Path + "/" + file.Remove(0, 16), true);
                        AppendLog(Backup_Path + "/" + file.Remove(0, 16), "Log");
                    }
                    break;

                case "All":
                    foreach (string file in Directory.GetFiles(File_Path))
                    {
                        File.Copy(file, Backup_Path + "/" + file.Remove(0, 6), true);
                        AppendLog(Backup_Path + "/" + file.Remove(0, 6), "Log");
                    }

                    foreach (string file in Directory.GetFiles(Encrypt_Path))
                    {
                        File.Copy(file, Backup_Path + "/" + file.Remove(0, 16), true);
                        AppendLog(Backup_Path + "/" + file.Remove(0, 16), "Log");
                    }

                    File.Copy(Zip_Path, Backup_Path + "/" + Zip_Path, true);
                    AppendLog(Backup_Path + "/" + Zip_Path, "Log");

                    File.Copy(Encrypt_Path_Zip, Backup_Path + "/" + Encrypt_Path_Zip, true);
                    AppendLog(Backup_Path + "/" + Encrypt_Path_Zip, "Log");
                    break;
            }
        }

        private void CleanupFiles(string cleanupType)
        {
            switch (cleanupType)
            {
                case "Backup":
                    foreach (string backup in Directory.GetFiles(Backup_Path))
                    {
                        File.Delete(backup);
                    }
                    break;

                case "Crypto":
                    foreach (string crypto in Directory.GetFiles(Encrypt_Path))
                    {
                        File.Delete(crypto);
                    }
                    break;
                case "All":
                    foreach (string backup in Directory.GetFiles(Backup_Path))
                    {
                        File.Delete(backup);
                    }
                    foreach (string crypto in Directory.GetFiles(Encrypt_Path))
                    {
                        File.Delete(crypto);
                    }
                    break;
            }
        }

        private string GetEncryptedPasswordFromDatabase()
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=Data/FileLocker.db;Version=3;"))
                {
                    conn.Open();
                    string command;
                    command = "SELECT Password FROM Configuration";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, conn))
                    {
                        using (SQLiteDataReader read = cmd.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                string password = read["Password"].ToString();
                                return Crypto.DecryptString(password, Global.FILE_LOCK_PASS);
                            }
                        }
                    }
                }
                return "Error";
            }
            catch (Exception e)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(e.Message + "\n" + "HResult: " + e.HResult, "Fatal Error"); }
                return "Error";
            }
        }

        private void AppendLog(string text, string type)
        {
            string finalEntry = "[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + text;
            txtLog.AppendText(finalEntry + "\n");
            if (Global.IS_LOGGING) { Logging.WriteLog(finalEntry, type); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePass = new ChangePassword();
            changePass.ShowDialog();
        }
    }
}
