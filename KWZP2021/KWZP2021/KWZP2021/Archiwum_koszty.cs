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
    public partial class Archiwum_koszty : Form
    {
        DrukarniaEntities database;
        public Archiwum_koszty(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDZ_Archiwum_Koszty_zewnetrzne.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DataSource = this.database.vDZ_Archiwum_Koszty_zewnetrzne.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.vDZ_Archiwum_Koszty_zewnetrzne.Where(x => x.Data.ToString().Contains(textBox1.Text)).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
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
