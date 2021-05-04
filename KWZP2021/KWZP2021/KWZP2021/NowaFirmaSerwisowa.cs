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
    public partial class NowaFirmaSerwisowa : Form
    {
        DrukarniaEntities database;
        public NowaFirmaSerwisowa(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void buttonZapiszNowaFirma_Click(object sender, EventArgs e)
        {
            DP_Firma_serwisowa firma_serwisowa = new DP_Firma_serwisowa();
            firma_serwisowa.Nazwa_firmy = txtNazwa_Firmy.Text;
            firma_serwisowa.Adres = tAdres.Text;
            firma_serwisowa.Miasto = tMiasto.Text;
            firma_serwisowa.Kod_pocztowy = tKodpocztowy.Text;
            firma_serwisowa.Nr_tel = tNumertel.Text;
            firma_serwisowa.E_mail = tEmail.Text;

            this.database.DP_Firma_serwisowa.Add(firma_serwisowa);
            this.database.SaveChanges();
            this.Close();
        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            txtNazwa_Firmy.Text = "";
            tAdres.Text = "";
            tMiasto.Text = "";
            tKodpocztowy.Text = "";
            tNumertel.Text = "";
            tEmail.Text = "";
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
