namespace Arac_Kiralama
{
    partial class frmAraçListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçListele));
            dataGridView1 = new DataGridView();
            Yakitcombo = new ComboBox();
            Sericombo = new ComboBox();
            Markacombo = new ComboBox();
            btnResim = new Button();
            button2 = new Button();
            ımageList1 = new ImageList(components);
            btnGüncelle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Renktxt = new TextBox();
            Modeltxt = new TextBox();
            Kmtxt = new TextBox();
            Ücrettxt = new TextBox();
            Plakatxt = new TextBox();
            comboBox1 = new ComboBox();
            btnSil = new Button();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(310, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(928, 634);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Yakitcombo
            // 
            Yakitcombo.FormattingEnabled = true;
            Yakitcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakitcombo.Location = new Point(126, 343);
            Yakitcombo.Name = "Yakitcombo";
            Yakitcombo.Size = new Size(151, 28);
            Yakitcombo.TabIndex = 41;
            // 
            // Sericombo
            // 
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(130, 148);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(151, 28);
            Sericombo.TabIndex = 40;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault", "Fiat", "Ford" });
            Markacombo.Location = new Point(126, 100);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(151, 28);
            Markacombo.TabIndex = 39;
            // 
            // btnResim
            // 
            btnResim.Location = new Point(85, 623);
            btnResim.Name = "btnResim";
            btnResim.Size = new Size(134, 26);
            btnResim.TabIndex = 38;
            btnResim.Text = "RESİM DEĞİŞTİR";
            btnResim.UseVisualStyleBackColor = true;
            btnResim.Click += btnResim_Click;
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.ImageList = ımageList1;
            button2.Location = new Point(156, 693);
            button2.Name = "button2";
            button2.Size = new Size(110, 44);
            button2.TabIndex = 37;
            button2.Text = "İPTAL";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "iptal.jpg");
            ımageList1.Images.SetKeyName(1, "kapat.png");
            ımageList1.Images.SetKeyName(2, "mstrkyt.png");
            // 
            // btnGüncelle
            // 
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.ImageIndex = 2;
            btnGüncelle.ImageList = ımageList1;
            btnGüncelle.Location = new Point(27, 693);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(119, 44);
            btnGüncelle.TabIndex = 36;
            btnGüncelle.Text = "GÜNCELLE";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 401);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 34;
            label8.Text = "KİRA ÜCRETİ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 351);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 33;
            label7.Text = "YAKIT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 303);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 32;
            label6.Text = "KM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 251);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 31;
            label5.Text = "RENK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 198);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 30;
            label4.Text = "MODEL(YIL)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 156);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 29;
            label3.Text = "SERİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 28;
            label2.Text = "MARKA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 27;
            label1.Text = "PLAKA";
            // 
            // Renktxt
            // 
            Renktxt.Location = new Point(130, 244);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new Size(151, 27);
            Renktxt.TabIndex = 26;
            // 
            // Modeltxt
            // 
            Modeltxt.Location = new Point(130, 191);
            Modeltxt.Name = "Modeltxt";
            Modeltxt.Size = new Size(151, 27);
            Modeltxt.TabIndex = 25;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new Point(130, 300);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(151, 27);
            Kmtxt.TabIndex = 23;
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new Point(130, 394);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(151, 27);
            Ücrettxt.TabIndex = 24;
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new Point(130, 52);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(151, 27);
            Plakatxt.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tüm Araçlar", "Boş Araçlar", "Dolu Araçlar" });
            comboBox1.Location = new Point(1087, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 0;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(1244, 52);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(109, 42);
            btnSil.TabIndex = 43;
            btnSil.Text = "SİL";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(8, 445);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1365, 768);
            Controls.Add(pictureBox2);
            Controls.Add(btnSil);
            Controls.Add(comboBox1);
            Controls.Add(Yakitcombo);
            Controls.Add(Sericombo);
            Controls.Add(Markacombo);
            Controls.Add(btnResim);
            Controls.Add(button2);
            Controls.Add(btnGüncelle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Renktxt);
            Controls.Add(Modeltxt);
            Controls.Add(Kmtxt);
            Controls.Add(Ücrettxt);
            Controls.Add(Plakatxt);
            Controls.Add(dataGridView1);
            Name = "frmAraçListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Listeleme Sayfası";
            Load += frmAraçListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox Yakitcombo;
        private ComboBox Sericombo;
        private ComboBox Markacombo;
        private Button btnResim;
        private Button button2;
        private Button btnGüncelle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Renktxt;
        private TextBox Modeltxt;
        private TextBox Kmtxt;
        private TextBox Ücrettxt;
        private TextBox Plakatxt;
        private ComboBox comboBox1;
        private Button btnSil;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private ImageList ımageList1;
    }
}