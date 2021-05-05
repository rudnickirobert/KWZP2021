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
    public partial class SzczegolyDostawy : Form
    {
        DrukarniaEntities database;

        public SzczegolyDostawy(DrukarniaEntities database, int id)
        {
            InitializeComponent();
            this.database = database;
            DM_Sklad_dostawy_materialu szczegoly = database.DM_Sklad_dostawy_materialu.Where(wybrane => wybrane.Id_dostawy_mate == id).First();


            dgv.DataSource = database.vDM_Sklad_dostawy_materialu.Where(szcz => szcz.Identyfikator_dostawy == szczegoly.Id_dostawy_mate).ToList();
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć materiał?", "Usuwanie materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DostawaMaterialu frm = (DostawaMaterialu)Application.OpenForms["DostawaMaterialu"];
                int id = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

                DM_Sklad_dostawy_materialu toRemove = this.database.DM_Sklad_dostawy_materialu.Where(id_narz => id_narz.Id_dostawy_mate == id).First();

                this.database.DM_Sklad_dostawy_materialu.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                this.Close();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału!");
            }
        }
    }
}
