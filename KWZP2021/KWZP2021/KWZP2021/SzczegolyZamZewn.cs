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
    public partial class SzczegolyZamZewn : Form
    {
        DrukarniaEntities database;
        public SzczegolyZamZewn(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView4.DataSource = this.database.vDZ_Szczegoly_zam_materialu.ToList();
            this.dataGridView3.DataSource = this.database.vDZ_Szczegoly_zam_czesci.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_maszyn.ToList();
            this.dataGridView1.DataSource = this.database.vDZ_Szczegoly_zam_narzedzi.ToList();

            this.comboBox1.DataSource = this.database.DZ_Zamowienie_zewn.ToList();
            this.comboBox1.DisplayMember = "Id_zamowienia_zewn";
            this.comboBox1.ValueMember = "Id_zamowienia_zewn";
        }


        private void initdvg()
        {
            this.dataGridView4.DataSource = this.database.vDZ_Szczegoly_zam_materialu.ToList();
            this.dataGridView3.DataSource = this.database.vDZ_Szczegoly_zam_czesci.ToList();
            this.dataGridView2.DataSource = this.database.vDZ_Szczegoly_zam_maszyn.ToList();
            this.dataGridView1.DataSource = this.database.vDZ_Szczegoly_zam_narzedzi.ToList();

        }

        private void SzczegolyZamZewn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text = Convert.ToString(comboBox1.SelectedValue);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numer2 = Convert.ToInt32(this.textBox1.Text);
            dataGridView1.DataSource = database.vDZ_Szczegoly_zam_narzedzi.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
            dataGridView3.DataSource = database.vDZ_Szczegoly_zam_czesci.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
            dataGridView2.DataSource = database.vDZ_Szczegoly_zam_maszyn.Where(x => x.Numer_zamówienia.Equals(numer2)).ToList();
            dataGridView4.DataSource = database.vDZ_Szczegoly_zam_materialu.Where(x => x.Numer_zamowienia.Equals(numer2)).ToList();
        }
    }
}
