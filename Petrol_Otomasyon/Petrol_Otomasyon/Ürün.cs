using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class Ürün : Form
    {
        public Ürün()
        {
            InitializeComponent();
        }



        private void Ürün_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrol_otomasyonDataSet4.ürün' table. You can move, or remove it, as needed.
            this.ürünTableAdapter.Fill(this.petrol_otomasyonDataSet4.ürün);

        }
    }
}
