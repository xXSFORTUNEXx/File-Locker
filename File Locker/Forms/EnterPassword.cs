using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.ComponentModel;

namespace File_Locker
{
    public partial class EnterPassword : Form
    {
        User FL_User = new User();
        bool Error_Flag = false;

        public EnterPassword()
        {
            InitializeComponent();

            if (!Directory.Exists("Files")) { Directory.CreateDirectory("Files"); }

            if (!File.Exists("Data/FileLocker.db")) { MessageBox.Show("No configuration file found!", "Not Found"); Error_Flag = true; }           

            GetEncryptedPasswordFromDatabase();
            FL_User.CRYPTO_DNC = Crypto.DecryptString(FL_User.CRYPTO_ENC, Global.FILE_LOCK_PASS);            
            if (FL_User.CRYPTO_DNC == "Error") { Error_Flag = true; }

            if (Error_Flag == true) { Text = "File Locker (!)"; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Error_Flag == true) { MessageBox.Show("The program encountered and error and needs to close!", "Fatal Error"); Application.Exit(); }

            if (txtPassword.Text.Length < 8) { MessageBox.Show("Password must be at least 8 characters in length!", "Error"); return; }

            if (txtPassword.Text == FL_User.CRYPTO_DNC) { MessageBox.Show("Access granted!", "Successful"); Close(); }
            else { MessageBox.Show("Invalid password! Please make sure your password is correct! \nAttempts Remaining: " + FL_User.Attempts_Remaining); FL_User.Attempts_Remaining -= 1; }

            if (FL_User.Attempts_Remaining < 0) { MessageBox.Show("No attempts remaining! Please try again later!"); Application.Exit(); }            
        }

        private void GetEncryptedPasswordFromDatabase()
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
                                FL_User.CRYPTO_ENC = read["Password"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(e.Message + "\n" + "HResult: " + e.HResult, "Fatal Error"); }
                Error_Flag = true;
            }
        }
    }
}
