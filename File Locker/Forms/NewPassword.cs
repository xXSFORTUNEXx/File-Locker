using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace File_Locker
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();

            if (!File.Exists("Data/FileLocker.db"))
            {
                using (var conn = new SQLiteConnection("Data Source=Data/FileLocker.db;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command;

                        command = "CREATE TABLE Configuration (Password TEXT)";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8 || txtConfirmPassword.Text.Length < 8) { MessageBox.Show("Password must be at least 8 characters in length!", "Error"); return; }

            if (txtPassword.Text != txtConfirmPassword.Text) { MessageBox.Show("Password do not match!", "Error"); return; }

            string EncryptedPassword = Crypto.EncryptString(txtPassword.Text, Global.FILE_LOCK_PASS);

            SetEncryptedPasswordInDatabase(EncryptedPassword);

            MessageBox.Show("Database Created!", "Successful");
            Close();
        }

        private void chkPasswordProtected_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasswordProtected.Checked) { MessageBox.Show("Coming Soon!"); }
        }

        private void SetEncryptedPasswordInDatabase(string password)
        {
            using (var conn = new SQLiteConnection("Data Source=Data/FileLocker.db;Version=3;"))
            {
                using (var cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    string command;

                    command = "INSERT INTO Configuration (Password) VALUES (@password)";
                    cmd.CommandText = command;
                    cmd.Parameters.Add("@password", System.Data.DbType.String).Value = password;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
