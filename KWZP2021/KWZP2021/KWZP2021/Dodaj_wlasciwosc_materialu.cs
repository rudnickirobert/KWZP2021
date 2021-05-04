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
    public partial class Dodaj_wlasciwosc_materialu : Form
    {
        DrukarniaEntities database;
        public Dodaj_wlasciwosc_materialu(DrukarniaEntities database)
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

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewWlasciwoscMaterialu_Click(object sender, EventArgs e)
        {
             DM_Wlasciwosc_materialu newWlasciwoscMaterialu = new DM_Wlasciwosc_materialu();
             newWlasciwoscMaterialu.Id_materialu = Convert.ToInt32(cmbMaterial.SelectedValue);
             newWlasciwoscMaterialu.Id_wlasciwosc = Convert.ToInt32(cmbWlasciwosc.SelectedValue);
             newWlasciwoscMaterialu.Wartosc = this.txtValue.Text;

            /*  DM_Material newWlasciwoscMaterialu = new DM_Material();
              newWlasciwoscMaterialu.Id_materialu = Convert.ToInt32(cmbMaterial.SelectedValue);

              DM_Wlasciwosc newWlasciwoscMaterialu1 = new DM_Wlasciwosc();
              newWlasciwoscMaterialu1.Id_wlasciwosc = Convert.ToInt32(cmbWlasciwosc.SelectedValue);

              this.database.DM_Material.Add(newWlasciwoscMaterialu);
              this.database.DM_Wlasciwosc.Add(newWlasciwoscMaterialu1);*/

            this.database.DM_Wlasciwosc_materialu.Add(newWlasciwoscMaterialu);
            this.database.SaveChanges();
            this.txtValue.Text = "";

            var WlasciwoscMaterialuForm = Application.OpenForms.OfType<Wlasciwosc_materialu>().Single();
            WlasciwoscMaterialuForm.initDataGridView();
            this.Close();
        }
    }
}
