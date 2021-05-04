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
    public partial class Rodzaj_maszyny : Form
    {
        DrukarniaEntities database;
        public Rodzaj_maszyny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvRodzajMaszyny.DataSource = this.database.vDP_Rodzaj_maszyny.ToList();
            initDataGridView();
        }

        public void initDataGridView()
        {
           
            this.dgvRodzajMaszyny.DataSource = this.database.vDP_Rodzaj_maszyny.ToList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć rodzaj maszyny?", "Usuwanie rodzaju maszyny", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvRodzajMaszyny.CurrentRow.Cells[0].Value);

                DP_Rodzaj_maszyny toRemove = this.database.DP_Rodzaj_maszyny.Where(id_masz => id_masz.Id_rodzaj_maszyny == id).First();

                this.database.DP_Rodzaj_maszyny.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć rodzaju maszyny.");
            }

        }

  

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DodajRodzajMaszyny rodzaj = new DodajRodzajMaszyny(this.database);
            rodzaj.ShowDialog();
        }

        private void dgvRodzaj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujRodzajMaszyny rodzaj1 = new EdytujRodzajMaszyny(this.database);
            rodzaj1.txtRodzaj.Text = dgvRodzajMaszyny.CurrentRow.Cells[1].Value.ToString();
            rodzaj1.ShowDialog();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvRodzajMaszyny.DataSource = database.vDP_Rodzaj_maszyny.Where(x => x.Rodzaj.Contains(txtFind.Text)).ToList();

        }
    }
}
