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
    public partial class Edytuj_zamowienie_klienta : Form
    {
        DrukarniaEntities database;
        public Edytuj_zamowienie_klienta(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.comboBox1_nazwa_firmy.DataSource = this.database.DZ_Klient.ToList();
            this.comboBox1_nazwa_firmy.DisplayMember = "Nazwa_firmy";
            this.comboBox1_nazwa_firmy.ValueMember = "Id_klienta";

            this.comboBox2_Pracownik.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox2_Pracownik.DisplayMember = "Nazwisko";
            this.comboBox2_Pracownik.ValueMember = "Id_pracownika";
        }

        private void button2_Powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edytuj_zamowienie_klienta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Zapisz_Click(object sender, EventArgs e)
        {

            Zamowienie_klienta frm = (Zamowienie_klienta)Application.OpenForms["Zamowienie_klienta"];
            int row = Convert.ToInt32(frm.dvgZamowienie_klienta.CurrentRow.Cells[0].Value);
            DZ_Zamowienie_klienta toUpdate = this.database.DZ_Zamowienie_klienta.Where(zamowienie_klienta => zamowienie_klienta.Id_zamowienia == row).First();

            toUpdate.Id_klienta = Convert.ToInt32(comboBox1_nazwa_firmy.SelectedValue); // UPDATE
            toUpdate.Id_pracownika = Convert.ToInt32(comboBox2_Pracownik.SelectedValue); // UPDATE
            toUpdate.Data_zamowienia = dateTimePicker1_Data_zam.Value; // UPDATE
            toUpdate.Oczekiwany_termin_wykonania = dateTimePicker2_oczekiwany_termin.Value; // UPDATE
            this.database.SaveChanges();
            frm.dvgZamowienie_klienta.DataSource = this.database.vDZ_Zamowienie_klienta.ToList();
            this.Close();
        }
    }
}
