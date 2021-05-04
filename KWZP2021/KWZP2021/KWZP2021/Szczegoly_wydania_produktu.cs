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
    public partial class Szczegoly_wydania_produktu : Form
    {
        DrukarniaEntities database;
        public Szczegoly_wydania_produktu(DrukarniaEntities database, int id)
        {
            InitializeComponent();
            this.database = database;

            DM_Szczegoly_wydania_produktu szczegoly = database.DM_Szczegoly_wydania_produktu.Where(wybrane => wybrane.Id_wydania == id).First();
            dgvSzczegoly.DataSource = database.vDM_Szczegoly_wydania_produktu.Where(szcz => szcz.Identyfikator_wydania == szczegoly.Id_wydania).ToList();
            dgvSzczegoly.Columns[0].Visible = false;
            dgvSzczegoly.Columns[1].Visible = false;
        }
        public void initDataGridView(int id)
        {
            DM_Szczegoly_wydania_produktu szczegoly = database.DM_Szczegoly_wydania_produktu.Where(wybrane => wybrane.Id_wydania == id).First();
            dgvSzczegoly.DataSource = database.vDM_Szczegoly_wydania_produktu.Where(szcz => szcz.Identyfikator_wydania == szczegoly.Id_wydania).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewSzczegoly_Click(object sender, EventArgs e)
        {
            Dodaj_szczegol_wydania_produktu szczegolWydania = new Dodaj_szczegol_wydania_produktu(this.database);
            Wydanie_produktu wydProd = (Wydanie_produktu)Application.OpenForms["Wydanie_produktu"];
            szczegolWydania.txtIdWydania.Text = wydProd.dgvWydanieProduktu.CurrentRow.Cells[1].Value.ToString();
            szczegolWydania.ShowDialog();
        }

        private void dgvSzczegoly_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć szczegół wydania produktu?", "Usuwanie szczegółu wydania produktu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvSzczegoly.CurrentRow.Cells[0].Value);

                DM_Szczegoly_wydania_produktu toRemove = this.database.DM_Szczegoly_wydania_produktu.Where(id_wyd => id_wyd.Id_wydania == id).First();

                this.database.DM_Szczegoly_wydania_produktu.Remove(toRemove); // DELETE

                this.database.SaveChanges();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć szczegółu wydania produktu");
            }
        }
    }
}
