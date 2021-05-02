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
    public partial class Oferta_dla_klienta : Form
    {
        DrukarniaEntities database;
        public Oferta_dla_klienta(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDZ_Oferta_dla_klienta.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DataSource = this.database.vDZ_Oferta_dla_klienta.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.vDZ_Oferta_dla_klienta.Where(x => x.Nazwa_firmy.Contains(textBox1.Text)|| x.Status_zamowienia.Contains(textBox1.Text) || x.Nip.Contains(textBox1.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;

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
    }
}
