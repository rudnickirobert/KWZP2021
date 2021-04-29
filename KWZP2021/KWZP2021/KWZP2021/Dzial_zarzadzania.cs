using System;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Dzial_zarzadzania : Form
    {
        DrukarniaEntities database;
        public Dzial_zarzadzania(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDZ_Zatrudnienie.ToList();
        }
        private void Dzial_zarzadzania_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stanowiska stanowiska = new Stanowiska(this.database);
            stanowiska.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DataSource = this.database.vDZ_Zatrudnienie;
        }
    }
}
