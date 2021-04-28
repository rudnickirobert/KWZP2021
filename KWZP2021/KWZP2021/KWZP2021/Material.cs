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
    public partial class Material : Form
    {
        DrukarniaEntities database;
        public Material(DrukarniaEntities database)
        {
            InitializeComponent();
            InitializeComponent();
            this.database = database;
            this.dgvMaterial.DataSource = this.database.DM_Material.ToList();
        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DodajMaterial dodajmaterial = new DodajMaterial(this.database);
            dodajmaterial.ShowDialog();
        }
    }
}
