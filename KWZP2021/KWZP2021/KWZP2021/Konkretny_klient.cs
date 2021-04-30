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
            initdataKonkretnyKlient();


        }
        private void initdataKonkretnyKlient()
        {
            this.dataKonkretnyKlient.DataSource = this.database.vDZ_Klient.ToList();

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

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            initdataKonkretnyKlient();
            this.Close();
        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            {
                txtNazwa_Firmy1.Text = "";
                txtNip1.Text = "";
                txtImie1.Text = "";
                txtNazwisko1.Text = "";
                txtAdres1.Text = "";
                txtMiasto1.Text = "";
                txtKod_Pocztowy1.Text = "";
                txtEmail1.Text = "";
                txtTelefon1.Text = "";
                txtNumer_Rachunku1.Text = "";

            }
        }

        private void buttonZapiszKonkretnegoKlienta_Click(object sender, EventArgs e)
        {

           int id = Convert.ToInt32(this.dataKonkretnyKlient.CurrentRow.Cells[0].Value);

            DZ_Klient toUpdate = this.database.DZ_Klient.Where(Nazwa_firmy => Nazwa_firmy.Id_klienta == id).First();

               toUpdate.Nazwa_firmy = txtNazwa_Firmy1.Text; // UPDATE
               toUpdate.Nip = txtNip1.Text; // UPDATE
               toUpdate.Imie = txtImie1.Text; // UPDATE
               toUpdate.Nazwisko = txtNazwisko1.Text; // UPDATE
               toUpdate.Adres = txtAdres1.Text; // UPDATE
               toUpdate.Miasto = txtMiasto1.Text; // UPDATE
               toUpdate.Kod_pocztowy = txtKod_Pocztowy1.Text; // UPDATE
               toUpdate.Email = txtEmail1.Text; // UPDATE
               toUpdate.Telefon= txtTelefon1.Text; // UPDATE
               toUpdate.Numer_rachunku = txtNumer_Rachunku1.Text; // UPDATE

                this.database.SaveChanges();
                this.Close();
                initdataKonkretnyKlient();


        }

        private void dataKonkretnyKlient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
