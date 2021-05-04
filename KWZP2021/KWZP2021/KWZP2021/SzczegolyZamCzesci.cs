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
    public partial class SzczegolyZamCzesci : Form
    {
        DrukarniaEntities database;
        public SzczegolyZamCzesci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_czesci.ToList();

            this.comboBox1.DataSource = this.database.DM_Czesc.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_czesci";

            this.comboBox2.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.comboBox2.DisplayMember = "Jednostka_pomiarowa";
            this.comboBox2.ValueMember = "Id_wlasciwosc";
        }

        private void initdvgs()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_czesci.ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DZ_Szczegoly_zam_czesci szczegoly_zamowienia_czesci = new DZ_Szczegoly_zam_czesci();
            int numer = Convert.ToInt32(this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            szczegoly_zamowienia_czesci.Id_zamowienia_zewn = numer;
            szczegoly_zamowienia_czesci.Id_czesci = Convert.ToInt32(comboBox1.SelectedValue);
            szczegoly_zamowienia_czesci.Koszt_jednostkowy_oferta = Convert.ToInt32(textBox2.Text);
            szczegoly_zamowienia_czesci.Id_wlasciwosc = Convert.ToInt32(comboBox2.SelectedValue);
            szczegoly_zamowienia_czesci.Ilosc = Convert.ToInt32(numericUpDown1.Value);
            database.DZ_Szczegoly_zam_czesci.Add(szczegoly_zamowienia_czesci);
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

                DZ_Szczegoly_zam_czesci toRemove = this.database.DZ_Szczegoly_zam_czesci.Where(szczegoly_zamowienia => szczegoly_zamowienia.Id_szczegoly_zam_czesci == id).First();


                this.database.DZ_Szczegoly_zam_czesci.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgs();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numer2 = Convert.ToInt32(this.textBox1.Text);
            dataGridView2.DataSource = database.vDZ_Szczegoly_zam_czesci.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
        }
    
        private void SzczegolyZamCzesci_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
