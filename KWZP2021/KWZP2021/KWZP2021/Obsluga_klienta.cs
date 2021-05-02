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
    public partial class Obsluga_klienta : Form
    {
        DrukarniaEntities database;
        public Obsluga_klienta(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wplywy wplywy = new Wplywy(this.database);
            wplywy.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wydanie_faktury wydanie_faktury = new Wydanie_faktury(this.database);
            wydanie_faktury.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oferta_dla_klienta oferta_dla_klienta = new Oferta_dla_klienta(this.database);
            oferta_dla_klienta.ShowDialog();
        }
    }
}
