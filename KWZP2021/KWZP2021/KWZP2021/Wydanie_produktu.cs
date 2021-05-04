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
    public partial class Wydanie_produktu : Form
    {
        DrukarniaEntities database;
        public Wydanie_produktu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvWydanieProduktu.DataSource = this.database.vDM_Wydanie_produktu.ToList();
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvWydanieProduktu.DataSource = this.database.vDM_Wydanie_produktu.ToList();
        }

        private void btnAddNewWydanieProduktu_Click(object sender, EventArgs e)
        {
            Dodaj_wydanie_produktu dodajWydanieProduktu = new Dodaj_wydanie_produktu(this.database);
            dodajWydanieProduktu.ShowDialog();
        }

        private void txtFindWydanieProduktu_TextChanged(object sender, EventArgs e)
        {
          //  dgvWydanieProduktu.DataSource = database.vDM_Wydanie_produktu.Where(x => x.Numer_zamowienia.Contains(txtFindWydanieProduktu.Text) == (string) || x.C_Nazwisko_pracownika_wydajacego.Contains(txtFindWydanieProduktu.Text)).ToList();
        }

        private void dgvWydanieProduktu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Szczegoly_wydania_produktu szczegolyWydaniaProduktu = new Szczegoly_wydania_produktu(this.database);
            szczegolyWydaniaProduktu.txtNrWydania.Text = dgvWydanieProduktu.CurrentRow.Cells[0].Value.ToString();
            szczegolyWydaniaProduktu.txtProdukt.Text = dgvWydanieProduktu.CurrentRow.Cells[1].Value.ToString();
            szczegolyWydaniaProduktu.txtQuantity.Text = dgvWydanieProduktu.CurrentRow.Cells[2].Value.ToString();
            szczegolyWydaniaProduktu.ShowDialog();
        }
    }
}
