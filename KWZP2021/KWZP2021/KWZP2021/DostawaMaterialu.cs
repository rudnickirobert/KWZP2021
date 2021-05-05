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
    public partial class DostawaMaterialu : Form
    {
        DrukarniaEntities database;
        public DostawaMaterialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvDostawa.DataSource = this.database.vDM_Dostawa_materialu.ToList();
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvDostawa.DataSource = this.database.vDM_Dostawa_materialu.ToList();

        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvDostawa.DataSource = database.vDM_Dostawa_materialu.Where(x => x.Nazwisko_pracownika.Contains(txtFind.Text)).ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NowaDostawaMaterialu nowa = new NowaDostawaMaterialu(this.database);
            nowa.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć dostawę?", "Usuwanie dostawy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvDostawa.CurrentRow.Cells[0].Value);

                DM_Dostawa_materialu toRemove = this.database.DM_Dostawa_materialu.Where(wypo => wypo.Id_dostawy == id).First();

                this.database.DM_Dostawa_materialu.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć dostawy!");
            }
        }

        private void dgvDostawa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numer = Convert.ToInt32(dgvDostawa.CurrentRow.Cells[0].Value);
            SzczegolyDostawy szczegol = new SzczegolyDostawy(database, Decimal.ToInt32(numer));
            szczegol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoweSzczegolyDostawyMaterialu nowe = new NoweSzczegolyDostawyMaterialu(this.database);
            nowe.ShowDialog();
        }

        private void DostawaMaterialu_Load(object sender, EventArgs e)
        {
            dgvDostawa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDostawa.DataSource = this.database.vDM_Dostawa_materialu.ToList();
        }
    }
}
