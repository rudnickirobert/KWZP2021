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
    public partial class Konkretny_klient : Form
    {
        DrukarniaEntities database;
        public Konkretny_klient(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Konkretny_klient_Load(object sender, EventArgs e)
        {

        }

        private void dgvKonkretny_klient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNowyKlient_Click(object sender, EventArgs e)
        {

        }

     
    }
}
