using System;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Dzial_magazynowy : Form
    {
        DrukarniaEntities database;
        public Dzial_magazynowy(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Dzial_magazynowy_Load(object sender, EventArgs e)
        {

        }

        private void btnRodzajMaterial_Click(object sender, EventArgs e)
        {
            Rodzaj_materialu Rodzaj_materialu = new Rodzaj_materialu(this.database);
            Rodzaj_materialu.ShowDialog();
        }

        private void btnWlasciwosc_Click(object sender, EventArgs e)
        {
            Wlasciwosc Wlasciwosc = new Wlasciwosc(this.database);
            Wlasciwosc.ShowDialog();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Material Wlasciwosc = new Material(this.database);
            Wlasciwosc.ShowDialog();
        }
    }
}
