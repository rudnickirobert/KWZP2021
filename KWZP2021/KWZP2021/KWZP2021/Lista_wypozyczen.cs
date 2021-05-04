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
    public partial class Lista_wypozyczen : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow DataGridView;
        public Lista_wypozyczen(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initDataGridView();
        }
        public void initDataGridView()
        {
            dgvWypozyczenia.DataSource = this.database.vDM_Wydanie_czesci.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // dgvWypozyczenia.DataSource = database.vDM_Wydanie_czesci.Where(x => x.Id_pracownika_pobierajacego.Contains(textBox1.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Wydaj_czesc wydajczesc = new Wydaj_czesc(this.database);
            wydajczesc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć wypożyczenie?", "Usuwanie wypożyczenia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWypozyczenia.CurrentRow.Cells[0].Value);

                DM_Wydanie_czesci toRemove = this.database.DM_Wydanie_czesci.Where(czesc => czesc.Id_wydania_czesci == id).First();


                this.database.DM_Wydanie_czesci.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć wypozyczenia?");
            }
        }
    }
}
