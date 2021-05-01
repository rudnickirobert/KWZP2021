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
    
    public partial class EdytujMaterial : Form
    {
        DrukarniaEntities database;
        public EdytujMaterial(DrukarniaEntities database)
        {
            InitializeComponent();

            this.cmbEdytujRodzajMaterialu.DataSource = database.DM_Rodzaj_materialu.ToList();
            this.cmbEdytujRodzajMaterialu.DisplayMember = "Rodzaj_materialu";
            this.cmbEdytujRodzajMaterialu.ValueMember = "Id_rodzaj_materialu";

        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    /*    private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Material f = new Material(this.database);
            f.dgvMaterial = ;

            int id = Convert.ToInt32(Material.CurrentRow.Cells[0].Value);
            DM_Material toUpdate = this.database.DM_Material.Where(mat => mat.Id_materialu == id).First();
            toUpdate.Nazwa = txtEdytujMaterial.Text; // UPDATE
            toUpdate.Id_rodzaj_materialu = Convert.ToInt32(cmbEdytujRodzajMaterialu.SelectedValue); // UPDATE
            this.database.SaveChanges();

            var MaterialForm = Application.OpenForms.OfType<Material>().Single();
            MaterialForm.initDataGridView();

            this.Close();
        }*/


        /*    private void btnAddNewMaterial_Click(object sender, EventArgs e)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz zaktualizować materiał?", "Aktualizacja materiału", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(this.dgvMaterial.CurrentRow.Cells[0].Value);
                    DM_Material toRemove = this.database.DM_Material.Where(id_materialu => id_materialu.Id_materialu == id).First();
                    toRemove.Nazwa = txtEdytujMaterial.Text; // UPDATE
                    toRemove.Id_rodzaj_materialu = Convert.ToInt32(cmbEdytujRodzajMaterialu.SelectedValue); // UPDATE

                    this.database.SaveChanges();
                    var MaterialForm = Application.OpenForms.OfType<Material>().Single();
                    MaterialForm.initDataGridView();
                }
                else
                {
                    DialogResult dialog1Result = MessageBox.Show("Czy chcesz zaktualizować materiał?");
                }
            }*/
    }
}
