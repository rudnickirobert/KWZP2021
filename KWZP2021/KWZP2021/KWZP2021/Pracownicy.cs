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
    public partial class Pracownicy : Form
    {
        DrukarniaEntities database;
        public Pracownicy(DrukarniaEntities database)
        {
            
            InitializeComponent();
            this.database = database;
            this.dvgPracownik.DataSource = this.database.vDZ_Pracownik.ToList();

        }
        private void dvgPracownik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dvgPracownik.DataSource = this.database.vDZ_Pracownik.ToList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {

        }
    }
}
