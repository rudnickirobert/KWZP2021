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
    public partial class Konkretna_faktura : Form
    {
        DrukarniaEntities database;
        public Konkretna_faktura(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            

      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }
    }
}
