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
    
    public partial class Narzedzie_glowny : Form
    {
        DrukarniaEntities database;
        public Narzedzie_glowny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnNarzedzie_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Narzedzie narzedzie = new Narzedzie(this.database);
            narzedzie.ShowDialog();
        }

        private void btn_Rodzaje_Click(object sender, EventArgs e)
        {
            Rodzaj_narzedzia rodzaj = new Rodzaj_narzedzia(this.database);
            rodzaj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WlasciwoscNarzedzia nowa = new WlasciwoscNarzedzia(this.database);
                nowa.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WypozyczenieNarzedzia wypozyczenie = new WypozyczenieNarzedzia(this.database);
                wypozyczenie.ShowDialog();
            this.Close();
        }
    }
}
