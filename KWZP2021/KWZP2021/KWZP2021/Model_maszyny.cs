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
    public partial class Model_maszyny : Form
    {
        DrukarniaEntities database;
        public Model_maszyny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvModelMaszyny.DataSource = this.database.vDP_Model_maszyny.ToList();
            initDataGridView();
        }

        public void initDataGridView()
        {
            this.dgvModelMaszyny.DataSource = this.database.vDP_Model_maszyny.ToList();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvModelMaszyny.DataSource = database.vDP_Model_maszyny.Where(x => x.Nazwa_maszyny.Contains(txtFind.Text)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DodajModelMaszyny model = new DodajModelMaszyny(this.database);
            model.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć model maszyny?", "Usuwanie modelu maszyny", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvModelMaszyny.CurrentRow.Cells[0].Value);

                DP_Model_maszyny toRemove = this.database.DP_Model_maszyny.Where(id_masz => id_masz.Id_model_maszyny == id).First();

                this.database.DP_Model_maszyny.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć modelu maszyny.");
            }
        }

        private void dgvModelMaszyny_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujModelMaszyny rodzaj1 = new EdytujModelMaszyny(this.database);
            rodzaj1.txtModel.Text = dgvModelMaszyny.CurrentRow.Cells[1].Value.ToString();
            rodzaj1.ShowDialog();
        }
    }
}
