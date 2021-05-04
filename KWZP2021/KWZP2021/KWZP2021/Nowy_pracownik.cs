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
    public partial class Nowy_pracownik : Form
    {
        DrukarniaEntities database;
        public Nowy_pracownik(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void lblNowyKlient_Click(object sender, EventArgs e)
        {

        }

        public void buttonZapiszKonkretnegoKlienta_Click(object sender, EventArgs e)
        {
            DZ_Pracownik pracownik = new DZ_Pracownik();
            pracownik.Imie = txtImie2.Text;
            pracownik.Nazwisko = txtNazwisko2.Text;
            pracownik.Adres = txtAdres2.Text;
            pracownik.Miasto = txtMiasto2.Text;
            pracownik.Kod_pocztowy = txtKod_Pocztowy2.Text;
            pracownik.Email = txtEmail2.Text;
            pracownik.Telefon = txtTelefon2.Text;
            pracownik.Numer_rachunku = txtNumer_Rachunku2.Text;
            pracownik.Data_urodzenia = dateTimePicker1.Value;
            database.DZ_Pracownik.Add(pracownik);
            database.SaveChanges();
            Nowe_zatrudnienie frm = (Nowe_zatrudnienie)Application.OpenForms["Nowe_zatrudnienie"];
            frm.cmbPracownik.DataSource = this.database.DZ_Pracownik.ToList();
            frm.cmbPracownik.SelectedIndex = frm.cmbPracownik.Items.Count - 1;
            frm.textBox1.Text = pracownik.Nazwisko.ToString();
            
            this.Close();
            
        }

        private void Nowy_pracownik_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            txtImie2.Text = "";
            txtNazwisko2.Text = "";
            txtAdres2.Text = "";
            txtMiasto2.Text = "";
            txtKod_Pocztowy2.Text = "";
            txtEmail2.Text = "";
            txtTelefon2.Text = "";
            txtNumer_Rachunku2.Text = "";
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
