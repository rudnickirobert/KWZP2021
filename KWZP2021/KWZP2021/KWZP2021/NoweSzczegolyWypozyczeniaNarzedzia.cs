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
    public partial class NoweSzczegolyWypozyczeniaNarzedzia : Form
    {
        DrukarniaEntities database;

        public NoweSzczegolyWypozyczeniaNarzedzia(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.cmb1.DataSource = this.database.DM_Narzedzie.ToList();
            this.cmb1.DisplayMember = "Nazwa";
            this.cmb1.ValueMember = "Id_narzedzia";
            this.cmb2.DataSource = this.database.DM_Wypozyczenie_narzedzia.ToList();
            this.cmb2.DisplayMember = "Id_wypozyczenia_narzedzia";
            this.cmb2.ValueMember = "Id_wypozyczenia_narzedzia";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DM_Szczegoly_wypozyczenia_narzedzia narzedzie = new DM_Szczegoly_wypozyczenia_narzedzia();
            narzedzie.Id_wypozyczenia_narzedzia = Convert.ToInt32(cmb2.SelectedValue);
            narzedzie.Id_narzedzia = Convert.ToInt32(cmb1.SelectedValue);
            narzedzie.Ilosc = Convert.ToInt32(textBox1.Text);
            this.database.DM_Szczegoly_wypozyczenia_narzedzia.Add(narzedzie);
            this.database.SaveChanges();
            this.Close();
        }
    }
}
