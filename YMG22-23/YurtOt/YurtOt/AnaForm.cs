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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayitDataSet1.Ogrenci);


            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void öğrenciEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOgrKayit gr = new FormOgrKayit();
            gr.Show();
        }

        private void öğrenciListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OgrenciListe ol = new OgrenciListe();
            ol.Show();  
        }

        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciDuzunle od = new OgrenciDuzunle();
            od.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bol = new FrmBolumler();
            bol.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bol = new FrmBolumler();
            bol.Show();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOdeme ode = new FormOdeme();
            ode.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderFormu gider = new GiderFormu();
            gider.Show();
        }

        private void giderİstatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiderList gl = new GiderList();
            gl.Show();
        }

        private void gelirİstatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gelirİstatistik gi = new Gelirİstatistik();
            gi.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiPanel yp = new YoneticiPanel();
            yp.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelFormu pf = new PersonelFormu();
            pf.Show();
        }
    }
}
