using System;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Material : Form
    {
        DrukarniaEntities database;
        //public DataGridView dgv{ get; set; }
        public DataGridViewRow dataGridView;

        public Material(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvMaterial.DataSource = this.database.vDM_Materialu.ToList();
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvMaterial.DataSource = this.database.vDM_Materialu.ToList();

        }
        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DodajMaterial dodajmaterial = new DodajMaterial(this.database);
            dodajmaterial.ShowDialog();
        }
        private void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            EdytujMaterial edytujmaterial = new EdytujMaterial(this.database);
            edytujmaterial.ShowDialog();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć materiał?", "Usuwanie materiał", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvMaterial.CurrentRow.Cells[0].Value);

                DM_Material toRemove = this.database.DM_Material.Where(id_materialu => id_materialu.Id_materialu == id).First();

                this.database.DM_Material.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału?");
            }
        }

        private void txtFindMaterial_TextChanged(object sender, EventArgs e)
        {
            dgvMaterial.DataSource = database.vDM_Materialu.Where(x => x.Nazwa_materialu.Contains(txtFindMaterial.Text) || x.Rodzaj_materialu.Contains(txtFindMaterial.Text)).ToList();
        }

        private void dgvMaterial_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EdytujMaterial edytujmaterial = new EdytujMaterial(this.database);
            edytujmaterial.txtEdytujMaterial.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
            edytujmaterial.cmbEdytujRodzajMaterialu.Text = dgvMaterial.CurrentRow.Cells[1].Value.ToString();
            // asd = Convert.(this.dgvMaterial.CurrentRow.Cells[0].Value);
            edytujmaterial.ShowDialog();
        }
    }
}
