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
    public partial class Konkretne_zatrudnienie : Form
    {
        DrukarniaEntities database;
        public Konkretne_zatrudnienie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void lblNowyKlient_Click(object sender, EventArgs e)
        {

        }

        private void Konkretne_zatrudnienie_Load(object sender, EventArgs e)
        {

        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
