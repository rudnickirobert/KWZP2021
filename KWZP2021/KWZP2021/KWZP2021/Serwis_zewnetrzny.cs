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
    public partial class Serwis_zewnetrzny : Form
    {
        DrukarniaEntities database;
        public Serwis_zewnetrzny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvSerwisZew.DataSource = this.database.vDP_Serwis_zewnetrzny.ToList();
            initDataGridView();
        }

        private void initDataGridView()
        {
            this.dgvSerwisZew.DataSource = this.database.vDP_Serwis_zewnetrzny.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvSerwisZew.DataSource = database.vDP_Serwis_zewnetrzny.Where(x => x.Nazwa_firmy_serwisowej.Contains(textBox1.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_produkcji dzialProdukcji = new Dzial_produkcji(this.database);
            dzialProdukcji.ShowDialog();
        }

        private void btnUsunSerw_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć serwis zewnętrzny?", "Usuwanie serwisu zewnętrznego", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvSerwisZew.CurrentRow.Cells[0].Value);

                DP_Serwis_zewnetrzny toRemove = this.database.DP_Serwis_zewnetrzny.Where(serwiszewn => serwiszewn.Id_serwis_zewnetrzny == id).First();


                this.database.DP_Serwis_zewnetrzny.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdgvSerwisZew();
            }
        }


        public void initdgvSerwisZew()
        {
            this.dgvSerwisZew.DataSource = this.database.vDP_Serwis_zewnetrzny.ToList();

        }

        private void btnAddSerwis_Click(object sender, EventArgs e)
        {
            Nowy_serwis_zewnetrzny nowy_serwis_zewnetrzny = new Nowy_serwis_zewnetrzny(this.database);
            nowy_serwis_zewnetrzny.ShowDialog();
            initdgvSerwisZew();
        }

        private void dgvSerwisZew_DoubleClick(object sender, EventArgs e)
        {
            Edytuj_serwis_zewnetrzny edytujSerwisZewn = new Edytuj_serwis_zewnetrzny(this.database);
            edytujSerwisZewn.comboBox1.Text = dgvSerwisZew.CurrentRow.Cells[1].Value.ToString();
            edytujSerwisZewn.comboBox2.Text = dgvSerwisZew.CurrentRow.Cells[2].Value.ToString();
            edytujSerwisZewn.comboBox3.Text = dgvSerwisZew.CurrentRow.Cells[3].Value.ToString();
            edytujSerwisZewn.txtKoszt.Text = dgvSerwisZew.CurrentRow.Cells[4].Value.ToString();
            edytujSerwisZewn.dateTimePicker1.Text = dgvSerwisZew.CurrentRow.Cells[5].Value.ToString();
            edytujSerwisZewn.dateTimePicker2.Text = dgvSerwisZew.CurrentRow.Cells[6].Value.ToString();
            edytujSerwisZewn.textBox1.Text = dgvSerwisZew.CurrentRow.Cells[6].Value.ToString();

            edytujSerwisZewn.ShowDialog();
            initDataGridView();
        }
    }

}