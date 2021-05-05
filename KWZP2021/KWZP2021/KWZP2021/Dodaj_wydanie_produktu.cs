using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KWZP2021
{
    public partial class Dodaj_wydanie_produktu : Form
    {
        DrukarniaEntities database;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Dodaj_wydanie_produktu(DrukarniaEntities database)
        {
            InitializeComponent();

            this.database = database;
            this.cmbIdWydania.DataSource = this.database.DM_Magazyn_gotowych_produktow.ToList();
            this.cmbIdWydania.DisplayMember = "Id_magazynu_gotowych_produktow";
            this.cmbIdWydania.ValueMember = "Id_magazynu_gotowych_produktow";

            this.cmbPracownik.DataSource = this.database.DZ_Pracownik.ToList();
            this.cmbPracownik.DisplayMember = "Nazwisko";
            this.cmbPracownik.ValueMember = "Id_pracownika";
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewWlasciwoscMaterialu_Click(object sender, EventArgs e)
        {
            DM_Wydanie_produktu newWydanieProduktu = new DM_Wydanie_produktu();
            newWydanieProduktu.Id_magazyn_gotowych_produktow = Convert.ToInt32(cmbIdWydania.SelectedValue);
            newWydanieProduktu.Id_pracownika = Convert.ToInt32(cmbPracownik.SelectedValue);
            newWydanieProduktu.Data_i_godzina = Convert.ToDateTime(dtpDataWydania.Value);
            newWydanieProduktu.Uwagi = this.txtUwagi.Text;

            this.database.DM_Wydanie_produktu.Add(newWydanieProduktu);
            this.database.SaveChanges();
            this.txtUwagi.Text = "";

            var WydanieProduktuForm = Application.OpenForms.OfType<Wydanie_produktu>().Single();
            WydanieProduktuForm.initDataGridView();
            this.Close();
        }

    }
}
