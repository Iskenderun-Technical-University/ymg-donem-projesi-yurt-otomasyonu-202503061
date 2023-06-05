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
    public partial class OgrenciDuzunle : Form
    {
        public OgrenciDuzunle()
        {
            InitializeComponent();
        }
        public string id,soyad,ad,telefon,dogum,Tc,bolum,mail,odaNo,veliadsoy,velitel,adres;
        SqlBaglanti bgl = new SqlBaglanti(); 

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emir = new SqlCommand("update Ogrenci set OgrAd=@c2,OgrSoyad=@c3,OgrTC=@c4,OgrTelefon=@c5,OgrDogum=@c6,OgrBolum=@c7,OgrMail=@c8,OgrOdaNo=@c9,OgrVeliAdSoyad=@c10,OgrVeliTelefon=@c11,OgrVeliAdres=@c12 where Ogrid=@c1", bgl.baglanti());
                emir.Parameters.AddWithValue("@c1", TxtOgrid.Text);
                emir.Parameters.AddWithValue("@c2", TxtOgrAd.Text);
                emir.Parameters.AddWithValue("@c3", TxtOgrSoyad.Text);
                emir.Parameters.AddWithValue("@c4", MskTC.Text);
                emir.Parameters.AddWithValue("@c5", MskOgrTelefon.Text);
                emir.Parameters.AddWithValue("@c6", MskDogum.Text);
                emir.Parameters.AddWithValue("@c7", CmbBolum.Text);
                emir.Parameters.AddWithValue("@c8", TxtMail.Text);
                emir.Parameters.AddWithValue("@c9", CmbOdaNo.Text);
                emir.Parameters.AddWithValue("@c10", TxtVeliAdSoyad.Text);
                emir.Parameters.AddWithValue("@c11", MskVeliTelefon.Text);
                emir.Parameters.AddWithValue("@c12", RchAdres.Text);
                emir.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Basari ile guncellendi :)");
           

            }
            catch (Exception)
            {

                MessageBox.Show("Basari ile guncellenemedi :(");
            }
          




        }

        private void OgrenciDuzunle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = Tc;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odaNo;
            TxtVeliAdSoyad.Text = veliadsoy;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = adres;
        }

        
    }
}
