using System;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Material : Form
    {
        DrukarniaEntities database;
        public Material(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvMaterial.DataSource = this.database.vDM_Material.ToList();
            initDataGridView();
        }
        private void initDataGridView()
        {
            this.dgvMaterial.DataSource = this.database.vDM_Material.ToList();

        }
        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DodajMaterial dodajmaterial = new DodajMaterial(this.database);
            dodajmaterial.ShowDialog();
        }
    }
}
