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
    public partial class Nowe_zatrudnienie : Form
    {
        DrukarniaEntities database;
        public Nowe_zatrudnienie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbPracownik.DataSource = this.database.DZ_Pracownik.ToList();
            this.cmbPracownik.DisplayMember = "Nazwisko";
            this.cmbPracownik.ValueMember = "Id_pracownika";

            this.cmbStanowisko.DataSource = this.database.DZ_Stanowisko.ToList();
            this.cmbStanowisko.DisplayMember = "Stanowisko";
            this.cmbStanowisko.ValueMember = "Id_stanowiska";

            this.cmbDzial.DataSource = this.database.DZ_Dzial.ToList();
            this.cmbDzial.DisplayMember = "Dzial";
            this.cmbDzial.ValueMember = "Id_dzialu";

            this.cmbEtat.DataSource = this.database.DZ_Etat.ToList();
            this.cmbEtat.DisplayMember = "Etat";
            this.cmbEtat.ValueMember = "Id_etatu";

            this.cmbRodzaj_umowy.DataSource = this.database.DZ_Rodzaj_umowy.ToList();
            this.cmbRodzaj_umowy.DisplayMember = "Rodzaj_umowy";
            this.cmbRodzaj_umowy.ValueMember = "Id_rodzaj_umowy";

            



        }

        private void Nowe_zatrudnienie_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void cmbPracownik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapiszNowegoKlienta_Click(object sender, EventArgs e)
        {
            DZ_Zatrudnienie zatrudnienie = new DZ_Zatrudnienie();
            zatrudnienie.Data_zatrudnienia = Convert.ToDateTime(dataZatrudnienia.Value);
            zatrudnienie.Data_zwolnienia = Convert.ToDateTime(dataZwolnienia.Value);
            zatrudnienie.Id_pracownika = Convert.ToInt32(cmbPracownik.SelectedValue);
            zatrudnienie.Id_stanowiska = Convert.ToInt32(cmbStanowisko.SelectedValue);
            zatrudnienie.Id_dzialu = Convert.ToInt32(cmbDzial.SelectedValue);
            zatrudnienie.Id_etatu = Convert.ToInt32(cmbEtat.SelectedValue);
            zatrudnienie.Id_rodzaj_umowy = Convert.ToInt32(cmbRodzaj_umowy.SelectedValue);
            database.DZ_Zatrudnienie.Add(zatrudnienie);
            database.SaveChanges();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nowy_pracownik pracownik = new Nowy_pracownik(this.database);
            pracownik.ShowDialog();
                    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            cmbPracownik.Text = "";
            cmbStanowisko.Text = "";
            cmbDzial.Text = "";
            cmbEtat.Text = "";
            cmbRodzaj_umowy.Text = "";
            
            
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
