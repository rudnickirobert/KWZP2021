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
    public partial class Dostawcy : Form
    {
        DrukarniaEntities database;
        public Dostawcy(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.database = database;
            this.dgvDostawca.DataSource = this.database.vDM_Dostawca.ToList();
        }

        public void initDataGridView()
        {
            this.dgvDostawca.DataSource = this.database.vDM_Dostawca.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvDostawca.DataSource = database.vDM_Dostawca.Where(x => x.Nazwa.Contains(textBox1.Text)).ToList();
        }

        private void buttonUsunKlienta_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć dostawcę?", "Usuwanie dostawcy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvDostawca.CurrentRow.Cells[0].Value);

                DM_Dostawca toRemove = this.database.DM_Dostawca.Where(dostawca => dostawca.Id_dostawcy == id).First();

                this.database.DM_Dostawca.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć narzędzia!");
            }
        }

        private void buttonNowyKlient_Click(object sender, EventArgs e)
        {
            NowyDostawca nowy = new NowyDostawca(this.database);
            nowy.ShowDialog();

        }

        private void dgvDostawca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujDostawce edycjadostawcy = new EdytujDostawce(this.database);

            edycjadostawcy.txtNew.Text = dgvDostawca.CurrentRow.Cells[1].Value.ToString();
            edycjadostawcy.txtNIP.Text = dgvDostawca.CurrentRow.Cells[2].Value.ToString();
            edycjadostawcy.txtUwagi.Text = dgvDostawca.CurrentRow.Cells[3].Value.ToString();
            edycjadostawcy.ShowDialog();
        }
    }
}
