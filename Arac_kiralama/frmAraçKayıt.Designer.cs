namespace Arac_Kiralama
{
    partial class frmAraçKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçKayıt));
            Plakatxt = new TextBox();
            Ücrettxt = new TextBox();
            Kmtxt = new TextBox();
            Modeltxt = new TextBox();
            Renktxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            btnResim = new Button();
            openFileDialog1 = new OpenFileDialog();
            Markacombo = new ComboBox();
            Sericombo = new ComboBox();
            Yakitcombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new Point(122, 12);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new Size(151, 27);
            Plakatxt.TabIndex = 0;
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new Point(122, 354);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new Size(151, 27);
            Ücrettxt.TabIndex = 1;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new Point(122, 260);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new Size(151, 27);
            Kmtxt.TabIndex = 1;
            // 
            // Modeltxt
            // 
            Modeltxt.Location = new Point(122, 151);
            Modeltxt.Name = "Modeltxt";
            Modeltxt.Size = new Size(151, 27);
            Modeltxt.TabIndex = 2;
            // 
            // Renktxt
            // 
            Renktxt.Location = new Point(122, 204);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new Size(151, 27);
            Renktxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "PLAKA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 8;
            label2.Text = "MARKA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "SERİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 158);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 10;
            label4.Text = "MODEL(YIL)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 211);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "RENK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 263);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 12;
            label6.Text = "KM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 311);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 13;
            label7.Text = "YAKIT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 361);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 14;
            label8.Text = "KİRA ÜCRETİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(334, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = ımageList1;
            button1.Location = new Point(34, 419);
            button1.Name = "button1";
            button1.Size = new Size(101, 44);
            button1.TabIndex = 16;
            button1.Text = "KAYIT";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "aracekle.png");
            ımageList1.Images.SetKeyName(1, "iptal.jpg");
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.ImageList = ımageList1;
            button2.Location = new Point(157, 419);
            button2.Name = "button2";
            button2.Size = new Size(101, 44);
            button2.TabIndex = 17;
            button2.Text = "İPTAL";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnResim
            // 
            btnResim.Location = new Point(393, 135);
            btnResim.Name = "btnResim";
            btnResim.Size = new Size(117, 43);
            btnResim.TabIndex = 18;
            btnResim.Text = "RESİM EKLE";
            btnResim.UseVisualStyleBackColor = true;
            btnResim.Click += btnResim_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "Opel", "Renault", "Fiat", "Ford" });
            Markacombo.Location = new Point(118, 60);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new Size(151, 28);
            Markacombo.TabIndex = 19;
            Markacombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Sericombo
            // 
            Sericombo.FormattingEnabled = true;
            Sericombo.Location = new Point(122, 108);
            Sericombo.Name = "Sericombo";
            Sericombo.Size = new Size(151, 28);
            Sericombo.TabIndex = 20;
            // 
            // Yakitcombo
            // 
            Yakitcombo.FormattingEnabled = true;
            Yakitcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakitcombo.Location = new Point(118, 303);
            Yakitcombo.Name = "Yakitcombo";
            Yakitcombo.Size = new Size(151, 28);
            Yakitcombo.TabIndex = 21;
            // 
            // frmAraçKayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 494);
            Controls.Add(Yakitcombo);
            Controls.Add(Sericombo);
            Controls.Add(Markacombo);
            Controls.Add(btnResim);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
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
            Name = "frmAraçKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kayıt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Plakatxt;
        private TextBox Ücrettxt;
        private TextBox Kmtxt;
        private TextBox Modeltxt;
        private TextBox Renktxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button btnResim;
        private ImageList ımageList1;
        private OpenFileDialog openFileDialog1;
        private ComboBox Markacombo;
        private ComboBox Sericombo;
        private ComboBox Yakitcombo;
    }
}