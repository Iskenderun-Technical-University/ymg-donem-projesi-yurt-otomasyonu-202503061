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
    public partial class FormOgrKayit : Form
    {
        public FormOgrKayit()
        {
            InitializeComponent();
        }

        // DESKTOP-LJ30V5U\SQLEXPRESS
        // Data Source=DESKTOP-LJ30V5U\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True
        SqlBaglanti bgl = new SqlBaglanti();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOgrKayit_Load(object sender, EventArgs e)
        {
            //combobaxa veri cekme
           
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();
            //bos odalari goruntuleme 
            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite != OdaAktif ", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
            // öğrenci panle formu oluşturulması
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // kaydet butonu komutlari
                SqlCommand komutkayit = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@ad,@soyad,@tc,@telefon,@dogum,@bolum,@mail,@no,@veliadsoyad,@velitelefon,@veliadres)", bgl.baglanti());
                komutkayit.Parameters.AddWithValue("@ad", TxtOgrAd.Text);
                komutkayit.Parameters.AddWithValue("@soyad", TxtOgrSoyad.Text);
                komutkayit.Parameters.AddWithValue("@tc", MskTC.Text);
                komutkayit.Parameters.AddWithValue("@telefon", MskOgrTelefon.Text);
                komutkayit.Parameters.AddWithValue("@dogum", MskDogum.Text);
                komutkayit.Parameters.AddWithValue("@bolum", CmbBolum.Text);
                komutkayit.Parameters.AddWithValue("@mail", TxtMail.Text);
                komutkayit.Parameters.AddWithValue("@no", CmbOdaNo.Text);
                komutkayit.Parameters.AddWithValue("@veliadsoyad", TxtVeliAdSoyad.Text);
                komutkayit.Parameters.AddWithValue("@velitelefon", MskVeliTelefon.Text);
                komutkayit.Parameters.AddWithValue("@veliadres", RchAdres.Text);
                komutkayit.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayit basarili bir sekilde eklenmistir bilginize :)");
            }
            catch (Exception)
            {

                MessageBox.Show("UYARI!!! Kayit basarili bir sekilde eklenememistir bilginize :(");
            }

        }
    }
}
