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
    
    public partial class Material_glowny : Form
    {
        DrukarniaEntities database;

        public Material_glowny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Material Wlasciwosc = new Material(this.database);
            Wlasciwosc.ShowDialog();
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

        private void btnWlasciwoscMaterialu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Wlasciwosc_materialu wlasciwoscMaterialu = new Wlasciwosc_materialu(this.database);
            wlasciwoscMaterialu.ShowDialog();
        }

    }
}
