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
    public partial class SzczegolyZamNarzedzi : Form
    {
        DrukarniaEntities database;
        public SzczegolyZamNarzedzi(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_narzedzi.ToList();

            this.comboBox1.DataSource = this.database.DM_Narzedzie.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_narzedzia";

            this.comboBox2.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.comboBox2.DisplayMember = "Jednostka_pomiarowa";
            this.comboBox2.ValueMember = "Id_wlasciwosc";
        }

        private void initdvgs()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_narzedzi.ToList();

        }
        private void SzczegolyZamNarzedzi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ_Szczegoly_zam_narzedzi szczegoly_zamowienia_narzedzi = new DZ_Szczegoly_zam_narzedzi();
            int numer = Convert.ToInt32(this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            szczegoly_zamowienia_narzedzi.Id_zamowienia_zewn = numer;
            szczegoly_zamowienia_narzedzi.Id_narzedzia = Convert.ToInt32(comboBox1.SelectedValue);
            szczegoly_zamowienia_narzedzi.Koszt_jednostkowy_oferta = Convert.ToInt32(textBox2.Text);
            szczegoly_zamowienia_narzedzi.Id_wlasciwosc = Convert.ToInt32(comboBox2.SelectedValue);
            szczegoly_zamowienia_narzedzi.Ilosc = Convert.ToInt32(numericUpDown1.Value);
            database.DZ_Szczegoly_zam_narzedzi.Add(szczegoly_zamowienia_narzedzi);
            database.SaveChanges();
            initdvgs();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numer = Convert.ToInt32(this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.Equals(numer))
                    {
                        row.Selected = true;

                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć wybrane szczegóły zamówienia?", "Uwaga, po zatwierdzeniu rekord zostanie trwale usunięty z bazy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);

                DZ_Szczegoly_zam_narzedzi toRemove = this.database.DZ_Szczegoly_zam_narzedzi.Where(szczegoly_zamowienia => szczegoly_zamowienia.Id_szczegoly_zam_narzedzi == id).First();


                this.database.DZ_Szczegoly_zam_narzedzi.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgs();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numer2 = Convert.ToInt32(this.textBox1.Text);
            dataGridView2.DataSource = database.vDZ_Szczegoly_zam_narzedzi.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
        }
    }
}
