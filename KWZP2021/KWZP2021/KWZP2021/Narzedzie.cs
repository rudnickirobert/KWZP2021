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
    public partial class Narzedzie : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow dataGridView;
        public Narzedzie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvNarzedzie.DataSource = this.database.vDM_Narzedzie.ToList();
            initDataGridView();
        }
        private void initDataGridView()
        {
            this.dgvNarzedzie.DataSource = this.database.vDM_Narzedzie.ToList();
        }

        private void btnNarzedziePowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_magazynowy Dzial_magazynowy = new Dzial_magazynowy(this.database);
            Dzial_magazynowy.ShowDialog();
        }
         private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvNarzedzie.DataSource = database.vDM_Narzedzie.Where(x => x.Nazwa.Contains(textBox1.Text) || x.Rodzaj_narzedzia.Contains(textBox1.Text)).ToList();
        }

        private void btnUsuwanieNarzedzia_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Zuzyte_narzedzie zuzytenarzedzie = new Zuzyte_narzedzie(this.database);
            zuzytenarzedzie.ShowDialog();
        }
    }
}
