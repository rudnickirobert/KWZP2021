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
    public partial class Zuzyte_narzedzie : Form
    {
        DrukarniaEntities database;
        public DataGridView DataGridView;
        public Zuzyte_narzedzie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            initDataGridView();
        }
        private void initDataGridView()
        {
            this.dgvZuzyteNarzedzia.DataSource = this.database.vDM_Zuzyte_narzedzie.ToList();
        }

        private void btnZuzyteNarzedziaPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Narzedzie narzedzie = new Narzedzie(this.database);
            narzedzie.ShowDialog();
        }

        private void txtZuzyteNarzedziaWyszukaj_TextChanged(object sender, EventArgs e)
        {
            dgvZuzyteNarzedzia.DataSource = database.vDM_Zuzyte_narzedzie.Where(x => x.Nazwa_narzedzia.Contains(txtZuzyteNarzedziaWyszukaj.Text)).ToList();
        }

        private void btnDodajZuzyteNarzedzia_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dodaj_zuzyte_narzedzie dodajzuzytenarzedzie = new Dodaj_zuzyte_narzedzie(this.database);
            dodajzuzytenarzedzie.ShowDialog();
        }
    }
}
