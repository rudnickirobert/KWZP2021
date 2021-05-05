using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Dostawa_glowny : Form
    {
        DrukarniaEntities database;
        public Dostawa_glowny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnWydanieProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Wydanie_produktu wydanieProduktu = new Wydanie_produktu(this.database);
            wydanieProduktu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dostawcy wydanieProduktu = new Dostawcy(this.database);
            wydanieProduktu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DostawaMaterialu nowa = new DostawaMaterialu(this.database);
            nowa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dostawa_czesci dostawaCzesci = new Dostawa_czesci(this.database);
            dostawaCzesci.ShowDialog();
        }
    }
}
