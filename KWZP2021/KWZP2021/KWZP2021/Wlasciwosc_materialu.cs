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
    public partial class Wlasciwosc_materialu : Form
    {
        DrukarniaEntities database;
        public Wlasciwosc_materialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvWlasciwoscMaterialu.DataSource = this.database.vDM_Wlasciwosc_materialu.ToList();
            dgvWlasciwoscMaterialu.Columns[0].Visible = false;
            dgvWlasciwoscMaterialu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvWlasciwoscMaterialu.DataSource = this.database.vDM_Wlasciwosc_materialu.ToList();

        }

        private void btnAddNewWlasciwoscMaterialu_Click(object sender, EventArgs e)
        {
            Dodaj_wlasciwosc_materialu dodajWlasciwoscMaterialu = new Dodaj_wlasciwosc_materialu(this.database);
            dodajWlasciwoscMaterialu.ShowDialog();
        }

        private void btnUpdateWlasciwoscMaterialu_Click(object sender, EventArgs e)
        {
            Edytuj_wlasciwosc_materialu edytujWlasciwoscMaterialu = new Edytuj_wlasciwosc_materialu(this.database);

            edytujWlasciwoscMaterialu.cmbMaterial.Text = dgvWlasciwoscMaterialu.CurrentRow.Cells[1].Value.ToString();
            edytujWlasciwoscMaterialu.cmbWlasciwosc.Text = dgvWlasciwoscMaterialu.CurrentRow.Cells[2].Value.ToString();
            edytujWlasciwoscMaterialu.txtValue.Text = dgvWlasciwoscMaterialu.CurrentRow.Cells[3].Value.ToString();
            edytujWlasciwoscMaterialu.ShowDialog();
        }

        private void btnDeleteWlasciwoscMaterialu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć właściwość materiału?", "Usuwanie właściwości materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWlasciwoscMaterialu.CurrentRow.Cells[0].Value);
                DM_Wlasciwosc_materialu toRemove = this.database.DM_Wlasciwosc_materialu.Where(id_materialu => id_materialu.id_wlasciwosc_materialu == id).First();

                this.database.DM_Wlasciwosc_materialu.Remove(toRemove); // DELETE
                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć właściwości materiału?");
            }
        }

        private void txtFindWlasciwosc_TextChanged(object sender, EventArgs e)
        {
            dgvWlasciwoscMaterialu.DataSource = database.vDM_Wlasciwosc_materialu.Where(x => x.Nazwa_materialu.Contains(txtFindWlasciwosc.Text) || x.Nazwa_wlasciwosci.Contains(txtFindWlasciwosc.Text)).ToList();
        }

        private void dgvWlasciwoscMaterialu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edytuj_wlasciwosc_materialu edytujWlasciwoscMaterialu = new Edytuj_wlasciwosc_materialu(this.database);
            edytujWlasciwoscMaterialu.cmbMaterial.Text = dgvWlasciwoscMaterialu.CurrentRow.Cells[1].Value.ToString();
            edytujWlasciwoscMaterialu.cmbWlasciwosc.Text = dgvWlasciwoscMaterialu.CurrentRow.Cells[2].Value.ToString();
            edytujWlasciwoscMaterialu.txtValue.Text = dgvWlasciwoscMaterialu.CurrentRow.Cells[3].Value.ToString();
            edytujWlasciwoscMaterialu.ShowDialog();
        }

        private void txtFindWlasciwosc_Enter_1(object sender, EventArgs e)
        {
            if (txtFindWlasciwosc.Text == "Wyszukaj...")
            {
                txtFindWlasciwosc.Text = "";
                initDataGridView();
            }
        }

        private void txtFindWlasciwosc_Leave_1(object sender, EventArgs e)
        {
            if (txtFindWlasciwosc.Text.Length == 0)
            {
                txtFindWlasciwosc.ForeColor = Color.Gray;
                txtFindWlasciwosc.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                txtFindWlasciwosc.Text = "Wyszukaj...";
                initDataGridView();
            }
        }

    }
    
}
