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
    public partial class Edytuj_firma_serwisowa : Form
    {
        DrukarniaEntities database;
        public Edytuj_firma_serwisowa(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
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

        private void buttonZapiszNowaFirma_Click(object sender, EventArgs e)
        {
            FirmaSerwisowa frm = (FirmaSerwisowa)Application.OpenForms["FirmaSerwisowa"];
            int row = Convert.ToInt32(frm.dgvFirma.CurrentRow.Cells[0].Value);
            DP_Firma_serwisowa toUpdate = this.database.DP_Firma_serwisowa.Where(firmaserw => firmaserw.Id_firma_serwisowa == row).First();

            toUpdate.Nazwa_firmy = txtNazwa_Firmy.Text; // UPDATE
            toUpdate.Adres = tAdres.Text; // UPDATE
            toUpdate.Miasto = tMiasto.Text; // UPDATE
            toUpdate.Kod_pocztowy = tKodpocztowy.Text; // UPDATE
            toUpdate.Nr_tel = tNumertel.Text; // UPDATE
            toUpdate.E_mail = tEmail.Text; // UPDATE
          
            frm.dgvFirma.DataSource = this.database.vDP_Firma_serwisowa.ToList();

            this.database.SaveChanges();
            this.Close();
        }
    }
}
