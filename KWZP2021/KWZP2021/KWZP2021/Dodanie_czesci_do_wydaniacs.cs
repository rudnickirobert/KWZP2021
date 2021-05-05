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
    public partial class Dodanie_czesci_do_wydaniacs : Form
    {
        DrukarniaEntities database;
        public Dodanie_czesci_do_wydaniacs(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = this.database.DM_Czesc.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_czesci";
            this.comboBox2.DataSource = this.database.DM_Wydanie_czesci.ToList();
            this.comboBox2.DisplayMember = "Id_wydania_czesci";
            this.comboBox2.ValueMember = "Id_wydania_czesci";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DM_Szczegoly_wydania_czesci czescss = new DM_Szczegoly_wydania_czesci();
            czescss.Id_czesci = Convert.ToInt32(comboBox1.SelectedValue);
            czescss.Id_wydania_czesci = Convert.ToInt32(comboBox2.SelectedValue);
            czescss.Ilosc = Convert.ToInt32(textBox1.Text);

            this.database.DM_Szczegoly_wydania_czesci.Add(czescss);
            this.database.SaveChanges();
            this.Close();
            Lista_wypozyczen listaa = new Lista_wypozyczen(this.database);
            listaa.ShowDialog();
        }
    }
}
