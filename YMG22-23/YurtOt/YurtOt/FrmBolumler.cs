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

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@bolum)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@bolum", TxtBolumad.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm başarı ile eklendi :)");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!!!!! Bölüm eklenemedi :(");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme isleme tamamlandi");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata,islem gerceklesmedi");
            }
        }

        int secim;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolum;
            secim = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            bolum = dataGridView1.Rows[secim].Cells[1].Value.ToString();

            TxtBolumad.Text = bolum;
            TxtBolumid.Text = id;

        }

        private void PcbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update Bolumler Set BolumAd=@p1 where Bolumid=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut2.Parameters.AddWithValue("@p1", TxtBolumad.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giincelleme Gerceklesti");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
