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
    public partial class AddFirmaSerwisowa : Form
    {
        DrukarniaEntities database;
        public AddFirmaSerwisowa(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void AddFirmaSerwisowa_Load(object sender, EventArgs e)
        {

        }

        private void btnZamknij(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnZapisz(object sender, EventArgs e)
        {
            DP_Firma_serwisowa newNazwa = new DP_Firma_serwisowa();
            newNazwa.Nazwa_firmy = this.textBox1.Text;
            this.database.DP_Firma_serwisowa.Add(newNazwa);
            this.textBox1.Text = "";

            DP_Firma_serwisowa newAdres = new DP_Firma_serwisowa();
            newAdres.Adres = this.textBox2.Text;
            this.database.DP_Firma_serwisowa.Add(newAdres);
            this.textBox2.Text = "";

            DP_Firma_serwisowa newMiasto = new DP_Firma_serwisowa();
            newMiasto.Miasto = this.textBox3.Text;
            this.database.DP_Firma_serwisowa.Add(newNazwa);
            this.textBox3.Text = "";

            DP_Firma_serwisowa newKod = new DP_Firma_serwisowa();
            newKod.Kod_pocztowy = this.textBox4.Text;
            this.database.DP_Firma_serwisowa.Add(newKod);
            this.textBox4.Text = "";

            DP_Firma_serwisowa newTel = new DP_Firma_serwisowa();
            newTel.Nr_tel = this.textBox6.Text;
            this.database.DP_Firma_serwisowa.Add(newTel);
            this.textBox5.Text = "";

            DP_Firma_serwisowa newEmail = new DP_Firma_serwisowa();
            newEmail.E_mail = this.textBox6.Text;
            this.database.DP_Firma_serwisowa.Add(newEmail);
            this.textBox6.Text = "";

            this.database.SaveChanges();
        }
    }
}
