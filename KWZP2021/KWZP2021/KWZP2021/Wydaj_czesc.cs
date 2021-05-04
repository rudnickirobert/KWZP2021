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
    public partial class Wydaj_czesc : Form
    {
        DrukarniaEntities database;

        public Wydaj_czesc(DrukarniaEntities database)
        {
            InitializeComponent();

            this.database = database;
            initCombobox();
        }
        public void initCombobox()
        {
            this.comboBox1.DataSource = this.database.DM_Wydanie_czesci.ToList();
            this.comboBox1.DisplayMember = "Identyfikator wypozyczenia";
            this.comboBox1.ValueMember = "Identyfikator wypozyczenia";

            this.comboBox2.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox2.DisplayMember = "Nazwisko";

            this.comboBox3.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox3.DisplayMember = "Nazwisko";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Czesc_glowna czescglowna = new Czesc_glowna(this.database);
            czescglowna.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Lista_wypozyczen listawypozyczen = new Lista_wypozyczen(this.database);
            listawypozyczen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DM_Wydanie_czesci newWypozyczenie_czesci = new DM_Wydanie_czesci();
            newWypozyczenie_czesci.Id_wydania_czesci = Convert.ToInt32(comboBox1.SelectedValue);
            newWypozyczenie_czesci.Id_pracownik_pobierajacy = Convert.ToInt32(comboBox2.SelectedValue);
            newWypozyczenie_czesci.Id_pracownik_wydajacy = Convert.ToInt32(comboBox3.SelectedValue);

            this.database.DM_Wydanie_czesci.Add(newWypozyczenie_czesci);
            this.database.SaveChanges();
            this.Close();
            this.Hide();
            Parametr_czesci parametrczesci = new Parametr_czesci(this.database);
            parametrczesci.ShowDialog();
        }
    }
}
