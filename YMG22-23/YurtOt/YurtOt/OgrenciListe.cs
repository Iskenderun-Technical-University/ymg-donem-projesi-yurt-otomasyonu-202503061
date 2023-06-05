using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOt
{
    public partial class OgrenciListe : Form
    {
        public OgrenciListe()
        {
            InitializeComponent();
        }

        private void OgrenciListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet3.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayitDataSet3.Ogrenci);

        }

        int secim;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secim = dataGridView1.SelectedCells[0].RowIndex;
            OgrenciDuzunle fr = new OgrenciDuzunle();
            fr.id = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            fr.ad= dataGridView1.Rows[secim].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            fr.Tc= dataGridView1.Rows[secim].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secim].Cells[7].Value.ToString();
            fr.odaNo = dataGridView1.Rows[secim].Cells[8].Value.ToString();
            fr.veliadsoy = dataGridView1.Rows[secim].Cells[9].Value.ToString();
            fr.velitel = dataGridView1.Rows[secim].Cells[10].Value.ToString();
            fr.adres = dataGridView1.Rows[secim].Cells[11].Value.ToString();
            fr.Show();
            
        }
    }
}
