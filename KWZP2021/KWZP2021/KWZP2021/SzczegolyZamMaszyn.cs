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
    public partial class SzczegolyZamMaszyn : Form
    {
        DrukarniaEntities database;
        public SzczegolyZamMaszyn(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_maszyn.ToList();

            this.comboBox1.DataSource = this.database.DP_Maszyna.ToList();
            this.comboBox1.DisplayMember = "Id_model_maszyny";
            this.comboBox1.ValueMember = "Id_maszyny";
        }

        private void initdvgs()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_maszyn.ToList();

        }
        private void SzczegolyZamMaszyn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ_Szczegoly_zam_maszyn szczegoly_zamowienia_maszyn = new DZ_Szczegoly_zam_maszyn();
            int numer = Convert.ToInt32(this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            szczegoly_zamowienia_maszyn.Id_zamowienia_zewn = numer;
            szczegoly_zamowienia_maszyn.Id_maszyny = Convert.ToInt32(comboBox1.SelectedValue);
            szczegoly_zamowienia_maszyn.Koszt_jednostkowy_oferta = Convert.ToInt32(textBox2.Text);
            szczegoly_zamowienia_maszyn.Ilosc = Convert.ToInt32(numericUpDown1.Value);
            database.DZ_Szczegoly_zam_maszyn.Add(szczegoly_zamowienia_maszyn);
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

                DZ_Szczegoly_zam_maszyn toRemove = this.database.DZ_Szczegoly_zam_maszyn.Where(szczegoly_zamowienia => szczegoly_zamowienia.Id_szczegoly_zam_maszyn == id).First();


                this.database.DZ_Szczegoly_zam_maszyn.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgs();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numer2 = Convert.ToInt32(this.textBox1.Text);
            dataGridView2.DataSource = database.vDZ_Szczegoly_zam_maszyn.Where(x => x.Numer_zamówienia.Equals(numer2)).ToList();
        }
    }
}
