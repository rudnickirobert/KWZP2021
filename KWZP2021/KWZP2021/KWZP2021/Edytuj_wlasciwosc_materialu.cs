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
    public partial class Edytuj_wlasciwosc_materialu : Form
    {
        DrukarniaEntities database;
        public Edytuj_wlasciwosc_materialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.cmbMaterial.DataSource = this.database.DM_Material.ToList();
            this.cmbMaterial.DisplayMember = "Nazwa";
            this.cmbMaterial.ValueMember = "Id_materialu";

            this.cmbWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.cmbWlasciwosc.DisplayMember = "Nazwa_wlasciwosci";
            this.cmbWlasciwosc.ValueMember = "Id_wlasciwosc";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Wlasciwosc_materialu frm = (Wlasciwosc_materialu)Application.OpenForms["Wlasciwosc_materialu"];
            int row = Convert.ToInt32(frm.dgvWlasciwoscMaterialu.CurrentRow.Cells[0].Value); ;
            DM_Wlasciwosc_materialu toUpdate = this.database.DM_Wlasciwosc_materialu.Where(id_materialu => id_materialu.id_wlasciwosc_materialu == row).First();
            toUpdate.Id_materialu = Convert.ToInt32(cmbMaterial.SelectedValue);
            toUpdate.Id_wlasciwosc = Convert.ToInt32(cmbWlasciwosc.SelectedValue);
            toUpdate.Wartosc = txtValue.Text;
            this.database.SaveChanges();

            var WlasciwoscMaterialuForm = Application.OpenForms.OfType<Wlasciwosc_materialu>().Single();
            WlasciwoscMaterialuForm.initDataGridView();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
