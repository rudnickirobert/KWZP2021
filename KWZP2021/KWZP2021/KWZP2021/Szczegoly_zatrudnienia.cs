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
    public partial class Szczegoly_zatrudnienia : Form
    {
        DrukarniaEntities database;
        public Szczegoly_zatrudnienia(DrukarniaEntities database)
        {

            InitializeComponent();
            this.database = database;
            this.dataSzczegoly.DataSource = this.database.vDZ_Szczegoly_zatrudnienia.ToList();
        }

        private void Szczegoly_zatrudnienia_Load(object sender, EventArgs e)
        {

        }

        private void dataSzczegoly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataSzczegoly.DataSource = this.database.vDZ_Szczegoly_zatrudnienia.ToList();
        }

        private void dataSzczegoly_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSzczegoly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Szcz_zatrudnienia_2 szcz_zatrudnienia_2 = new Szcz_zatrudnienia_2(this.database);
            szcz_zatrudnienia_2.txtPracownik.Text = dataSzczegoly.CurrentRow.Cells[1].Value.ToString();
            szcz_zatrudnienia_2.txtNumerUmowy.Text = dataSzczegoly.CurrentRow.Cells[0].Value.ToString();
            szcz_zatrudnienia_2.txtDataZmiany.Text = dataSzczegoly.CurrentRow.Cells[2].Value.ToString();
            szcz_zatrudnienia_2.txtWynagrodzenie.Text = dataSzczegoly.CurrentRow.Cells[3].Value.ToString();
            szcz_zatrudnienia_2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUsunPracownika_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć pracownika", "Usuwanie pracowników", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dataSzczegoly.CurrentRow.Cells[0].Value);

                DZ_Szczegoly_zatrudnienia toRemove = this.database.DZ_Szczegoly_zatrudnienia.Where(szczegoly => szczegoly.Id_szczegoly_zatrudnienia == id).First();


                this.database.DZ_Szczegoly_zatrudnienia.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                this.dataSzczegoly.DataSource = this.database.vDZ_Szczegoly_zatrudnienia.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataSzczegoly.DataSource = database.vDZ_Szczegoly_zatrudnienia.Where(x => x.Nazwisko_pracownika.Contains(textBox1.Text)).ToList();
        }

        private void buttonNowyPracownik_Click(object sender, EventArgs e)
        {
            NoweSzczegolyZatrudnienia szcz = new NoweSzczegolyZatrudnienia(this.database);
            szcz.ShowDialog();
        }
    }
}
