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
    public partial class Nowe_szczegoly_dostawy_czesci : Form
    {
        DrukarniaEntities database;
        public Nowe_szczegoly_dostawy_czesci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.CmbNazwaczesci.DataSource = this.database.DM_Czesc.ToList();
            this.CmbNazwaczesci.DisplayMember = "Nazwa";
            this.CmbNazwaczesci.ValueMember = "Id_czesci";
            this.cmbNumerdostawcy.DataSource = this.database.DM_Dostawca.ToList();
            this.cmbNumerdostawcy.DisplayMember = "Nazwa";
            this.cmbNumerdostawcy.ValueMember = "id_dostawcy";
            this.cmbNumerzamowienia.DataSource = this.database.DZ_Zamowienie_zewn.ToList();
            this.cmbNumerzamowienia.DisplayMember = "Id_zamowienia_zewn";
            this.cmbNumerzamowienia.ValueMember = "id_zamowienia_zewn";
            this.cmbNumerdostawy.DataSource = this.database.DM_Dostawa_czesci.ToList();
            this.cmbNumerdostawy.DisplayMember = "Id_dostawy";
            this.cmbNumerdostawy.ValueMember = "Id_dostawy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DM_Sklad_dostawy_czesci czesc = new DM_Sklad_dostawy_czesci();
            czesc.Id_dostawy = Convert.ToInt32(cmbNumerdostawy.SelectedValue);
            czesc.Id_dostawcy = Convert.ToInt32(cmbNumerdostawcy.SelectedValue);
            czesc.Id_czesci = Convert.ToInt32(CmbNazwaczesci.SelectedValue);
            czesc.Id_zamowienie_zewn = Convert.ToInt32(cmbNumerzamowienia.SelectedValue);
            czesc.Ilosc = Convert.ToInt32(txtIlosc.Text);
            czesc.Cena_jednostkowa_czesci = Convert.ToInt32(txtCena.Text);
            this.database.DM_Sklad_dostawy_czesci.Add(czesc);
            this.database.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
