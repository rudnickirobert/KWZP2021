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
    public partial class Rodzaj_materialu : Form
    {
        DrukarniaEntities database;
        public Rodzaj_materialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;


            initCombobox();
            initDataGridView();
        }

        private void initCombobox()
        {
            this.cmbRodzajMaterialu.DataSource = this.database.DM_Rodzaj_materialu.ToList();
            this.cmbRodzajMaterialu.DisplayMember = "rodzaj_materialu";
            this.cmbRodzajMaterialu.ValueMember = "Id_rodzaj_materialu";
        }

        private void initDataGridView()
        {
            this.dgvRodzajMaterialu.DataSource = this.database.DM_Rodzaj_materialu.ToList();

        }

        private void btnAddRodzajMaterialu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć rodzaj materiału?", "Usuwanie rodzaju materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DM_Rodzaj_materialu newRodzajMaterialu = new DM_Rodzaj_materialu();
                newRodzajMaterialu.Rodzaj_materialu = this.txtNewRodzajMaterialu.Text;

                this.database.DM_Rodzaj_materialu.Add(newRodzajMaterialu);
                this.database.SaveChanges();
                initCombobox();
                this.txtNewRodzajMaterialu.Text = "";
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udalo sie dodać materiału?");
            }
        }

        private void btnDeleteRodzajMaterialu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć rodzaj materiału?", "Usuwanie rodzaju materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvRodzajMaterialu.CurrentRow.Cells[0].Value);

                DM_Rodzaj_materialu toRemove = this.database.DM_Rodzaj_materialu.Where(rodzaj_materialu => rodzaj_materialu.Id_rodzaj_materialu == id).First();

                this.database.DM_Rodzaj_materialu.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
                initCombobox();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału?");
            }
        }
        private void dgvRodzajMaterialu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zaktualizować rodzaj materiału?", "Aktualizacja rodzaju materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvRodzajMaterialu.CurrentRow.Cells[0].Value);

                DM_Rodzaj_materialu toRemove = this.database.DM_Rodzaj_materialu.Where(Rodzaj_materialu => Rodzaj_materialu.Id_rodzaj_materialu == id).First();

                toRemove.Rodzaj_materialu = txtAktualizuj.Text; // UPDATE

                this.database.SaveChanges();
                initDataGridView();
                initCombobox();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Czy chcesz zaktualizować rodzaj materiału?");
            }
        }
    }
}
