using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Threading;

namespace File_Locker
{
    public partial class FileLocker : Form
    {
        string File_Path = "Files";
        string Zip_Path = "Files.zip";
        string Backup_Path = "Backup";
        string Empty_Path = "Data/Empty";

        DirectorySecurity Directory_Security = new DirectorySecurity();

        public FileLocker()
        {
            InitializeComponent();

            if (!Directory.Exists(File_Path)) { Directory.CreateDirectory(File_Path); }

            if (!Directory.Exists(Backup_Path)) { Directory.CreateDirectory(Backup_Path); }

            if (!File.Exists(Zip_Path)) { ZipFile.CreateFromDirectory(File_Path, Zip_Path); }

            FileSystemAccessRule accessRule = new FileSystemAccessRule("sfortune@live.com", FileSystemRights.FullControl, AccessControlType.Allow);
            Directory_Security.AddAccessRule(accessRule);
            Directory.SetAccessControl(File_Path, Directory_Security);
            Directory.SetAccessControl(Backup_Path, Directory_Security);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (string backup in Directory.GetFiles("Backup"))
            {
                File.Delete(backup);
            }
        }

        private void btnZipFiles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to compress the Files folder?", "Compress Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BackupFiles();
                CompressFiles();
            }
        }

        private void btnUnzipFiles_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(Zip_Path, File_Path);
        }

        private void CompressFiles()
        {
            if (!File.Exists(Zip_Path)) { ZipFile.CreateFromDirectory(Empty_Path, Zip_Path); }
            Thread.Sleep(500);
            
            AppendLog("Compressing files...", "Log");
            try
            {
                using (FileStream ziptoTopen = new FileStream(Zip_Path, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(ziptoTopen, ZipArchiveMode.Update))
                    {
                        foreach (string add_files in Directory.GetFiles("Files"))
                        {
                            bool Existing_Entry = false;
                            foreach(ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName == add_files.Remove(0, 6))
                                {
                                    Existing_Entry = true;
                                    break;
                                }
                            }

                            if (!Existing_Entry)
                            {
                                ZipArchiveEntry zipArchiveEntry = archive.CreateEntryFromFile(add_files, add_files.Remove(0, 6));
                                AppendLog("Compressed File - " + add_files, "Log");
                            }
                            else
                            {
                                AppendLog("Compression Skipped - " + add_files, "Log");
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

        private void BackupFiles()
        {
            bool overwrite = false;

            AppendLog("Backing up files...", "Log");

            foreach (string file in Directory.GetFiles("Files"))
            {
                if (File.Exists(Backup_Path + @"\" + file.Remove(0, 6))) { overwrite = true; }
                File.Copy(file, Backup_Path + @"\" + file.Remove(0, 6), true);
                if (overwrite) { AppendLog("Overwrite Existing File - " + Backup_Path + @"\" + file.Remove(0, 6), "Log"); overwrite = false; }
                else { AppendLog("Created Backup - " + Backup_Path + @"\" + file.Remove(0, 6), "Log"); }
            }
        }

        private void CleanupBackupFiles()
        {
            foreach (string backup in Directory.GetFiles("Backup"))
            {
                File.Delete(backup);
            }
        }

        void AppendLog(string text, string type)
        {
            string finalEntry = "[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "] " + text;
            txtLog.AppendText(finalEntry + "\n");
            if (Global.IS_LOGGING) { Logging.WriteLog(finalEntry, type); }
        }
    }
}
