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
    public partial class ProcesTechnologiczny : Form
    {
        DrukarniaEntities database;
        public ProcesTechnologiczny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initDataGridView();
        }

        private void btnCzynnosci_Click(object sender, EventArgs e)
        {
            Rodzaj_czynnosci rodzaj_czynnosci = new Rodzaj_czynnosci(this.database);
            rodzaj_czynnosci.ShowDialog();
        }
        private void initDataGridView()
        {
            dgv_proces_wydruk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_proces_wydruk.DataSource = this.database.vDP_Proces_Techno1.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dzial_produkcji dp = new Dzial_produkcji(this.database);
            dp.Show();
        }

        private void btnWydruk_Click(object sender, EventArgs e)
        {
            KreatorWydruk kw = new KreatorWydruk(this.database);
            kw.ShowDialog();
        }
    }
}
