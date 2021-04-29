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
    public partial class Nowy_klient : Form
    {
        DrukarniaEntities database;
       
        public Nowy_klient(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
           
           
        }
       
     
      
        private void Nowy_klient_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblNowyKlient_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapiszNowegoKlienta_Click(object sender, EventArgs e)
        {
            DZ_Klient klient = new DZ_Klient();
            klient.Nazwa_firmy = txtNazwa_Firmy.Text;
            klient.Nip = txtNip.Text;
            klient.Imie = txtImie.Text;
            klient.Nazwisko = txtNazwisko.Text;
            klient.Adres = txtAdres.Text;
            klient.Miasto = txtMiasto.Text;
            klient.Kod_pocztowy = txtKod_Pocztowy.Text;
            klient.Email = txtEmail.Text;
            klient.Telefon = txtTelefon.Text;
            klient.Numer_rachunku = txtNumer_Rachunku.Text;
            database.DZ_Klient.Add(klient);
            database.SaveChanges();
            this.Close();
        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            txtNazwa_Firmy.Text = "";
            txtNip.Text = "";
            txtImie.Text = "";
            txtNazwisko.Text = "";
            txtAdres.Text = "";
            txtMiasto.Text = "";
            txtKod_Pocztowy.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtNumer_Rachunku.Text = "";
       
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
