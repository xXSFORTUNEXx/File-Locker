using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace File_Locker
{
    static class Encryption
    {
        public static void EncryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                {
                    cs.WriteByte((byte)data);
                }

                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch (Exception e)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(e.Message + "\n" + "HResult: " + e.HResult, "Fatal Error"); }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                {
                    fsOut.WriteByte((byte)data);
                }

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch (Exception e)
            {
                if (Global.IS_DEBUGGING) { MessageBox.Show(e.Message + "\n" + "HResult: " + e.HResult, "Fatal Error"); }
            }
        }
    }
}
