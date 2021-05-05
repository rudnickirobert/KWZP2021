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
    public partial class SzczegolyWypozyczenia : Form
    {
        DrukarniaEntities database;

        public SzczegolyWypozyczenia(DrukarniaEntities database, int id)
        {
            InitializeComponent();
            {
                
                this.database = database;
                    DM_Szczegoly_wypozyczenia_narzedzia szczegoly = database.DM_Szczegoly_wypozyczenia_narzedzia.Where(wybrane => wybrane.Id_wypozyczenia_narzedzia == id).First();

                   
                dgv.DataSource = database.vDM_Szczegoly_wypozyczenia_narzedzia.Where(szcz => szcz.Identyfikator_wypozyczenia == szczegoly.Id_wypozyczenia_narzedzia).ToList();
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
            }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NoweSzczegolyWypozyczeniaNarzedzia narzedzia = new NoweSzczegolyWypozyczeniaNarzedzia(this.database);
            narzedzia.ShowDialog();
        }
        private void initdata()
        {
            this.dgv.DataSource = this.database.vDM_Szczegoly_wypozyczenia_narzedzia.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć narzedzie?", "Usuwanie narzedzia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SzczegolyWypozyczenia frm = (SzczegolyWypozyczenia)Application.OpenForms["SzczegolyWypozyczenia"];
                int id = Convert.ToInt32(this.dgv.CurrentRow.Cells[0].Value);

                DM_Szczegoly_wypozyczenia_narzedzia toRemove = this.database.DM_Szczegoly_wypozyczenia_narzedzia.Where(id_narz => id_narz.Id_narzedzia == id).First();

                this.database.DM_Szczegoly_wypozyczenia_narzedzia.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                this.Close();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć narzędzia");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoweSzczegolyWypozyczeniaNarzedzia nowe = new NoweSzczegolyWypozyczeniaNarzedzia(this.database);
            nowe.ShowDialog();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

