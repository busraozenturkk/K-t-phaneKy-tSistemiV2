using KütüphaneKyıtSistemiV2.Model;
using System.Windows.Forms;

namespace KütüphaneKyıtSistemiV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            ktp.Ad = textBox1.Text;
            ktp.Yazar = textBox2.Text;
            ktp.Yayınevi = textBox3.Text;
            ktp.Fiyat = textBox4.Text;


            // Kaydet metodu
            ktp.Kaydet(ktp);

            MessageBox.Show("Kayıt Başarılı", "Kitap Kaydı");
            Yukle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        public void Yukle()
        {
            dataGridView1.DataSource = null;
            Kitap ktp = new Kitap();
            dataGridView1.DataSource = ktp.Get();
        }
    }
}