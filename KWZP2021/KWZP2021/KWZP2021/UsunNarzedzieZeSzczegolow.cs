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
    public partial class UsunNarzedzieZeSzczegolow : Form
    {
        DrukarniaEntities database;
        public UsunNarzedzieZeSzczegolow(DrukarniaEntities database,int id)
        {
            this.database = database;
            InitializeComponent();
            DM_Szczegoly_wypozyczenia_narzedzia szczegoly = database.DM_Szczegoly_wypozyczenia_narzedzia.Where(wybrane => wybrane.Id_wypozyczenia_narzedzia == id).First();
            dgvSzczeg.DataSource = database.vDM_Szczegoly_wypozyczenia_narzedzia.Where(szcz => szcz.Identyfikator_wypozyczenia == szczegoly.Id_wypozyczenia_narzedzia).ToList();
            dgvSzczeg.Columns[0].Visible = false;
            dgvSzczeg.Columns[1].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć narzedzie?", "Usuwanie narzedzia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvSzczeg.CurrentRow.Cells[0].Value);

                DM_Szczegoly_wypozyczenia_narzedzia toRemove = database.DM_Szczegoly_wypozyczenia_narzedzia.Where(id_narz => id_narz.Id_wypozyczenia_narzedzia == id).First();

                this.database.DM_Szczegoly_wypozyczenia_narzedzia.Remove(toRemove); // DELETE

                this.database.SaveChanges();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć narzędzia");
            }
        }
    }
}
