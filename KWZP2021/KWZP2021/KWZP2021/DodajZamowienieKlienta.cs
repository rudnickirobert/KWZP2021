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
    public partial class DodajZamowienieKlienta : Form
    {
        DrukarniaEntities database;
        public DodajZamowienieKlienta(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.comboBox1_nazwa_firmy.DataSource = this.database.DZ_Klient.ToList();
            this.comboBox1_nazwa_firmy.DisplayMember = "Nazwa_firmy";
            this.comboBox1_nazwa_firmy.ValueMember = "Id_klienta";

            this.comboBox2_Pracownik.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox2_Pracownik.DisplayMember = "Nazwisko";
            this.comboBox2_Pracownik.ValueMember = "Id_pracownika";
        }

        private void DodajZamowienieKlienta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Zapisz_Click(object sender, EventArgs e)
        {
            DZ_Zamowienie_klienta zamowienie_Klienta = new DZ_Zamowienie_klienta();
            zamowienie_Klienta.Id_klienta = Convert.ToInt32( comboBox1_nazwa_firmy.SelectedValue);
            zamowienie_Klienta.Id_pracownika = Convert.ToInt32(comboBox2_Pracownik.SelectedValue);
            zamowienie_Klienta.Data_zamowienia = dateTimePicker1_Data_zam.Value;
            zamowienie_Klienta.Oczekiwany_termin_wykonania = dateTimePicker2_oczekiwany_termin.Value;
            database.DZ_Zamowienie_klienta.Add(zamowienie_Klienta);
            database.SaveChanges();
            this.Close();
        }

        private void button2_Powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_nazwa_firmy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
