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
    public partial class Konkretne_zatrudnienie : Form
    {
        DrukarniaEntities database;
        public Konkretne_zatrudnienie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            dataZwolnienia1.CustomFormat = " ";
            dataZwolnienia1.Format = DateTimePickerFormat.Custom;
            //this.cmbPracownik.DataSource = this.database.DZ_Pracownik.ToList();
            //this.cmbPracownik.DisplayMember = "Nazwisko";
            //this.cmbPracownik.ValueMember = "Id_pracownika";

            this.cmbStanowisko1.DataSource = this.database.DZ_Stanowisko.ToList();
            this.cmbStanowisko1.DisplayMember = "Stanowisko";
            this.cmbStanowisko1.ValueMember = "Id_stanowiska";

            this.cmbDzial1.DataSource = this.database.DZ_Dzial.ToList();
            this.cmbDzial1.DisplayMember = "Dzial";
            this.cmbDzial1.ValueMember = "Id_dzialu";

            this.cmbEtat1.DataSource = this.database.DZ_Etat.ToList();
            this.cmbEtat1.DisplayMember = "Etat";
            this.cmbEtat1.ValueMember = "Id_etatu";

            this.cmbRodzaj_umowy1.DataSource = this.database.DZ_Rodzaj_umowy.ToList();
            this.cmbRodzaj_umowy1.DisplayMember = "Rodzaj_umowy";
            this.cmbRodzaj_umowy1.ValueMember = "Id_rodzaj_umowy";
        }

        private void lblNowyKlient_Click(object sender, EventArgs e)
        {

        }

        private void Konkretne_zatrudnienie_Load(object sender, EventArgs e)
        {

        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapiszNowegoKlienta_Click(object sender, EventArgs e)
        {
            Zatrudnienie zat = (Zatrudnienie)Application.OpenForms["Zatrudnienie"];
            int row = Convert.ToInt32(zat.dgvZatrudnienie.CurrentRow.Cells[0].Value);
            DZ_Zatrudnienie toUpdate = this.database.DZ_Zatrudnienie.Where(zatrudnienie => zatrudnienie.Id_zatrudnienia == row).First();

           //toUpdate.Id_pracownika = Convert.ToInt32(cmbPracownik1.SelectedValue); // UPDATE
            toUpdate.Id_stanowiska = Convert.ToInt32(cmbStanowisko1.SelectedValue); // UPDATE
            toUpdate.Id_dzialu = Convert.ToInt32(cmbDzial1.SelectedValue); // UPDATE
            toUpdate.Id_etatu = Convert.ToInt32(cmbEtat1.SelectedValue); // UPDATE
            toUpdate.Id_rodzaj_umowy = Convert.ToInt32(cmbRodzaj_umowy1.SelectedValue); // UPDATE
            toUpdate.Data_zatrudnienia = Convert.ToDateTime(dataZatrudnienia1.Value); // UPDATE
            toUpdate.Data_zwolnienia = Convert.ToDateTime(dataZwolnienia1.Value); // UPDATE
            zat.dgvZatrudnienie.DataSource = this.database.vDZ_Zatrudnienie.ToList();
            this.database.SaveChanges();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            
            cmbStanowisko1.Text = "";
            cmbDzial1.Text = "";
            cmbEtat1.Text = "";
            cmbRodzaj_umowy1.Text = "";
            dataZatrudnienia1.CustomFormat = " ";
            dataZatrudnienia1.Format = DateTimePickerFormat.Custom;
            dataZwolnienia1.CustomFormat = " ";
            dataZwolnienia1.Format = DateTimePickerFormat.Custom;
        }
    }
}
