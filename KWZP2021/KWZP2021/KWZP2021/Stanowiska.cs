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
    public partial class Stanowiska : Form
    {

        private DrukarniaEntities database;

        public Stanowiska(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.comboBox1.DataSource = this.database.DZ_Stanowisko.ToList();
            this.comboBox1.DisplayMember = "Stanowisko";
            this.comboBox1.ValueMember = "Id_stanowiska";

            this.dataGridView1.DataSource = this.database.DZ_Stanowisko.ToList();
        }

        private void initCombobox()
        {
            this.comboBox1.DataSource = this.database.DZ_Stanowisko.ToList();
            this.comboBox1.DisplayMember = "Stanowisko";
        }

        private void initDataGridView()
        {
            this.dataGridView1.DataSource = this.database.DZ_Stanowisko.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DZ_Stanowisko newStanowisko = new DZ_Stanowisko();
            newStanowisko.stanowisko = this.textBox1.Text;

            this.database.DZ_Stanowisko.Add(newStanowisko);
            this.database.SaveChanges();
            initCombobox();
            this.textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Close();
            //Stanowiska stanowiska = new Stanowiska(this.database);
            //stanowiska.ShowDialog();

            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

            DZ_Stanowisko toRemove = this.database.DZ_Stanowisko.Where(stanowisko => stanowisko.Id_stanowiska == id).First();

            toRemove.stanowisko = textBox1.Text; // UPDATE

            //this.database.DZ_Stanowisko.Remove(toRemove); // DELETE

            this.database.SaveChanges();
            initDataGridView();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

            DZ_Stanowisko toRemove = this.database.DZ_Stanowisko.Where(stanowisko => stanowisko.Id_stanowiska == id).First();

            // toRemove.nr_seryjny = toRemove.nr_seryjny + " testowy"; // UPDATE

            this.database.DZ_Stanowisko.Remove(toRemove); // DELETE

            this.database.SaveChanges();
            initDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Stanowiska stanowiska = new Stanowiska(this.database);
            stanowiska.ShowDialog();
        }
    }
}
