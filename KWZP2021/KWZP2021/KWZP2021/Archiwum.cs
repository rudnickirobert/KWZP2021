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
    public partial class Archiwum : Form
    {
        DrukarniaEntities database;
        public Archiwum(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Archiwum_oplaty archiwum_oplaty = new Archiwum_oplaty(this.database);
            archiwum_oplaty.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Archiwum_koszty archiwum_koszty = new Archiwum_koszty(this.database);
            archiwum_koszty.ShowDialog();
        }
    }
}
