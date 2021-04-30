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

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
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

            /*string nazwa_firmy = txtNazwa_Firmy1.Text;

            DZ_Klient toUpdate = this.database.DZ_Klient.Where(Nazwa_firmy => Nazwa_firmy.Id_klienta = nazwa_firmy).First();

            toUpdate.Nazwa_firmy = txtNazwa_Firmy1.Text; // UPDATE

            //this.database.DZ_Stanowisko.Remove(toRemove); // DELETE

            this.database.SaveChanges();
    
           
           this.Close();*/


        }



    }
}
