using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab06_Symm_14110348_14110385_2013
{
    class TripleDES : ISymmetricAthm
    {
        TripleDESCryptoServiceProvider tripledesCSP;
        byte[] key;
        byte[] iv;
        CipherMode mode;
        PaddingMode padding;
        public TripleDES()
        {
            tripledesCSP = new TripleDESCryptoServiceProvider();
        }
        public string decrypt(byte[] encrypted, byte[] key, byte[] iv)
        {
            tripledesCSP.Mode = mode;
            tripledesCSP.Padding = padding;
            //MessageBox.Show(tripledesCSP.Mode + "/" + tripledesCSP.Padding);
            //Get a decryptor that uses the same key and IV as the encryptor.
            ICryptoTransform decryptor = tripledesCSP.CreateDecryptor(key, iv);

            Symmetric symm = new Symmetric();
            
            return symm.decrypt(decryptor, encrypted);
        }

        public byte[] encrypt(string plaintext, byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
            tripledesCSP.Mode = mode;
            tripledesCSP.Padding = padding;
            //MessageBox.Show(tripledesCSP.Mode + "/" + tripledesCSP.Padding);
            // Get an encryptor.
            ICryptoTransform encryptor = tripledesCSP.CreateEncryptor(key, iv);

            Symmetric symm = new Symmetric();
            
            return symm.encrypt(encryptor, plaintext);
        }

        public byte[] getIV()
        {
            iv = tripledesCSP.IV;
            return iv;
        }

        public byte[] getKey()
        {
            key = tripledesCSP.Key;
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
