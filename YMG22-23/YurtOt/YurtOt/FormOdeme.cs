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
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim;
            string id, ad, soyad, kalan;
            secim = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secim].Cells[3].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtKalanBorc.Text = kalan;
            TxtOgrid.Text = id;



        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            // odenen tutari dusme
            int yeniborc, odenen, kalan;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalanBorc.Text);
            yeniborc = kalan - odenen;
            TxtKalanBorc.Text = yeniborc.ToString();
            //veri tabanina kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@c1 where Ogrid=@c2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@c2", TxtOgrid.Text);
            komut.Parameters.AddWithValue("@c1", TxtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borc Odendi");
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

            //Kasa tablosuna ekleme yapma
            SqlCommand emir = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@c1,@c2)", bgl.baglanti());
            emir.Parameters.AddWithValue("@c1", TxtOdenenAy.Text);
            emir.Parameters.AddWithValue("@c2", TxtOdenen.Text);
            emir.ExecuteNonQuery();
            bgl.baglanti().Close();



        }
    }
}
