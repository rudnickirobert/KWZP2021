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
    
    public partial class Rodzaj_narzedzia : Form
    {
        DrukarniaEntities database;
        public Rodzaj_narzedzia(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvRodzaj.DataSource = this.database.vDM_Rodzaj_narzedzia.ToList();
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvRodzaj.DataSource = this.database.vDM_Rodzaj_narzedzia.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DodajRodzajNarzedzia rodzaj = new DodajRodzajNarzedzia(this.database);
            rodzaj.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć materiał?", "Usuwanie materiał", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvRodzaj.CurrentRow.Cells[0].Value);

                DM_Rodzaj_narzedzia toRemove = this.database.DM_Rodzaj_narzedzia.Where(id_narz => id_narz.Id_rodzaj_narzedzia == id).First();

                this.database.DM_Rodzaj_narzedzia.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału?");
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvRodzaj.DataSource = database.vDM_Rodzaj_narzedzia.Where(x => x.Nazwa.Contains(txtFind.Text)).ToList();
        }

        private void dgvRodzaj_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujRodzajNarzedzia rodzaj1 = new EdytujRodzajNarzedzia(this.database);
            rodzaj1.txtRodzaj.Text = dgvRodzaj.CurrentRow.Cells[1].Value.ToString();
            rodzaj1.ShowDialog();
        }
    }
}
