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
    public partial class Dodaj_parametr_czesci : Form
    {
        public DrukarniaEntities database;

        public Dodaj_parametr_czesci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = this.database.DM_Czesc.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_czesci";

            this.comboBox2.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.comboBox2.DisplayMember = "Nazwa_wlasciwosci";
            this.comboBox2.ValueMember = "Id_wlasciwosc";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DM_Parametr_czesci newi = new DM_Parametr_czesci();
            newi.Id_czesci = Convert.ToInt32(comboBox1.SelectedValue);
            newi.Id_wlasciwosc = Convert.ToInt32(comboBox2.SelectedValue);
            newi.Wartosc = textBox1.Text;

            this.database.DM_Parametr_czesci.Add(newi);
            this.database.SaveChanges();
            this.Close();
            this.Hide();
            Parametr_czesci parametrczesci = new Parametr_czesci(this.database);
            parametrczesci.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Parametr_czesci parametrczesci = new Parametr_czesci(this.database);
            parametrczesci.ShowDialog();
        }
    }
}
