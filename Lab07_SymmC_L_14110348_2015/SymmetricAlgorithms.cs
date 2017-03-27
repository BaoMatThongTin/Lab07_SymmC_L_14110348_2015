using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Symm_14110348_14110385_2013
{
    public partial class SymmetricAlgorithms : Form
    {
        ISymmetricAthm symmAthm;
        byte[] key;
        byte[] iv;
        CipherMode mode;
        PaddingMode padding;
        public SymmetricAlgorithms()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //1.
            MessageBox.Show("Hãy chọn tập tin cần mã hóa!", "Thông báo");
            string curentDirectory = System.IO.Directory.GetCurrentDirectory();
            string filter = "txt files (*.txt)|*.txt";
            string path = SelectFile(curentDirectory, filter);
            //2.
            string plainText = Lib.Lib_L.ReadTextFile_CSymm4(path);
            this.txtplaintext.Text = plainText;
            //3.
            byte[] encrypted;
            if (plainText != "")
            {
                symmAthm.setMode(mode);
                symmAthm.setPadding(padding);
                encrypted = symmAthm.encrypt(plainText, key, iv);
                //4.
                this.txttextString.Text = BitConverter.ToString(encrypted);
                //5.
                string message = "Bạn có muốn lưu tập tin mã hóa không?";
                string caption = "Lưu File";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        string filter2 = "14110348 files (*.14110348)|*.14110348";
                        string pathEncrypted = SaveFile(curentDirectory, filter2);
                        MessageBox.Show("Chọn vị trí lưu file Key và IV!", "Thông báo");
                        string pathKey_IV = SaveFile(curentDirectory, filter);
                        bool bl1 = Lib.Lib_L.WriteBinFile_CSymm4(pathEncrypted, encrypted);
                        string key_iv = this.txtKey.Text + "\n" + this.txtinitVector.Text;
                        bool bl2 = Lib.Lib_L.WriteTextFile_CSymm4(pathKey_IV, key_iv);
                        if (bl1 && bl2)
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không thể lưu file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Không thể lưu file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            //this.txtByteArray.Text = BitConverter.ToString(encrypted);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //1.
            txtplaintext.Text = "";
            txtKey.Text = "";
            txtinitVector.Text = "";
            txttextString.Text = "";
            MessageBox.Show("Hãy chọn tập tin đã bị mã hóa!", "Thông báo");
            string curentDirectory = System.IO.Directory.GetCurrentDirectory();
            string filter1 = "14110348 files (*.14110348)|*.14110348";
            string path = SelectFile(curentDirectory, filter1);
            if (path != null)
            {
                //2.
                MessageBox.Show("Hãy chọn tập tin chứa key và iv", "Thông báo");
                string filter2 = "txt files (*.txt)|*.txt";
                string pathKey_IV = SelectFile(curentDirectory, filter2);
                if (pathKey_IV != null)
                {
                    //3.
                    byte[] encrypted = Lib.Lib_L.ReadBinFile_CSymm4(path);
                    if (encrypted != null)
                    {
                        StringBuilder roundtrip = new StringBuilder();
                        foreach (byte b in encrypted)
                        {
                            roundtrip.Append(b.ToString() + " ");
                        }
                        this.txtByteArray.Text = roundtrip.ToString();

                        string[] key_iv = Lib.Lib_L.ReadTextFile_CSymm4(pathKey_IV).Split('\n');
                        string skey = key_iv[0];
                        string siv = key_iv[1];

                        string[] tempt = skey.Split('-');
                        key = new byte[tempt.Length];
                        int i = 0;
                        foreach (string s in tempt)
                        {
                            key[i] = Convert.ToByte(Convert.ToInt32(s, 16));
                            i++;
                        }
                        this.txtKey.Text = BitConverter.ToString(key);

                        tempt = siv.Split('-');
                        iv = new byte[tempt.Length];
                        i = 0;
                        foreach (string s in tempt)
                        {
                            iv[i] = Convert.ToByte(Convert.ToInt32(s, 16));
                            i++;
                        }
                        this.txtinitVector.Text = BitConverter.ToString(iv);
                        //4
                        symmAthm.setMode(mode);
                        symmAthm.setPadding(padding);
                        string recoveredplaintext = symmAthm.decrypt(encrypted, key, iv);
                        //5
                        this.txtrecoveredplaintext.Text = recoveredplaintext;
                    }
                }
                else
                    MessageBox.Show("Không có Key!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bntKey_Click(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                symmAthm = new RC2();
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(key);
            }
            else if (this.radRijndael.Checked)
            {
                symmAthm = new Rijndael();
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(key);
            }
            else if (this.radDES.Checked)
            {
                symmAthm = new DES();
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(key);
            }
            else if (this.radTripleDES.Checked)
            {
                symmAthm = new TripleDES();
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(key);
            }
        }

        private void bntInitVector_Click(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                symmAthm = new RC2();
                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(iv);
            }
            else if (this.radRijndael.Checked)
            {
                symmAthm = new Rijndael();
                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(iv);
            }
            else if (this.radDES.Checked)
            {
                symmAthm = new DES();
                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(iv);
            }
            else if (this.radTripleDES.Checked)
            {
                symmAthm = new TripleDES();
                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(iv);
            }
        }

        private void radRC2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                symmAthm = new RC2();

                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(symmAthm.getIV());
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(symmAthm.getKey());
            }
        }

        private void radRijndael_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radRijndael.Checked)
            {
                symmAthm = new Rijndael();

                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(symmAthm.getIV());
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(symmAthm.getKey());
            }
        }

        private void radDES_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radDES.Checked)
            {
                symmAthm = new DES();

                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(symmAthm.getIV());
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(symmAthm.getKey());
            }
        }

        private void radTripleDES_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radTripleDES.Checked)
            {
                symmAthm = new TripleDES();

                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(symmAthm.getIV());
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(symmAthm.getKey());
            }
        }
        private string SelectFile(string initialDirectory, string filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;

            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Select a file";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }
        private string SaveFile(string initialDirectory, string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = filter;
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Save file";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }

        private void radECB_CheckedChanged(object sender, EventArgs e)
        {
            if (radECB.Checked)
                mode = CipherMode.ECB;
        }

        private void radCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (radCBC.Checked)
                mode = CipherMode.CBC;
        }

        private void radCFB_CheckedChanged(object sender, EventArgs e)
        {
            if (radCFB.Checked)
                mode = CipherMode.CFB;
        }

        private void radPKCS7_CheckedChanged(object sender, EventArgs e)
        {
            if (radPKCS7.Checked)
                padding = PaddingMode.PKCS7;
        }

        private void radZeros_CheckedChanged(object sender, EventArgs e)
        {
            if (radZeros.Checked)
                padding = PaddingMode.Zeros;
        }

        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radNone.Checked)
                padding = PaddingMode.None;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.radDES.Checked = true;
            this.radECB.Checked = true;
            this.radPKCS7.Checked = true;
        }

        private void radISO10126_CheckedChanged(object sender, EventArgs e)
        {

            if (radISO10126.Checked)
                padding = PaddingMode.ISO10126;
        }

        private void radANSIX923_CheckedChanged(object sender, EventArgs e)
        {
            if (radANSIX923.Checked)
                padding = PaddingMode.ANSIX923;
        }
    }
}
