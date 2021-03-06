using System;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class DodajMaterial : Form
    {
        DrukarniaEntities database;


        public DodajMaterial(DrukarniaEntities database)
        {
            InitializeComponent();

            this.database = database;
            this.cmbRodzajMaterialu.DataSource = this.database.DM_Rodzaj_materialu.ToList();
            this.cmbRodzajMaterialu.DisplayMember = "Rodzaj_materialu";
            this.cmbRodzajMaterialu.ValueMember = "Id_rodzaj_materialu";
        }


        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DM_Material newMaterial = new DM_Material();
            newMaterial.Id_rodzaj_materialu = Convert.ToInt32(cmbRodzajMaterialu.SelectedValue);
            newMaterial.Nazwa = this.txtNewMaterial.Text;

            this.database.DM_Material.Add(newMaterial);
            this.database.SaveChanges();
            this.txtNewMaterial.Text = "";

            var MaterialForm = Application.OpenForms.OfType<Material>().Single();
            MaterialForm.initDataGridView();
            this.Close();
        }
    }
}


