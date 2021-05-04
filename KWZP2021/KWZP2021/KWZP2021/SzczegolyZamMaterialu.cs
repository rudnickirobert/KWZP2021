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
    public partial class SzczegolyZamMaterialu : Form
    {
        DrukarniaEntities database;
        public SzczegolyZamMaterialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_materialu.ToList();

            this.comboBox1.DataSource = this.database.DM_Material.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_materialu";

            this.comboBox2.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.comboBox2.DisplayMember = "Jednostka_pomiarowa";
            this.comboBox2.ValueMember = "Id_wlasciwosc";
        }

        private void initdvgs()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_materialu.ToList();

        }
        private void SzczegolyZamMaterialu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ_Szczegoly_zam_materialu szczegoly_zamowienia_materialu = new DZ_Szczegoly_zam_materialu();
            int numer = Convert.ToInt32(this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            szczegoly_zamowienia_materialu.Id_zamowienia_zewn = numer;
            szczegoly_zamowienia_materialu.Id_materialu = Convert.ToInt32(comboBox1.SelectedValue);
            szczegoly_zamowienia_materialu.Koszt_jednostkowy_oferta = Convert.ToInt32(textBox2.Text);
            szczegoly_zamowienia_materialu.Id_wlasciwosc = Convert.ToInt32(comboBox2.SelectedValue);
            szczegoly_zamowienia_materialu.Ilosc = Convert.ToInt32(numericUpDown1.Value);
            database.DZ_Szczegoly_zam_materialu.Add(szczegoly_zamowienia_materialu);
            database.SaveChanges();
            initdvgs();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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

                DZ_Szczegoly_zam_materialu toRemove = this.database.DZ_Szczegoly_zam_materialu.Where(szczegoly_zamowienia => szczegoly_zamowienia.Id_szczegoly_zam_materialu == id).First();


                this.database.DZ_Szczegoly_zam_materialu.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgs();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numer2 = Convert.ToInt32(this.textBox1.Text);
            dataGridView2.DataSource = database.vDZ_Szczegoly_zam_materialu.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
        }
    
    }
}
