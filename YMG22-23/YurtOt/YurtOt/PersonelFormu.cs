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
    public partial class PersonelFormu : Form
    {
        public PersonelFormu()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void PersonelFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet6.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)", bgl.baglanti());
            emir.Parameters.AddWithValue("@p1", TxtPerAd.Text);
            emir.Parameters.AddWithValue("@p2", TxtPerGorev.Text);
            emir.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayit Eklendi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("delete from Personel where Personelid=@c1", bgl.baglanti());
            emir.Parameters.AddWithValue("@c1", TxtPerid.Text);
            emir.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi başarılı gerçekleşti...");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim;
            secim = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            TxtPerAd.Text = ad;
            TxtPerGorev.Text = gorev;
            TxtPerid.Text = id;
            
          
        }
        public void temizle()
        {
            TxtPerAd.Clear();
            TxtPerGorev.Clear();
            TxtPerid.Clear();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("update Personel set PersonelAdSoyad=@c1,PersonelDepartman=@c2 where Personelid=@c3", bgl.baglanti());
            emir.Parameters.AddWithValue("@c1", TxtPerAd.Text);
            emir.Parameters.AddWithValue("@c2", TxtPerGorev.Text);
            emir.Parameters.AddWithValue("@c3", TxtPerid.Text);
            emir.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Guncelleme İşlemi başarılı gerçekleşti...");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
            temizle();
        }
    }
}
