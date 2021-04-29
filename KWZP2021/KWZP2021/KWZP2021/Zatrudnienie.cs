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
    public partial class Zatrudnienie : Form
    {
        DrukarniaEntities database;
        public Zatrudnienie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initDataGridView();
        }

        private void Zatrudnienie_Load(object sender, EventArgs e)
        {

        }
        private void initDataGridView()
        {
            this.dgvZatrudnienie.DataSource = this.database.vDZ_Zatrudnienie.ToList();

        }
        private void dgvZatrudnienie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            initDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
