namespace Arac_Kiralama
{
    partial class frmMüşteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            btnEkle = new Button();
            ımageList1 = new ImageList(components);
            btnİptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 64);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 110);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "AD-SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 158);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "TELEFON";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 208);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "ADRES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 255);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "EMAİL";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(162, 69);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(162, 110);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 6;
            txtAdSoyad.TextChanged += textBox2_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(162, 158);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 7;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(162, 205);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            // 
            // btnEkle
            // 
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 1;
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(90, 327);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 36);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "iptal.jpg");
            ımageList1.Images.SetKeyName(1, "mstrkyt.png");
            // 
            // btnİptal
            // 
            btnİptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnİptal.ImageIndex = 0;
            btnİptal.ImageList = ımageList1;
            btnİptal.Location = new Point(216, 327);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(97, 36);
            btnİptal.TabIndex = 11;
            btnİptal.Text = "İPTAL";
            btnİptal.TextAlign = ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += button2_Click;
            // 
            // frmMüşteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(422, 450);
            Controls.Add(btnİptal);
            Controls.Add(btnEkle);
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
            Name = "frmMüşteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MüşteriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private Button btnEkle;
        private Button btnİptal;
        private ImageList ımageList1;
    }
}