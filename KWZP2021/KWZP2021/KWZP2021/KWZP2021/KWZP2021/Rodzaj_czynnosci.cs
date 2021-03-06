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
    public partial class Rodzaj_czynnosci : Form
    {
        DrukarniaEntities database;
        public Rodzaj_czynnosci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.cmbRodzajCzynnosci.DisplayMember = "Nazwa";
            this.cmbRodzajCzynnosci.ValueMember = "Id_rodzaj_czynnosci";

            this.dvgRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();

            //initCombobox();
            // initDataGridView();
        }
        private void initCombobox()
        {
            this.cmbRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.cmbRodzajCzynnosci.DisplayMember = "Nazwa";
        }

        private void initDataGridView()
        {
            this.dvgRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();

        }

        private void btnAddRodzajCzynnosci_Click(object sender, EventArgs e)
        {
            DP_Rodzaj_czynnosci newRodzajCzynnosci = new DP_Rodzaj_czynnosci();
            newRodzajCzynnosci.nazwa = this.txtNewRodzajCzynnosci.Text;

            this.database.DP_Rodzaj_czynnosci.Add(newRodzajCzynnosci);
            this.database.SaveChanges();
            initCombobox();
            this.txtNewRodzajCzynnosci.Text = "";
            initDataGridView();
        }

        private void btnDeleteRodzajCzynnosci_Click(object sender, EventArgs e)
        {
          
                int id = Convert.ToInt32(this.dvgRodzajCzynnosci.CurrentRow.Cells[0].Value);

                DP_Rodzaj_czynnosci toRemove = this.database.DP_Rodzaj_czynnosci.Where(rodzaj_czynnosci => rodzaj_czynnosci.Id_rodzaj_czynnosci == id).First();

                this.database.DP_Rodzaj_czynnosci.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
          
        }

        private void dvgRodzajCzynnosci_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(this.dvgRodzajCzynnosci.CurrentRow.Cells[0].Value);

            DP_Rodzaj_czynnosci toRemove = this.database.DP_Rodzaj_czynnosci.Where(rodzaj_czynnosci => rodzaj_czynnosci.Id_rodzaj_czynnosci == id).First();

            toRemove.nazwa = txtNewRodzajCzynnosci.Text; // UPDATE

            this.database.SaveChanges();
            initDataGridView();
        }
        private void Rodzaj_czynnosci_Load(object sender, EventArgs e)
        {

        }
    }
}