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
    public partial class Czesc : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow dataGridView;
        public Czesc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dgvCzesc.DataSource = this.database.vDM_Czesc.ToList();
            initDataGridView();
        }
        

        private void initDataGridView()
        {
            this.dgvCzesc.DataSource = this.database.vDM_Czesc.ToList();
        }

        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            DodajCzesc dodajczesc = new DodajCzesc(this.database);
            dodajczesc.ShowDialog();
        }

        private void btnCzescPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_magazynowy Dzial_magazynowy = new Dzial_magazynowy(this.database);
            Dzial_magazynowy.ShowDialog();
        }

        private void txtWyszukajCzesc_TextChanged(object sender, EventArgs e)
        {
            dgvCzesc.DataSource = database.vDM_Czesc.Where(x => x.Nazwa.Contains(txtWyszukajCzesc.Text)).ToList();
        }
    }
}
