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
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LJ30V5U\\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOgrKayit_Load(object sender, EventArgs e)
        {
            //combobaxa veri cekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
            //bos odalari goruntuleme 
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite != OdaAktif ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            baglanti.Close();
        }
    }
}
