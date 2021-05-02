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
    public partial class Oplaty_firmy : Form
    {
        DrukarniaEntities database;
        public Oplaty_firmy(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oplaty_stale oplaty_stale = new Oplaty_stale(this.database);
            oplaty_stale.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koszty_zewnetrzne koszty_zewnetrzne = new Koszty_zewnetrzne(this.database);
            koszty_zewnetrzne.ShowDialog();

        }
    }
}
