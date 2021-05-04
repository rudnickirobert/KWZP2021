using System;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Dzial_produkcji : Form
    {
        DrukarniaEntities database;
        public Dzial_produkcji(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Dzial_produkcji_Load(object sender, EventArgs e)
        {

        }

        private void btnRodzajCzynnosci_Click(object sender, EventArgs e)
        {
            ProcesTechnologiczny proces_techno = new ProcesTechnologiczny(this.database);
            proces_techno.ShowDialog();
        }

        private void btnMaszyna_Click(object sender, EventArgs e)
        {
            Maszyna_glowny maszyna = new Maszyna_glowny(this.database);
            maszyna.ShowDialog();
        }
    }
}
