using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class Form1 : Form
    {
        // Data Source=DESKTOP-LJ30V5U\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True bağlantı
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtOgrAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextOgrSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskOgrTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskDogum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CmbOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtVeliAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskVeliTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
