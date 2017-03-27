using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Symm_14110348_14110385_2013
{
    class DES : ISymmetricAthm
    {
        DESCryptoServiceProvider desCSP;
        byte[] key;
        byte[] iv;
        CipherMode mode;
        PaddingMode padding;
        public DES()
        {
            desCSP = new DESCryptoServiceProvider();
        }
        public string decrypt(byte[] encrypted, byte[] key, byte[] iv)
        {
            desCSP.Mode = mode;
            desCSP.Padding = padding;
            //MessageBox.Show(desCSP.Mode + "/" + desCSP.Padding);
            //Get a decryptor that uses the same key and IV as the encryptor.
            ICryptoTransform decryptor = desCSP.CreateDecryptor(key, iv);

            Symmetric symm = new Symmetric();
            
            return symm.decrypt(decryptor, encrypted);
        }

        public byte[] encrypt(string plaintext, byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
            desCSP.Mode = mode;
            desCSP.Padding = padding;
            //MessageBox.Show(desCSP.Mode + "/" + desCSP.Padding);
            // Get an encryptor.
            try
            {

            }
            catch(Exception e)
            {

            }
            ICryptoTransform encryptor = desCSP.CreateEncryptor(key, iv);

            Symmetric symm = new Symmetric();
            
            return symm.encrypt(encryptor, plaintext);
        }

        public byte[] getIV()
        {
            iv = desCSP.IV;
            return iv;
        }

        public byte[] getKey()
        {
            key = desCSP.Key;
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
