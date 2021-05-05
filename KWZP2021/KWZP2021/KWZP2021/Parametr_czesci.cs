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
    public partial class Parametr_czesci : Form
    {
        DrukarniaEntities database;
        public DataGridView DataGridView;
        public Parametr_czesci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvParametrCzesci.DataSource = this.database.vDM_Parametr_czesci.ToList();
            dgvParametrCzesci.Columns[0].Visible = false;
            initDataGridView();

        }
        private void initDataGridView()
        {
            this.dgvParametrCzesci.DataSource = this.database.vDM_Parametr_czesci.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Czesc_glowna czescglowna = new Czesc_glowna(this.database);
            czescglowna.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvParametrCzesci.DataSource = database.vDM_Parametr_czesci.Where(x => x.Nazwa_czesci.Contains(textBox1.Text) || x.Wlasciwosc.Contains(textBox1.Text)).ToList();
        }

        private void btnDodajParametr_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Dodaj_parametr_czesci dodajparametrczesci = new Dodaj_parametr_czesci(this.database);
            dodajparametrczesci.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć parametr?", "Usuwanie parametru", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvParametrCzesci.CurrentRow.Cells[0].Value);

                DM_Parametr_czesci toRemove = this.database.DM_Parametr_czesci.Where(czesc => czesc.Id_parametr_czesci == id).First();


                this.database.DM_Parametr_czesci.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć parametru?");
            }

        }

        private void dgvParametrCzesci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edycja_parametru_czesci edycja_parametru_czesci = new Edycja_parametru_czesci(this.database);
            edycja_parametru_czesci.textBox1.Text = dgvParametrCzesci.CurrentRow.Cells[3].Value.ToString();
            edycja_parametru_czesci.ShowDialog();
            initDataGridView();
        }
    }
}
