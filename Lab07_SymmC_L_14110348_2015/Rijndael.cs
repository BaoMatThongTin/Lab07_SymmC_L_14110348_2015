using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Symm_14110348_14110385_2013
{
    class Rijndael : ISymmetricAthm
    {
        RijndaelManaged rijndaelCSP;
        byte[] key;
        byte[] iv;
        CipherMode mode;
        PaddingMode padding;
        public Rijndael()
        {            
            rijndaelCSP = new RijndaelManaged();
            Random r = new Random();
            int[] size = { 128, 192, 256 };
            rijndaelCSP.KeySize = size[r.Next(3)];
        }
        public string decrypt(byte[] encrypted, byte[] key, byte[] iv)
        {
            //Get a decryptor that uses the same key and IV as the encryptor.
            rijndaelCSP.Mode = mode;
            rijndaelCSP.Padding = padding;
            //MessageBox.Show(rijndaelCSP.Mode + "/" + rijndaelCSP.Padding);
            
            ICryptoTransform decryptor = rijndaelCSP.CreateDecryptor(key, iv);

            Symmetric symm = new Symmetric();
            return symm.decrypt(decryptor, encrypted);
        }

        public byte[] encrypt(string plaintext, byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
            
            // Get an encryptor.
            rijndaelCSP.Mode = mode;
            rijndaelCSP.Padding = padding;
            //MessageBox.Show(rijndaelCSP.Mode + "/" + rijndaelCSP.Padding);
            ICryptoTransform encryptor = rijndaelCSP.CreateEncryptor(key, iv);

            Symmetric symm = new Symmetric();
            
            return symm.encrypt(encryptor, plaintext);
        }

        public byte[] getIV()
        {
            iv = rijndaelCSP.IV;
            return iv;
        }

        public byte[] getKey()
        {
            key = rijndaelCSP.Key;
            return key;
        }

        public void setMode(CipherMode mode)
        {
            this.mode = mode;
        }

        public void setPadding(PaddingMode padding)
        {
            this.padding = padding;
        }
    }
}
