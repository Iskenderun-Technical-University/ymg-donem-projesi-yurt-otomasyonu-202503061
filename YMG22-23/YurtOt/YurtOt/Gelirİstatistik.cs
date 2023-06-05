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
    public partial class Gelirİstatistik : Form
    {
        public Gelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();


        private void Gelirİstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("Select Sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = emir.ExecuteReader();
            while(oku.Read())
            {
                LblPara.Text = oku[0].ToString() + "TL";
                    
            }

            bgl.baglanti().Close();


            SqlCommand emir1 = new SqlCommand("Select distinct(OdemeAy) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = emir1.ExecuteReader();
            while(oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("select sum(OdemeMiktar) From Kasa where OdemeAy=@c1", bgl.baglanti());
            emir.Parameters.AddWithValue("@c1", CmbAy.Text);
            SqlDataReader oku = emir.ExecuteReader();
            while(oku.Read())
            {
                labelAyKazanc.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
