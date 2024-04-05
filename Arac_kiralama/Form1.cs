namespace Arac_Kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüþteriEkle ekle = new frmMüþteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüþteriListele listele = new frmMüþteriListele();
            listele.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAraçKayýt kayýt = new frmAraçKayýt();
            kayýt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAraçListele listele = new frmAraçListele();  
            listele.ShowDialog();
        }
    }
}