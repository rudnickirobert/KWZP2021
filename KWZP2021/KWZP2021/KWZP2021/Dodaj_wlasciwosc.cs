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
    public partial class Dodaj_wlasciwosc : Form
    {
        DrukarniaEntities database;
        public Dodaj_wlasciwosc(DrukarniaEntities database)
        {
            InitializeComponent();
            DM_Wlasciwosc wlasciwosc = new DM_Wlasciwosc();
            wlasciwosc.Nazwa_wlasciwosci = textBox3.Text;
            wlasciwosc.Jednostka_pomiarowa = textBox2.Text;
            database.DM_Wlasciwosc.Add(wlasciwosc);
            database.SaveChanges();
            MessageBox.Show("Dodano nową wlasciwosc");
            this.Close();
        }
    }
}
