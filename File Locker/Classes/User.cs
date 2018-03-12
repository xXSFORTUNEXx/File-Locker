using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Locker
{
    public class User
    {
        public string CRYPTO_ENC;
        public string CRYPTO_DNC;
        public int Attempts_Remaining;
        public bool Is_Password_Database_Active;

        public PasswordDatabase Password_Database = new PasswordDatabase();

        public User()
        {
            Attempts_Remaining = 3;
            Is_Password_Database_Active = false;
        }

        public User(string enc, string dnc, int attempts)
        {
            CRYPTO_ENC = enc;
            CRYPTO_DNC = dnc;
            Attempts_Remaining = attempts;
            Is_Password_Database_Active = false;
        }
    }

    public class PasswordDatabase
    {
        public string MASTER_PASSWORD;
        public string[] Username = new string[20];
        public string[] Password = new string[20];

        public PasswordDatabase()
        {
            MASTER_PASSWORD = "default";
        }

        public PasswordDatabase(string masterPass)
        {
            MASTER_PASSWORD = masterPass;

            for (int i = 0; i < 20; i++)
            {
                Username[i] = "Default";
                Password[i] = "Password";
            }
        }     
    }
}
