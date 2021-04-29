using System;
using System.Data;
using System.Linq;
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

            initCombobox();
            initDataGridView();
            this.cmbRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.cmbRodzajCzynnosci.DisplayMember = "Nazwa";
            this.cmbRodzajCzynnosci.ValueMember = "Id_rodzaj_czynnosci";
            this.dvgRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
        }
        private void initCombobox()
        {
            this.cmbRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.cmbRodzajCzynnosci.DisplayMember = "Nazwa";
            this.cmbRodzajCzynnosci.ValueMember = "Id_rodzaj_czynnosci";
        }

        private void initDataGridView()
        {
            this.dvgRodzajCzynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();

        }

        private void btnAddRodzajCzynnosci_Click(object sender, EventArgs e)
        {
            DP_Rodzaj_czynnosci newRodzajCzynnosci = new DP_Rodzaj_czynnosci();
            newRodzajCzynnosci.Nazwa = this.txtNewRodzajCzynnosci.Text;

            this.database.DP_Rodzaj_czynnosci.Add(newRodzajCzynnosci);
            this.database.SaveChanges();
            initCombobox();
            this.txtNewRodzajCzynnosci.Text = "";
            initDataGridView();
        }

        private void btnDeleteRodzajCzynnosci_Click(object sender, EventArgs e)
        {
            DialogBoxDelete d = new DialogBoxDelete();
            d.ShowDialog();

            if (d.DialogResult.Equals(DialogResult.Yes))
            {
                int id = Convert.ToInt32(this.dvgRodzajCzynnosci.CurrentRow.Cells[0].Value);

                DP_Rodzaj_czynnosci toRemove = this.database.DP_Rodzaj_czynnosci.Where(rodzaj_czynnosci => rodzaj_czynnosci.Id_rodzaj_czynnosci == id).First();

                this.database.DP_Rodzaj_czynnosci.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
                initCombobox();
            }
            else if (d.DialogResult.Equals(DialogResult.No))
            {
                d.Hide();
            }

        }

        private void Rodzaj_czynnosci_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}