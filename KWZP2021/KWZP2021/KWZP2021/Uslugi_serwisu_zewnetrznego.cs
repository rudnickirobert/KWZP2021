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
    public partial class Uslugi_serwisu_zewnetrznego : Form

    {
        DrukarniaEntities database;
        public Uslugi_serwisu_zewnetrznego(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvUslugiSerwZew.DataSource = this.database.vDP_Usluga_serwisu_zewnetrznego.ToList();
            initDataGridView();

        }

        public void initDataGridView()
        {
            this.dgvUslugiSerwZew.DataSource = this.database.vDP_Usluga_serwisu_zewnetrznego.ToList();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvUslugiSerwZew.DataSource = database.vDP_Usluga_serwisu_zewnetrznego.Where(x => x.Nazwa_obslugi.Contains(txtFind.Text)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dodaj_usluge_serwisu_zewnetrznego uslugaserwisu = new Dodaj_usluge_serwisu_zewnetrznego(this.database);
            uslugaserwisu.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć nazwę usługi serwisu zewnętrzego?", "Usuwanie nazwy usługi serwisu zewnętrznego", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvUslugiSerwZew.CurrentRow.Cells[0].Value);

                DP_Usluga_serwisu_zewnetrznego toRemove = this.database.DP_Usluga_serwisu_zewnetrznego.Where(id_usluga => id_usluga.Id_usluga_serwisu_zewnetrznego == id).First();

                this.database.DP_Usluga_serwisu_zewnetrznego.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć nazwy usługi serwisu zewnętrznego.");
            }
        }

        private void dgvUslugiSerwZew_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edytuj_usluge_serwisu_zewnetrznego uslugaserwzew = new Edytuj_usluge_serwisu_zewnetrznego(this.database);
            uslugaserwzew.txtNazwaUslugiSerwZew.Text = dgvUslugiSerwZew.CurrentRow.Cells[1].Value.ToString();
            uslugaserwzew.ShowDialog();
        }
    }
}
