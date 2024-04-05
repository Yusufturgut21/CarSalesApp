namespace Arac_Kiralama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button7 = new Button();
            ımageList1 = new ImageList(components);
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1687, 121);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1486, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 62);
            label3.TabIndex = 8;
            label3.Text = "yusuf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1550, 62);
            label2.Name = "label2";
            label2.Size = new Size(164, 62);
            label2.TabIndex = 7;
            label2.Text = "AUTO";
            // 
            // button7
            // 
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.ImageIndex = 3;
            button7.ImageList = ımageList1;
            button7.Location = new Point(920, 12);
            button7.Name = "button7";
            button7.Size = new Size(141, 89);
            button7.TabIndex = 6;
            button7.Text = "ÇIKIŞ";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "araba1.jpg");
            ımageList1.Images.SetKeyName(1, "aracekle.png");
            ımageList1.Images.SetKeyName(2, "araclist.jpg");
            ımageList1.Images.SetKeyName(3, "kapat.png");
            ımageList1.Images.SetKeyName(4, "mstrkyt.png");
            ımageList1.Images.SetKeyName(5, "satis.png");
            ımageList1.Images.SetKeyName(6, "sözleşme.jpg");
            // 
            // button6
            // 
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.ImageIndex = 6;
            button6.ImageList = ımageList1;
            button6.Location = new Point(768, 12);
            button6.Name = "button6";
            button6.Size = new Size(138, 89);
            button6.TabIndex = 5;
            button6.Text = "SATIŞLAR";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageIndex = 2;
            button4.ImageList = ımageList1;
            button4.Location = new Point(474, 12);
            button4.Name = "button4";
            button4.Size = new Size(135, 89);
            button4.TabIndex = 3;
            button4.Text = "ARAÇ LİSTELEME";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.ImageIndex = 5;
            button5.ImageList = ımageList1;
            button5.Location = new Point(623, 12);
            button5.Name = "button5";
            button5.Size = new Size(131, 89);
            button5.TabIndex = 4;
            button5.Text = "SÖZLEŞME";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.ImageIndex = 1;
            button3.ImageList = ımageList1;
            button3.Location = new Point(316, 12);
            button3.Name = "button3";
            button3.Size = new Size(144, 89);
            button3.TabIndex = 2;
            button3.Text = "ARAÇ KAYIT";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.ImageIndex = 2;
            button2.ImageList = ımageList1;
            button2.Location = new Point(158, 12);
            button2.Name = "button2";
            button2.Size = new Size(144, 89);
            button2.TabIndex = 1;
            button2.Text = "MÜŞTERİ LİSTELEME";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageIndex = 4;
            button1.ImageList = ımageList1;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 89);
            button1.TabIndex = 0;
            button1.Text = "MÜŞTER EKLEME";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1687, 737);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANA SAYFA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private ImageList ımageList1;
        private Label label2;
        private Label label3;
    }
}