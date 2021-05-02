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
    public partial class Maszyna : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow dataGridView;
        public Maszyna(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvMaszyna.DataSource = this.database.vDP_Maszyna.ToList();
            dataGridView1_CellContentClick();
        }

    
        //private void dataGridView1_CellContentClick()
        //{
        //    this.dgv_Maszyna.DataSource = this.database.vDP_Maszyna.ToList();
        //}

        private void dataGridView1_CellContentClick()
        {
            this.dgvMaszyna.DataSource = this.database.vDP_Maszyna.ToList();

        }
    }
}
