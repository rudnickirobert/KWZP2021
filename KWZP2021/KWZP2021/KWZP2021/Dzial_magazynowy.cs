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
        private void btnPrzejdzmaterial_Click(object sender, EventArgs e)
        {
            Material_glowny mat = new Material_glowny(this.database);
            mat.ShowDialog();
        }

        private void btnPrzejdzczesc_Click(object sender, EventArgs e)
        {
            Czesc_glowna czes = new Czesc_glowna(this.database);
            czes.ShowDialog();
        }

        private void btnPrzejdzdostawa_Click(object sender, EventArgs e)
        {
            Dostawa_glowny dost = new Dostawa_glowny(this.database);
            dost.ShowDialog();
        }

        private void btnPrzejdznarzedzie_Click(object sender, EventArgs e)
        {
            Narzedzie_glowny narz = new Narzedzie_glowny(this.database);
            narz.ShowDialog();
        }
    }
}
