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
    public partial class Czesc : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow dataGridView;
        public Czesc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvCzesc.DataSource = this.database.vDM_Czesc.ToList();
            initDataGridView();
        }
        

        private void initDataGridView()
        {
            this.dgvCzesc.DataSource = this.database.vDM_Czesc.ToList();
        }

        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            DodajCzesc dodajczesc = new DodajCzesc(this.database);
            dodajczesc.ShowDialog();
        }

        private void btnCzescPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Czesc_glowna Dzial_magazynowy = new Czesc_glowna(this.database);
            Dzial_magazynowy.ShowDialog();
        }

        private void txtWyszukajCzesc_TextChanged(object sender, EventArgs e)
        {
            dgvCzesc.DataSource = database.vDM_Czesc.Where(x => x.Nazwa.Contains(txtWyszukajCzesc.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć część?", "Usuwanie części", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvCzesc.CurrentRow.Cells[0].Value);

                DM_Czesc toRemove = this.database.DM_Czesc.Where(czesc => czesc.Id_czesci == id).First();


                this.database.DM_Czesc.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć części?");
            }
        }
    }
}
