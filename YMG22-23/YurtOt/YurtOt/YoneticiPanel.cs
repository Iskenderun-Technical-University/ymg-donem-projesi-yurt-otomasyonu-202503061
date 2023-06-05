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
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void YoneticiPanel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet5.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values(@p1,@p2)", bgl.baglanti());
            emir.Parameters.AddWithValue("@p1", TxtKullaniciad.Text);
            emir.Parameters.AddWithValue("@p2", TxtSifre.Text);
            emir.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yonetici Eklendi");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim;
            secim = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            TxtKullaniciad.Text = ad;
            TxtSifre.Text = sifre;
            TxtYoneticiid.Text = id;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand emir = new SqlCommand("delete from Admin where Yoneticiid=@c1", bgl.baglanti());
            emir.Parameters.AddWithValue("@c1", TxtYoneticiid.Text);
            emir.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi başarılı gerçekleşti...");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet5.Admin);
        }
    }
}
