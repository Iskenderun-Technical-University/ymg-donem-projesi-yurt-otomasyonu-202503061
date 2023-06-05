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
    public partial class GiderGuncelleme : Form
    {
        public GiderGuncelleme()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        public string id,elektrik, su, dogalgaz, internet, personel, diger, gida;

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emir = new SqlCommand("update Giderler set Elektrik=@g1,Su=@g2,Dogalgaz=@g3,internet=@g4,Gıda=@g5,Personel=@g6,Diger=@g7 where Odemeid=@g8", bgl.baglanti());
                emir.Parameters.AddWithValue("@g8", TxtGiderid.Text);
                emir.Parameters.AddWithValue("@g1", TxtElektirik.Text);
                emir.Parameters.AddWithValue("@g2", TxtSu.Text);
                emir.Parameters.AddWithValue("@g3", TxtDogalGaz.Text);
                emir.Parameters.AddWithValue("@g4", TxtInternet.Text);
                emir.Parameters.AddWithValue("@g5", TxtGida.Text);
                emir.Parameters.AddWithValue("@g6", TxtPersonel.Text);
                emir.Parameters.AddWithValue("@g7", TxtDiger.Text);
                emir.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Basari ile guncellenmistir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Basari ile guncellenmemistir.");
            }


        }

        private void GiderGuncelleme_Load(object sender, EventArgs e)
        {
            TxtGiderid.Text = id;
            TxtElektirik.Text = elektrik;
            TxtDiger.Text = diger;
            TxtDogalGaz.Text = dogalgaz;
            TxtGida.Text = gida;
            TxtInternet.Text = internet;
            TxtPersonel.Text = personel;
            TxtSu.Text = su;
        }
    }
}
