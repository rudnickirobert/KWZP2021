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
    public partial class SzczegolyZamowieniaKlienta : Form
    {
        DrukarniaEntities database;
        public SzczegolyZamowieniaKlienta(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_klienta.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zamowienia_klienta.ToList();

            this.comboBox1.DataSource = this.database.DZ_Plik.ToList();
            this.comboBox1.DisplayMember = "Nazwa_pliku";
            this.comboBox1.ValueMember = "Id_pliku";

            this.comboBox2.DataSource = this.database.DM_Material.ToList();
            this.comboBox2.DisplayMember = "Nazwa";
            this.comboBox2.ValueMember = "Id_materialu";
        }
        private void initdvgs()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_klienta.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zamowienia_klienta.ToList();

        }
        private void SzczegolyZamowieniaKlienta_Load(object sender, EventArgs e)
        {

        }

        private void SzczegolyZamowieniaKlienta_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DZ_Szczegoly_zamowienia_klienta szczegoly_zamowienia_Klienta = new DZ_Szczegoly_zamowienia_klienta();
            int numer = Convert.ToInt32(this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            szczegoly_zamowienia_Klienta.Id_zamowienia = numer;
            szczegoly_zamowienia_Klienta.Id_pliku = Convert.ToInt32(comboBox1.SelectedValue);
            szczegoly_zamowienia_Klienta.Ilosc_sztuk = Convert.ToInt32(numericUpDown1.Value);
            szczegoly_zamowienia_Klienta.Id_materialu = Convert.ToInt32(comboBox2.SelectedValue);
            database.DZ_Szczegoly_zamowienia_klienta.Add(szczegoly_zamowienia_Klienta);
            database.SaveChanges();
            initdvgs();
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć wybrane szczegóły zamówienia?", "Uwaga, po zatwierdzeniu rekord zostanie trwale usunięty z bazy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);

                DZ_Szczegoly_zamowienia_klienta toRemove = this.database.DZ_Szczegoly_zamowienia_klienta.Where(szczegoly_zamowienia_klienta => szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta == id).First();


                this.database.DZ_Szczegoly_zamowienia_klienta.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgs();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int numer2 = Convert.ToInt32(this.textBox1.Text);
            dataGridView2.DataSource = database.vDZ_Szczegoly_zamowienia_klienta.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
        }
    }
}
