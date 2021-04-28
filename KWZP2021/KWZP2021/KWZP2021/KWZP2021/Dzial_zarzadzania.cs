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
    public partial class Dzial_zarzadzania : Form
    {
        DrukarniaEntities database;
        public Dzial_zarzadzania(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Dzial_zarzadzania_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stanowiska stanowiska = new Stanowiska(this.database);
            stanowiska.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klienci klienci = new Klienci (this.database);
            klienci.ShowDialog();
        }
    }
}
