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
    public partial class GiderList : Form
    {
        public GiderList()
        {
            InitializeComponent();
        }

        private void GiderList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet4.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtKayitDataSet4.Giderler);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim;
            GiderGuncelleme frg = new GiderGuncelleme();
            secim = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            frg.gida = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            frg.diger = dataGridView1.Rows[secim].Cells[7].Value.ToString();
            frg.Show();

        }
    }
}
