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
    public partial class NoweSzczegolyDostawyMaterialu : Form
    {
        DrukarniaEntities database;

        public NoweSzczegolyDostawyMaterialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.CmbNazwamaterialu.DataSource = this.database.DM_Material.ToList();
            this.CmbNazwamaterialu.DisplayMember = "Nazwa";
            this.CmbNazwamaterialu.ValueMember = "Id_materialu";
            this.cmbNumerdostawcy.DataSource = this.database.DM_Dostawca.ToList();
            this.cmbNumerdostawcy.DisplayMember = "Nazwa";
            this.cmbNumerdostawcy.ValueMember = "id_dostawcy";
            this.cmbNumerzamowienia.DataSource = this.database.DZ_Zamowienie_zewn.ToList();
            this.cmbNumerzamowienia.DisplayMember = "Id_zamowienia_zewn";
            this.cmbNumerzamowienia.ValueMember = "id_zamowienia_zewn";
            this.cmbNumerdostawy.DataSource = this.database.DM_Dostawa_materialu.ToList();
            this.cmbNumerdostawy.DisplayMember = "Id_dostawy";
            this.cmbNumerdostawy.ValueMember = "Id_dostawy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DM_Sklad_dostawy_materialu material = new DM_Sklad_dostawy_materialu();
            material.Id_dostawy = Convert.ToInt32(cmbNumerdostawy.SelectedValue);
            material.Id_dostawcy = Convert.ToInt32(cmbNumerdostawcy.SelectedValue);
            material.Id_materialu = Convert.ToInt32(CmbNazwamaterialu.SelectedValue);
            material.Id_zamowienie_zewn = Convert.ToInt32(cmbNumerzamowienia.SelectedValue);
            material.Ilosc = Convert.ToInt32(txtIlosc.Text);
            material.Cena_jednostkowa_materialu = Convert.ToInt32(txtCena.Text);
            this.database.DM_Sklad_dostawy_materialu.Add(material);
            this.database.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
