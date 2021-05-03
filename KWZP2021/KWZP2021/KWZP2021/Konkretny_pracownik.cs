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
    public partial class Konkretny_pracownik : Form
    {
        DrukarniaEntities database;
        public Konkretny_pracownik(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void Konkretny_pracownik_Load(object sender, EventArgs e)
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
                txtData2.Text = "";


        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapiszKonkretnegoKlienta_Click(object sender, EventArgs e)
        {
            Pracownicy frm = (Pracownicy)Application.OpenForms["Pracownicy"];
            int row = Convert.ToInt32(frm.dvgPracownik.CurrentRow.Cells[0].Value);
            DZ_Pracownik toUpdate = this.database.DZ_Pracownik.Where(pracownik => pracownik.Id_pracownika == row).First();

            toUpdate.Imie = txtImie2.Text; // UPDATE
            toUpdate.Nazwisko = txtNazwisko2.Text; // UPDATE
            toUpdate.Adres = txtAdres2.Text; // UPDATE
            toUpdate.Miasto = txtMiasto2.Text; // UPDATE
            toUpdate.Kod_pocztowy = txtKod_Pocztowy2.Text; // UPDATE
            toUpdate.Email = txtEmail2.Text; // UPDATE
            toUpdate.Telefon = txtTelefon2.Text; // UPDATE
            toUpdate.Numer_rachunku = txtNumer_Rachunku2.Text; // UPDATE
            toUpdate.Data_urodzenia = dateTimePicker1.Value;
            frm.dvgPracownik.DataSource = this.database.vDZ_Pracownik.ToList();
            this.database.SaveChanges();
            this.Close();
        }
    }
}
