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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if(TxtKullaniciAdi.Text== "gokhan" && TxtSifre.Text == "123456")
            {
                AnaForm fr = new AnaForm();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatali giris yaptiniz.");
            }
        }
    }
}
