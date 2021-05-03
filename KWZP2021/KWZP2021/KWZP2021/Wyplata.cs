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
    public partial class Wyplata : Form
    {
        DrukarniaEntities database;
        public Wyplata(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDZ_Wyplata.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DataSource = this.database.vDZ_Wyplata.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = database.vDZ_Wyplata.Where(x => x.Imie.Contains(textBox1.Text)|| x.Nazwisko.Contains(textBox1.Text)).ToList();
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Konkretna_wyplata konkretna_wyplata = new Konkretna_wyplata(this.database);
            konkretna_wyplata.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            konkretna_wyplata.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            konkretna_wyplata.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            konkretna_wyplata.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            konkretna_wyplata.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            konkretna_wyplata.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            konkretna_wyplata.textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           

            konkretna_wyplata.ShowDialog();
        }
        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp,new Rectangle(0,0,dataGridView1.Width,dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void Wyplata_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
