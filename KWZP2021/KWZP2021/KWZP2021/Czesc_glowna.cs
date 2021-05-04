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
    public partial class Czesc_glowna : Form
    {
        DrukarniaEntities database;
        public Czesc_glowna(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnCzesc_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Czesc czesc = new Czesc(this.database);
            czesc.ShowDialog();
        }

        private void btnCzescGlownaPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_magazynowy Dzial_magazynowy = new Dzial_magazynowy(this.database);
            Dzial_magazynowy.ShowDialog();
        }

        private void btnCzescGlownaDodajParametr_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Parametr_czesci parametrczesc = new Parametr_czesci(this.database);
            parametrczesc.ShowDialog();
        }

        private void btnCzescGlownaWydanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Wydaj_czesc wydajczesc = new Wydaj_czesc(this.database);
            wydajczesc.ShowDialog();
        }
    }
}
