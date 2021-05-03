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
    public partial class Zatrudnienie : Form
    {
        DrukarniaEntities database;
        public Zatrudnienie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initDataGridView();
        }

        private void Zatrudnienie_Load(object sender, EventArgs e)
        {

        }
        private void initDataGridView()
        {
            this.dgvZatrudnienie.DataSource = this.database.vDZ_Zatrudnienie.ToList();

        }
        private void dgvZatrudnienie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            initDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nowe_zatrudnienie nowe_zatrudnienie = new Nowe_zatrudnienie(this.database);
            nowe_zatrudnienie.ShowDialog();
        }

        private void dgvZatrudnienie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Konkretne_zatrudnienie konkretne_zatrudnienie = new Konkretne_zatrudnienie(this.database);
            konkretne_zatrudnienie.cmbPracownik1.Text = dgvZatrudnienie.CurrentRow.Cells[1].Value.ToString();
            konkretne_zatrudnienie.cmbStanowisko1.Text = dgvZatrudnienie.CurrentRow.Cells[2].Value.ToString();
            konkretne_zatrudnienie.cmbDzial1.Text = dgvZatrudnienie.CurrentRow.Cells[3].Value.ToString();
            konkretne_zatrudnienie.cmbEtat1.Text = dgvZatrudnienie.CurrentRow.Cells[4].Value.ToString();
            konkretne_zatrudnienie.cmbRodzaj_umowy1.Text = dgvZatrudnienie.CurrentRow.Cells[5].Value.ToString();
            konkretne_zatrudnienie.dataZatrudnienia1.Value = Convert.ToDateTime(dgvZatrudnienie.CurrentRow.Cells[6].Value);
            konkretne_zatrudnienie.dataZwolnienia1.Value = Convert.ToDateTime(dgvZatrudnienie.CurrentRow.Cells[7].Value);
     
            //database.DZ_Klient.Add(konkretny_klient);
            //database.SaveChanges();
            //this.Close();
            konkretne_zatrudnienie.ShowDialog();
            initDataGridView();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Szczegoly_zatrudnienia szczegoly_zatrudnienia = new Szczegoly_zatrudnienia(this.database);
            szczegoly_zatrudnienia.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć pozycję?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvZatrudnienie.CurrentRow.Cells[0].Value);

                DZ_Zatrudnienie toRemove = this.database.DZ_Zatrudnienie.Where(zatrudnienie => zatrudnienie.Id_zatrudnienia == id).First();


                this.database.DZ_Zatrudnienie.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
        }
    }
}