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
    public partial class GiderFormu : Form
    {
        public GiderFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void GiderFormu_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emir = new SqlCommand("insert into Giderler(Elektrik,Su,Dogalgaz,internet,Gıda,Personel,Diger) values(@c1,@c2,@c3,@c4,@c5,@c6,@c7)", bgl.baglanti());
                emir.Parameters.AddWithValue("@c1", TxtElektirik.Text);
                emir.Parameters.AddWithValue("@c2", TxtSu.Text);
                emir.Parameters.AddWithValue("@c3", TxtDogalGaz.Text);
                emir.Parameters.AddWithValue("@c4", TxtInternet.Text);
                emir.Parameters.AddWithValue("@c5", TxtGida.Text);
                emir.Parameters.AddWithValue("@c6", TxtPersonel.Text);
                emir.Parameters.AddWithValue("@c7", TxtDiger.Text);
                emir.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Basari ile kaydedilmistir :)");
            }
            catch (Exception)
            {
                MessageBox.Show("Basari ile kaydedilememistir :(");

            }
        }
    }
}
