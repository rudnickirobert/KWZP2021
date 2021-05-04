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
    public partial class Dodaj_szczegol_wydania_produktu : Form
    {
        DrukarniaEntities database;
        public Dodaj_szczegol_wydania_produktu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbNazwaProduktu.DataSource = this.database.DP_Produkt.ToList();
            this.cmbNazwaProduktu.DisplayMember = "Nazwa_produktu";
            this.cmbNazwaProduktu.ValueMember = "Id_produkt";

        }

        private void btnAddNewSzczegol_Click(object sender, EventArgs e)
        {
            DM_Szczegoly_wydania_produktu newSzczegol = new DM_Szczegoly_wydania_produktu();
            newSzczegol.Id_wydania = Convert.ToInt32(txtIdWydania.Text);
            newSzczegol.Id_produkt = Convert.ToInt32(cmbNazwaProduktu.SelectedValue);
            newSzczegol.Ilosc = Convert.ToInt32(txtQuantity.Text);

            this.database.DM_Szczegoly_wydania_produktu.Add(newSzczegol);
            this.database.SaveChanges();
            this.txtQuantity.Text = "";

            var MaterialForm = Application.OpenForms.OfType<Szczegoly_wydania_produktu>().Single();
            MaterialForm.initDataGridView(1);
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
