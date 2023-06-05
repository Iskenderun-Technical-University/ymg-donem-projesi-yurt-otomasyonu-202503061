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
    public partial class GiderGuncelleme : Form
    {
        public GiderGuncelleme()
        {
            InitializeComponent();
        }

        public string id,elektrik, su, dogalgaz, internet, personel, diger, gida;
        private void GiderGuncelleme_Load(object sender, EventArgs e)
        {
            TxtGiderid.Text = id;
            TxtElektirik.Text = elektrik;
            TxtDiger.Text = diger;
            TxtDogalGaz.Text = dogalgaz;
            TxtGida.Text = gida;
            TxtInternet.Text = internet;
            TxtPersonel.Text = personel;
            TxtSu.Text = su;
        }
    }
}
