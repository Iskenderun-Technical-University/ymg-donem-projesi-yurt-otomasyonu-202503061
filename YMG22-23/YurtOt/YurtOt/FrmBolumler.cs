using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOt
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LJ30V5U\\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@bolum)", baglanti);
                komut1.Parameters.AddWithValue("@bolum", TxtBolumad.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bölüm başarı ile eklendi :)");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!!!!! Bölüm eklenemedi :(");
            }
        }
    }
}
