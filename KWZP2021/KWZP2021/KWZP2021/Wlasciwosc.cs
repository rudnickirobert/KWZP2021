using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Wlasciwosc : Form
    {
        DrukarniaEntities database;
        public Wlasciwosc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.cmbWlasciwosc.DisplayMember = "Nazwa_wlasciwosci";
            this.cmbWlasciwosc.ValueMember = "Id_wlasciwosc";

            this.dgvWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();
            InitCombobox();
            initDataGridView();
        }
        private void InitCombobox()
        {
            this.cmbWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();
            this.cmbWlasciwosc.DisplayMember = "Nazwa";
        }

        private void initDataGridView()
        {
            this.dgvWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();

        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {

            DM_Wlasciwosc newWlasciwosc = new DM_Wlasciwosc();
            newWlasciwosc.Nazwa_wlasciwosci = this.textBox3.Text;
            newWlasciwosc.Jednostka_pomiarowa = this.textBox2.Text;
            this.database.DM_Wlasciwosc.Add(newWlasciwosc);
            this.database.SaveChanges();

            initDataGridView();
            InitCombobox();
        }

        private void btnDeleteRodzajMaterialu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć rodzaj materiału?", "Usuwanie rodzaju materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWlasciwosc.CurrentRow.Cells[0].Value);

                DM_Wlasciwosc toRemove = this.database.DM_Wlasciwosc.Where(Wlasciwosc => Wlasciwosc.Id_wlasciwosc == id).First();

                this.database.DM_Wlasciwosc.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
                InitCombobox();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału?");
            }
        }

        private void dgvWlasciwosc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zaktualizować rodzaj materiału?", "Aktualizacja rodzaju materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWlasciwosc.CurrentRow.Cells[0].Value);

                DM_Wlasciwosc toRemove = this.database.DM_Wlasciwosc.Where(Wlasciwosc => Wlasciwosc.Id_wlasciwosc == id).First();

                toRemove.Nazwa_wlasciwosci = txtAktualizuj.Text; // UPDATE
                toRemove.Jednostka_pomiarowa = textBox1.Text;

                this.database.SaveChanges();
                initDataGridView();
                InitCombobox();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Czy chcesz zaktualizować rodzaj materiału?");
            }
        }
    }
}

