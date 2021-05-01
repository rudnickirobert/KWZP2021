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
    public partial class Szcz_zatrudnienia_2 : Form
    {
        DrukarniaEntities database;
        public Szcz_zatrudnienia_2(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Szcz_zatrudnienia_2_Load(object sender, EventArgs e)
        {

        }

        private void txtNumerUmowy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
