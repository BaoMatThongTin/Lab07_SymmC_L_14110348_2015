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
    public class Symmetric
    {
        public string decrypt(ICryptoTransform decryptor, byte[] encrypted)
        {
            // Now decrypt the previously encrypted message using the decryptor
            // obtained in the above step.
            MemoryStream msDecrypt = new MemoryStream(encrypted);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

            // Read the decrypted bytes from the decrypting stream
            // and place them in a StringBuilder class.

            //return outputText;
            StringBuilder roundtrip = new StringBuilder();

            int b = 0;
            byte[] decrypted = new byte[encrypted.Length];
            int i = 0;
            do
            {
                try
                {
                    b = csDecrypt.ReadByte();
                    if (b != -1)
                    {
                        decrypted[i++] = (byte)b;
                    }
                }
                catch (Exception e)
                {
                    i++;
                }
                //b = csDecrypt.ReadByte();

            } while (b != -1 && i < encrypted.Length);
            roundtrip.Append(System.Text.Encoding.UTF8.GetString(decrypted));
            
            return roundtrip.ToString();
        }

        public byte[] encrypt(ICryptoTransform encryptor, string plaintext)
        {
            // Encrypt the data as an array of encrypted bytes in memory.
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            // Convert the data to a byte array.
            string original = plaintext;
            byte[] toEncrypt = Encoding.UTF8.GetBytes(original);
            // Write all data to the crypto stream and flush it.
            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            // Get the encrypted array of bytes.
            return msEncrypt.ToArray();
        }
    }
}
