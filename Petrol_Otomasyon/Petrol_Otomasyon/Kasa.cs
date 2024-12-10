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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrol_otomasyonDataSet1.Kasa' table. You can move, or remove it, as needed.
            this.kasaTableAdapter.Fill(this.petrol_otomasyonDataSet1.Kasa);

        }
    }
}
