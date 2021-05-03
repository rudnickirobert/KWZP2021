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
    public partial class WlasciwoscNarzedzia : Form
    {
        DrukarniaEntities database;

        public WlasciwoscNarzedzia(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvWlasciwosc.DataSource = this.database.vDM_Parametr_narzedzia.ToList();
            dgvWlasciwosc.Columns[0].Visible = false;
            initDataGridView();

            
        }
        public void initDataGridView()
        {
            this.dgvWlasciwosc.DataSource = this.database.vDM_Parametr_narzedzia.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DodajWlasciwoscNarzedzia rodzaj = new DodajWlasciwoscNarzedzia(this.database);
            rodzaj.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć materiał?", "Usuwanie materiał", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWlasciwosc.CurrentRow.Cells[0].Value);

                DM_Parametr_narzedzia toRemove = this.database.DM_Parametr_narzedzia.Where(id_narz => id_narz.Id_parametru == id).First();

                this.database.DM_Parametr_narzedzia.Remove(toRemove); // DELETE

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
            dgvWlasciwosc.DataSource = database.vDM_Parametr_narzedzia.Where(x => x.Nazwa_narzedzia.Contains(txtFind.Text)).ToList();
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvWlasciwosc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujWlasciwoscNarzedzia rodzaj1 = new EdytujWlasciwoscNarzedzia(this.database);
            rodzaj1.ShowDialog();
        }
    }
}
