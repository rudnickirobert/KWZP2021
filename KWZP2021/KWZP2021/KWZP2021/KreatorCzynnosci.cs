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
    public partial class KreatorCzynnosci : Form
    {
        DrukarniaEntities database;
        public KreatorCzynnosci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;


            initCMB();
            initDGV();


            this.cmbPOczynnosc.DataSource = this.database.DP_Po_proc_czynnosc.ToList();
            this.cmbPOczynnosc.DisplayMember = "Id_po_proc_czynnosci";
            this.cmbPOczynnosc.ValueMember = "Id_po_proc_czynnosci";


            this.cmbCzynnosc.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.cmbCzynnosc.DisplayMember = "Nazwa";
            this.cmbCzynnosc.ValueMember = "Id_rodzaj_czynnosci";

            dgvCzynnosci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCzynnosci.DataSource = this.database.vDP_Po_proc_czynnosc.ToList();
        }

        private void btnWydruk_Click(object sender, EventArgs e)
        {
            Rodzaj_czynnosci rodzaj_czynnosci = new Rodzaj_czynnosci(this.database);
            rodzaj_czynnosci.ShowDialog();
        }
        public void initCMB()
        {

            this.cmbPOczynnosc.DataSource = this.database.DP_Po_proc_czynnosc.ToList();
            this.cmbPOczynnosc.DisplayMember = "Id_po_proc_czynnosci";
            this.cmbPOczynnosc.DisplayMember = "Czas_zamierzony";
            this.cmbPOczynnosc.ValueMember = "Id_po_proc_czynnosci";


            this.cmbCzynnosc.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.cmbCzynnosc.DisplayMember = "Nazwa";
            this.cmbCzynnosc.ValueMember = "Id_rodzaj_czynnosci";
        }
        public void initDGV()
        {
            dgvCzynnosci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCzynnosci.DataSource = this.database.vDP_Po_proc_czynnosc.ToList();
        }

    }
}
