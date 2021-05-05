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
    public partial class NoweSzczegolyZatrudnienia : Form
    {
        DrukarniaEntities database;
        public NoweSzczegolyZatrudnienia(DrukarniaEntities database)
        {

            InitializeComponent();
            this.database = database;
        }

        private void cmbPracownik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbRodzaj_umowy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapiszNowegoKlienta_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
