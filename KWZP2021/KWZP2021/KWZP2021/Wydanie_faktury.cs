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
    public partial class Wydanie_faktury : Form
    {
        DrukarniaEntities database;
        public Wydanie_faktury(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDZ_Wydanie_faktury.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DataSource = this.database.vDZ_Wydanie_faktury.ToList();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.vDZ_Wydanie_faktury.Where(x => x.Nazwa_firmy.Contains(textBox1.Text)|| x.Status_zamówienia.Contains(textBox1.Text) || x.Wydanie_faktury.Contains(textBox1.Text) || x.NIP.Contains(textBox1.Text)).ToList();

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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Konkretna_faktura konkretna_faktura = new Konkretna_faktura(this.database);
            konkretna_faktura.txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            konkretna_faktura.txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            konkretna_faktura.txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            konkretna_faktura.txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            konkretna_faktura.txt5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            konkretna_faktura.txt6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            konkretna_faktura.txt7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            konkretna_faktura.txt8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            konkretna_faktura.txt9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            konkretna_faktura.txt10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            konkretna_faktura.txt11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            konkretna_faktura.txt12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            konkretna_faktura.txt13.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            
            konkretna_faktura.ShowDialog();
        }
    }
}
