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
            this.database = database;
            this.cmbEdytujRodzajMaterialu.DataSource = database.DM_Rodzaj_materialu.ToList();
            this.cmbEdytujRodzajMaterialu.DisplayMember = "Rodzaj_materialu";
            this.cmbEdytujRodzajMaterialu.ValueMember = "Id_rodzaj_materialu";

        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Material frm = (Material)Application.OpenForms["Material"];
            int row = (frm.dgvMaterial.CurrentRow.Index)+1;
            DM_Material toUpdate = this.database.DM_Material.Where(id_materialu => id_materialu.Id_materialu == row).First();

            toUpdate.Id_rodzaj_materialu = Convert.ToInt32(cmbEdytujRodzajMaterialu.SelectedValue); // UPDATE
            toUpdate.Nazwa = txtEdytujMaterial.Text; // UPDATE

            frm.dgvMaterial.DataSource = this.database.vDM_Material.ToList();
            this.database.SaveChanges();

           // var MaterialForm = Application.OpenForms.OfType<Material>().Single();
           // MaterialForm.initDataGridView();

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

    }
}
