namespace Lab06_Symm_14110348_14110385_2013
{
    partial class SymmetricAlgorithms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtinitVector = new System.Windows.Forms.TextBox();
            this.radRC2 = new System.Windows.Forms.RadioButton();
            this.radRijndael = new System.Windows.Forms.RadioButton();
            this.radTripleDES = new System.Windows.Forms.RadioButton();
            this.radDES = new System.Windows.Forms.RadioButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.bntInitVector = new System.Windows.Forms.Button();
            this.bntKey = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtplaintext = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttextString = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtByteArray = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtrecoveredplaintext = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radCFB = new System.Windows.Forms.RadioButton();
            this.radCBC = new System.Windows.Forms.RadioButton();
            this.radECB = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radANSIX923 = new System.Windows.Forms.RadioButton();
            this.radISO10126 = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.radZeros = new System.Windows.Forms.RadioButton();
            this.radPKCS7 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtinitVector
            // 
            this.txtinitVector.Location = new System.Drawing.Point(10, 339);
            this.txtinitVector.Margin = new System.Windows.Forms.Padding(4);
            this.txtinitVector.Multiline = true;
            this.txtinitVector.Name = "txtinitVector";
            this.txtinitVector.ReadOnly = true;
            this.txtinitVector.Size = new System.Drawing.Size(287, 62);
            this.txtinitVector.TabIndex = 27;
            // 
            // radRC2
            // 
            this.radRC2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radRC2.AutoSize = true;
            this.radRC2.Location = new System.Drawing.Point(142, 52);
            this.radRC2.Margin = new System.Windows.Forms.Padding(4);
            this.radRC2.Name = "radRC2";
            this.radRC2.Size = new System.Drawing.Size(56, 21);
            this.radRC2.TabIndex = 3;
            this.radRC2.Text = "RC2";
            this.radRC2.UseVisualStyleBackColor = true;
            this.radRC2.CheckedChanged += new System.EventHandler(this.radRC2_CheckedChanged);
            // 
            // radRijndael
            // 
            this.radRijndael.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radRijndael.AutoSize = true;
            this.radRijndael.Location = new System.Drawing.Point(11, 52);
            this.radRijndael.Margin = new System.Windows.Forms.Padding(4);
            this.radRijndael.Name = "radRijndael";
            this.radRijndael.Size = new System.Drawing.Size(80, 21);
            this.radRijndael.TabIndex = 2;
            this.radRijndael.Text = "Rijndael";
            this.radRijndael.UseVisualStyleBackColor = true;
            this.radRijndael.CheckedChanged += new System.EventHandler(this.radRijndael_CheckedChanged);
            // 
            // radTripleDES
            // 
            this.radTripleDES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTripleDES.AutoSize = true;
            this.radTripleDES.Location = new System.Drawing.Point(142, 23);
            this.radTripleDES.Margin = new System.Windows.Forms.Padding(4);
            this.radTripleDES.Name = "radTripleDES";
            this.radTripleDES.Size = new System.Drawing.Size(97, 21);
            this.radTripleDES.TabIndex = 1;
            this.radTripleDES.Text = "Triple DES";
            this.radTripleDES.UseVisualStyleBackColor = true;
            this.radTripleDES.CheckedChanged += new System.EventHandler(this.radTripleDES_CheckedChanged);
            // 
            // radDES
            // 
            this.radDES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDES.AutoSize = true;
            this.radDES.Location = new System.Drawing.Point(12, 23);
            this.radDES.Margin = new System.Windows.Forms.Padding(4);
            this.radDES.Name = "radDES";
            this.radDES.Size = new System.Drawing.Size(57, 21);
            this.radDES.TabIndex = 0;
            this.radDES.Text = "DES";
            this.radDES.UseVisualStyleBackColor = true;
            this.radDES.CheckedChanged += new System.EventHandler(this.radDES_CheckedChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(10, 217);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(287, 62);
            this.txtKey.TabIndex = 26;
            // 
            // bntInitVector
            // 
            this.bntInitVector.Location = new System.Drawing.Point(68, 299);
            this.bntInitVector.Margin = new System.Windows.Forms.Padding(4);
            this.bntInitVector.Name = "bntInitVector";
            this.bntInitVector.Size = new System.Drawing.Size(179, 32);
            this.bntInitVector.TabIndex = 25;
            this.bntInitVector.Text = "New Random Init Vector";
            this.bntInitVector.UseVisualStyleBackColor = true;
            this.bntInitVector.Click += new System.EventHandler(this.bntInitVector_Click);
            // 
            // bntKey
            // 
            this.bntKey.Location = new System.Drawing.Point(68, 177);
            this.bntKey.Margin = new System.Windows.Forms.Padding(4);
            this.bntKey.Name = "bntKey";
            this.bntKey.Size = new System.Drawing.Size(179, 32);
            this.bntKey.TabIndex = 24;
            this.bntKey.Text = "New Random Key";
            this.bntKey.UseVisualStyleBackColor = true;
            this.bntKey.Click += new System.EventHandler(this.bntKey_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEncrypt.Location = new System.Drawing.Point(12, 317);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(103, 32);
            this.btnEncrypt.TabIndex = 28;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRC2);
            this.groupBox1.Controls.Add(this.radRijndael);
            this.groupBox1.Controls.Add(this.radTripleDES);
            this.groupBox1.Controls.Add(this.radDES);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symmetric Algorithms";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(305, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 385);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 306);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtplaintext);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(643, 145);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plain Text";
            // 
            // txtplaintext
            // 
            this.txtplaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtplaintext.Location = new System.Drawing.Point(29, 23);
            this.txtplaintext.Margin = new System.Windows.Forms.Padding(4);
            this.txtplaintext.Multiline = true;
            this.txtplaintext.Name = "txtplaintext";
            this.txtplaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtplaintext.Size = new System.Drawing.Size(586, 114);
            this.txtplaintext.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txttextString);
            this.groupBox3.Location = new System.Drawing.Point(4, 157);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(643, 145);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciphertext displayed as Text String";
            // 
            // txttextString
            // 
            this.txttextString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttextString.Location = new System.Drawing.Point(29, 27);
            this.txttextString.Margin = new System.Windows.Forms.Padding(4);
            this.txttextString.Multiline = true;
            this.txttextString.Name = "txttextString";
            this.txttextString.ReadOnly = true;
            this.txttextString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttextString.Size = new System.Drawing.Size(586, 114);
            this.txttextString.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(676, 306);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtByteArray);
            this.groupBox6.Location = new System.Drawing.Point(4, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(668, 145);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ciphertext Displayed as Byte Array";
            // 
            // txtByteArray
            // 
            this.txtByteArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtByteArray.Location = new System.Drawing.Point(29, 23);
            this.txtByteArray.Margin = new System.Windows.Forms.Padding(4);
            this.txtByteArray.Multiline = true;
            this.txtByteArray.Name = "txtByteArray";
            this.txtByteArray.ReadOnly = true;
            this.txtByteArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByteArray.Size = new System.Drawing.Size(611, 114);
            this.txtByteArray.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.txtrecoveredplaintext);
            this.groupBox7.Location = new System.Drawing.Point(4, 157);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(668, 145);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Recovered Plaintext";
            // 
            // txtrecoveredplaintext
            // 
            this.txtrecoveredplaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrecoveredplaintext.Location = new System.Drawing.Point(29, 27);
            this.txtrecoveredplaintext.Margin = new System.Windows.Forms.Padding(4);
            this.txtrecoveredplaintext.Multiline = true;
            this.txtrecoveredplaintext.Name = "txtrecoveredplaintext";
            this.txtrecoveredplaintext.ReadOnly = true;
            this.txtrecoveredplaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtrecoveredplaintext.Size = new System.Drawing.Size(611, 114);
            this.txtrecoveredplaintext.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecrypt.Location = new System.Drawing.Point(12, 317);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(103, 32);
            this.btnDecrypt.TabIndex = 32;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radCFB);
            this.groupBox4.Controls.Add(this.radCBC);
            this.groupBox4.Controls.Add(this.radECB);
            this.groupBox4.Location = new System.Drawing.Point(305, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(256, 100);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mode";
            // 
            // radCFB
            // 
            this.radCFB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radCFB.AutoSize = true;
            this.radCFB.Location = new System.Drawing.Point(12, 52);
            this.radCFB.Margin = new System.Windows.Forms.Padding(4);
            this.radCFB.Name = "radCFB";
            this.radCFB.Size = new System.Drawing.Size(55, 21);
            this.radCFB.TabIndex = 4;
            this.radCFB.Text = "CFB";
            this.radCFB.UseVisualStyleBackColor = true;
            this.radCFB.CheckedChanged += new System.EventHandler(this.radCFB_CheckedChanged);
            // 
            // radCBC
            // 
            this.radCBC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radCBC.AutoSize = true;
            this.radCBC.Location = new System.Drawing.Point(141, 23);
            this.radCBC.Margin = new System.Windows.Forms.Padding(4);
            this.radCBC.Name = "radCBC";
            this.radCBC.Size = new System.Drawing.Size(56, 21);
            this.radCBC.TabIndex = 1;
            this.radCBC.Text = "CBC";
            this.radCBC.UseVisualStyleBackColor = true;
            this.radCBC.CheckedChanged += new System.EventHandler(this.radCBC_CheckedChanged);
            // 
            // radECB
            // 
            this.radECB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radECB.AutoSize = true;
            this.radECB.Location = new System.Drawing.Point(12, 23);
            this.radECB.Margin = new System.Windows.Forms.Padding(4);
            this.radECB.Name = "radECB";
            this.radECB.Size = new System.Drawing.Size(56, 21);
            this.radECB.TabIndex = 0;
            this.radECB.Text = "ECB";
            this.radECB.UseVisualStyleBackColor = true;
            this.radECB.CheckedChanged += new System.EventHandler(this.radECB_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radANSIX923);
            this.groupBox5.Controls.Add(this.radISO10126);
            this.groupBox5.Controls.Add(this.radNone);
            this.groupBox5.Controls.Add(this.radZeros);
            this.groupBox5.Controls.Add(this.radPKCS7);
            this.groupBox5.Location = new System.Drawing.Point(569, 11);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(405, 100);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Padding";
            // 
            // radANSIX923
            // 
            this.radANSIX923.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radANSIX923.AutoSize = true;
            this.radANSIX923.Location = new System.Drawing.Point(261, 23);
            this.radANSIX923.Margin = new System.Windows.Forms.Padding(4);
            this.radANSIX923.Name = "radANSIX923";
            this.radANSIX923.Size = new System.Drawing.Size(93, 21);
            this.radANSIX923.TabIndex = 4;
            this.radANSIX923.Text = "ANSIX923";
            this.radANSIX923.UseVisualStyleBackColor = true;
            this.radANSIX923.CheckedChanged += new System.EventHandler(this.radANSIX923_CheckedChanged);
            // 
            // radISO10126
            // 
            this.radISO10126.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radISO10126.AutoSize = true;
            this.radISO10126.Location = new System.Drawing.Point(140, 52);
            this.radISO10126.Margin = new System.Windows.Forms.Padding(4);
            this.radISO10126.Name = "radISO10126";
            this.radISO10126.Size = new System.Drawing.Size(92, 21);
            this.radISO10126.TabIndex = 3;
            this.radISO10126.Text = "ISO10126";
            this.radISO10126.UseVisualStyleBackColor = true;
            this.radISO10126.CheckedChanged += new System.EventHandler(this.radISO10126_CheckedChanged);
            // 
            // radNone
            // 
            this.radNone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radNone.AutoSize = true;
            this.radNone.Location = new System.Drawing.Point(11, 52);
            this.radNone.Margin = new System.Windows.Forms.Padding(4);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(63, 21);
            this.radNone.TabIndex = 2;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            this.radNone.CheckedChanged += new System.EventHandler(this.radNone_CheckedChanged);
            // 
            // radZeros
            // 
            this.radZeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radZeros.AutoSize = true;
            this.radZeros.Location = new System.Drawing.Point(140, 23);
            this.radZeros.Margin = new System.Windows.Forms.Padding(4);
            this.radZeros.Name = "radZeros";
            this.radZeros.Size = new System.Drawing.Size(66, 21);
            this.radZeros.TabIndex = 1;
            this.radZeros.Text = "Zeros";
            this.radZeros.UseVisualStyleBackColor = true;
            this.radZeros.CheckedChanged += new System.EventHandler(this.radZeros_CheckedChanged);
            // 
            // radPKCS7
            // 
            this.radPKCS7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPKCS7.AutoSize = true;
            this.radPKCS7.Location = new System.Drawing.Point(12, 23);
            this.radPKCS7.Margin = new System.Windows.Forms.Padding(4);
            this.radPKCS7.Name = "radPKCS7";
            this.radPKCS7.Size = new System.Drawing.Size(73, 21);
            this.radPKCS7.TabIndex = 0;
            this.radPKCS7.Text = "PKCS7";
            this.radPKCS7.UseVisualStyleBackColor = true;
            this.radPKCS7.CheckedChanged += new System.EventHandler(this.radPKCS7_CheckedChanged);
            // 
            // SymmetricAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 513);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtinitVector);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.bntInitVector);
            this.Controls.Add(this.bntKey);
            this.Controls.Add(this.groupBox1);
            this.Name = "SymmetricAlgorithms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symmetric Algorithms";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtinitVector;
        private System.Windows.Forms.RadioButton radRC2;
        private System.Windows.Forms.RadioButton radRijndael;
        private System.Windows.Forms.RadioButton radTripleDES;
        private System.Windows.Forms.RadioButton radDES;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button bntInitVector;
        private System.Windows.Forms.Button bntKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtplaintext;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttextString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtrecoveredplaintext;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radCFB;
        private System.Windows.Forms.RadioButton radCBC;
        private System.Windows.Forms.RadioButton radECB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.RadioButton radZeros;
        private System.Windows.Forms.RadioButton radPKCS7;
        private System.Windows.Forms.TextBox txtByteArray;
        private System.Windows.Forms.RadioButton radISO10126;
        private System.Windows.Forms.RadioButton radANSIX923;
    }
}