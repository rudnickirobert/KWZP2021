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
            this.Hide();
            this.Close();
            Rodzaj_materialu Rodzaj_materialu = new Rodzaj_materialu(this.database);
            Rodzaj_materialu.ShowDialog();
        }

        private void btnWlasciwosc_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Wlasciwosc Wlasciwosc = new Wlasciwosc(this.database);
            Wlasciwosc.ShowDialog();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Material Wlasciwosc = new Material(this.database);
            Wlasciwosc.ShowDialog();
        }

        private void btnNarzedzie_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Narzedzie narzedzie = new Narzedzie(this.database);
            narzedzie.ShowDialog();
        }

        private void btnCzesc_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Czesc czesc = new Czesc(this.database);
            czesc.ShowDialog();
        }
    }
}
