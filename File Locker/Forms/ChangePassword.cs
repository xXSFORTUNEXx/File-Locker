using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; 

namespace File_Locker
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text.Length < 8 || txtNewPass.Text.Length < 8 || txtConfirmPass.Text.Length < 8) { MessageBox.Show("One of your passwords is too short! 8 characters or more please!", "Password Length"); return; }

            if (txtNewPass.Text != txtConfirmPass.Text) { MessageBox.Show("Password don't match! Try again!", "Mixmatched Password"); return; }

            string crypt = GetEncryptedPasswordFromDatabase();
            if (txtCurrentPass.Text != crypt) { crypt = null; MessageBox.Show("Current password dont match! Try again!", "Wrong Password"); return; }

            string EncryptedPassword = Crypto.EncryptString(txtNewPass.Text, Global.FILE_LOCK_PASS);

            SetEncryptedPasswordInDatabase(EncryptedPassword);
            MessageBox.Show("Password changed in database!", "Yay!");
            Close();
        }

        private void SetEncryptedPasswordInDatabase(string password)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=Data/FileLocker.db;Version=3;"))
                {
                    using (var cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        string command;

                        cmd.CommandText = "DROP TABLE Configuration";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Configuration (Password TEXT)";
                        cmd.ExecuteNonQuery();

                        command = "INSERT INTO Configuration (Password) VALUES (@password);";
                        cmd.CommandText = command;
                        cmd.Parameters.Add("@password", System.Data.DbType.String).Value = password;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exc)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(exc.Message + "\n" + "HResult: " + exc.HResult, "Fatal Error"); }
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
    }
}
