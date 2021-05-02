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
    public partial class Narzedzie : Form
    {
        DrukarniaEntities database;
        public DataGridView dataGridView;
        public Narzedzie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvNarzedzie.DataSource = this.database.vDM_Narzedzie.ToList();
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvNarzedzie.DataSource = this.database.vDM_Narzedzie.ToList();
        }

        private void btnNarzedziePowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_magazynowy Dzial_magazynowy = new Dzial_magazynowy(this.database);
            Dzial_magazynowy.ShowDialog();
        }
         private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvNarzedzie.DataSource = database.vDM_Narzedzie.Where(x => x.Nazwa.Contains(textBox1.Text) || x.Rodzaj_narzedzia.Contains(textBox1.Text)).ToList();
        }

        private void btnAddnarzedzie_Click(object sender, EventArgs e)
        {
            Nowe_narzedzie nowenarzedzie = new Nowe_narzedzie(this.database);
            nowenarzedzie.ShowDialog();
        }

        private void btnDeletenarzedzie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć materiał?", "Usuwanie materiał", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvNarzedzie.CurrentRow.Cells[0].Value);

                DM_Narzedzie toRemove = this.database.DM_Narzedzie.Where(id_narzedzia => id_narzedzia.Id_narzedzia == id).First();

                this.database.DM_Narzedzie.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału?");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initDataGridView();
        }

        private void dgvNarzedzie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujNarzedzie edytujnarzedzie = new EdytujNarzedzie(this.database);
            edytujnarzedzie.textBox2.Text = dgvNarzedzie.CurrentRow.Cells[1].Value.ToString();
            edytujnarzedzie.comboBox1.Text = dgvNarzedzie.CurrentRow.Cells[2].Value.ToString();
            edytujnarzedzie.textBox1.Text = dgvNarzedzie.CurrentRow.Cells[3].Value.ToString();
            edytujnarzedzie.ShowDialog();
            initDataGridView();
        }
    }
}
