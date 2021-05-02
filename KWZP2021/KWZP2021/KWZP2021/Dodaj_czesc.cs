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
    public partial class DodajCzesc : Form
    {
        DrukarniaEntities database;

        public DodajCzesc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAnulujDodanieCzesci_Click(object sender, EventArgs e)
        {
            Czesc czesc = new Czesc(this.database);
            czesc.ShowDialog();
        }

        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            DM_Czesc newCzesc = new DM_Czesc();
            newCzesc.Nazwa = this.txtDodajCzescNazwa.Text;
            newCzesc.Ilosc_poczatkowa = Convert.ToInt32(txtDodajCzescIlosc.Text);
            /*DM_Material newMaterial = new DM_Material();
            newMaterial.Id_rodzaj_materialu = Convert.ToInt32(cmbRodzajMaterialu.SelectedValue);
            newMaterial.Nazwa = this.txtNewMaterial.Text;*/

            this.database.DM_Czesc.Add(newCzesc);
            this.database.SaveChanges();
            this.txtDodajCzescNazwa.Text = "";
            /*this.database.DM_Material.Add(newMaterial);
            this.database.SaveChanges();
            this.txtNewMaterial.Text = "";*/

            //var Czesc = Application.OpenForms.OfType<Czesc>().Single();
            //Czesc.initDataGridView();
            this.Close();
        }
    }
}
