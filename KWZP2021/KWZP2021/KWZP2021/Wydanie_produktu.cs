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
            //dgvWydanieProduktu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
           // dgvWydanieProduktu.AutoResizeRowHeadersWidth(ColumnHeader.Equals=10);


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
            dgvWydanieProduktu.DataSource = database.vDM_Wydanie_produktu.Where(x => x.Numer_zamowienia.ToString().Equals(txtFindWydanieProduktu.Text) || x.Nazwisko_pracownika_wydajacego.Contains(txtFindWydanieProduktu.Text)).ToList();
        }

        private void dgvWydanieProduktu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerszczegolu = Convert.ToInt32(dgvWydanieProduktu.CurrentRow.Cells[0].Value);
            Szczegoly_wydania_produktu szczegoly = new Szczegoly_wydania_produktu(database, Decimal.ToInt32(numerszczegolu));
            szczegoly.Show();
        }

        private void txtFindWydanieProduktu_Enter(object sender, EventArgs e)
        {
            if (txtFindWydanieProduktu.Text == "Wyszukaj...")
            {
                txtFindWydanieProduktu.Text = "";
                initDataGridView();
            }
        }

        private void txtFindWydanieProduktu_Leave(object sender, EventArgs e)
        {
            if (txtFindWydanieProduktu.Text.Length == 0)
            {
                txtFindWydanieProduktu.ForeColor = Color.Gray;
                txtFindWydanieProduktu.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Italic);
                txtFindWydanieProduktu.Text = "Wyszukaj...";
                initDataGridView();
            }
        }

        private void Wydanie_produktu_Load(object sender, EventArgs e)
        {
            dgvWydanieProduktu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
