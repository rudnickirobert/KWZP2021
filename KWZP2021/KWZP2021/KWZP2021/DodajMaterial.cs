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

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DM_Material newMaterial = new DM_Material();
            newMaterial.Nazwa = this.txtNewMaterial.Text;

            this.database.DM_Material.Add(newMaterial);
            this.database.SaveChanges();
            //initCombobox();
            this.txtNewMaterial.Text = "";
            // initDataGridView();
        }

        private void cmbRodzajMaterialu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.cmbRodzajMaterialu.SelectedItem.ToString());

            this.cmbRodzajMaterialu.DataSource = database.DM_Rodzaj_materialu.Where(Rodzaj_materialu => Rodzaj_materialu.DM_Material. == (int)this.cmbRodzajMaterialu.SelectedValue);
            this.cmbRodzajMaterialu.DataSource = database.DM_Rodzaj_materialu.Where(Rodzaj_materialu => Rodzaj_materialu.DM_Material.

        }
    }
    }
    

