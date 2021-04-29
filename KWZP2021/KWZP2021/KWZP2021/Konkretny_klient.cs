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
    public partial class Konkretny_klient : Form
    {
        DrukarniaEntities database;
        public Konkretny_klient(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Konkretny_klient_Load(object sender, EventArgs e)
        {

        }

        private void dgvKonkretny_klient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNowyKlient_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapiszNowegoKlienta_Click(object sender, EventArgs e)
        {
            DZ_Klient konkretny_klient = new DZ_Klient();
            konkretny_klient.Nazwa_firmy = txtNazwa_Firmy1.Text;
            konkretny_klient.Nip = txtNip1.Text;
            konkretny_klient.Imie = txtImie1.Text;
            konkretny_klient.Nazwisko = txtNazwisko1.Text;
            konkretny_klient.Adres = txtAdres1.Text;
            konkretny_klient.Miasto = txtMiasto1.Text;
            konkretny_klient.Kod_pocztowy = txtKod_Pocztowy1.Text;
            konkretny_klient.Email = txtEmail1.Text;
            konkretny_klient.Telefon = txtTelefon1.Text;
            konkretny_klient.Numer_rachunku = txtNumer_Rachunku1.Text;
            database.DZ_Klient.Add(konkretny_klient);
            database.SaveChanges();
            this.Close();
        }
    }
}
