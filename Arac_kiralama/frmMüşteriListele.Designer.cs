namespace Arac_Kiralama
{
    partial class frmMüşteriListele
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriListele));
            dataGridView1 = new DataGridView();
            btnİptal = new Button();
            ımageList1 = new ImageList(components);
            btngGüncelle = new Button();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSil = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PowderBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(686, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnİptal
            // 
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 2;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(145, 339);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(97, 36);
            btnİptal.TabIndex = 23;
            btnİptal.Text = "İPTAL";
            btnİptal.TextAlign = ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "iptal.jpg");
            ımageList1.Images.SetKeyName(1, "mstrkyt.png");
            ımageList1.Images.SetKeyName(2, "kapat.png");
            // 
            // btngGüncelle
            // 
            btngGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btngGüncelle.ImageIndex = 1;
            btngGüncelle.ImageList = ımageList1;
            btngGüncelle.Location = new Point(12, 339);
            btngGüncelle.Name = "btngGüncelle";
            btngGüncelle.Size = new Size(120, 36);
            btngGüncelle.TabIndex = 22;
            btngGüncelle.Text = "GÜNCELLE";
            btngGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btngGüncelle.UseVisualStyleBackColor = true;
            btngGüncelle.Click += btngGüncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 21;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(117, 217);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 20;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(117, 170);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 19;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(117, 122);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 18;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(117, 81);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 267);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 16;
            label5.Text = "EMAİL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 220);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 15;
            label4.Text = "ADRES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 14;
            label3.Text = "TELEFON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 13;
            label2.Text = "AD-SOYAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 76);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 12;
            label1.Text = "TC";
            // 
            // btnSil
            // 
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 0;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(1023, 67);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 39);
            btnSil.TabIndex = 24;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(750, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(674, 27);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 26;
            label6.Text = "TC ARA";
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1127, 632);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(btnSil);
            Controls.Add(btnİptal);
            Controls.Add(btngGüncelle);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmMüşteriListele";
            Text = "frmMüşteriListele";
            Load += frmMüşteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnİptal;
        private Button btngGüncelle;
        private ImageList ımageList1;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private TextBox textBox1;
        private Label label6;
    }
}