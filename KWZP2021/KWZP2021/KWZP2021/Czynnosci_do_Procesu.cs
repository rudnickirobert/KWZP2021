using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Czynnosci_do_Procesu : Form
    {
        private DrukarniaEntities database;

        public Czynnosci_do_Procesu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.comboBox1.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_rodzaj_czynnosci";

            this.GDV_czynnosci.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();

        }



        private void btn_add_czynnosc_Click(object sender, EventArgs e)
        {
            DP_Rodzaj_czynnosci newCzynnosc = new DP_Rodzaj_czynnosci();
            newCzynnosc.Nazwa = this.textBox1.Text;

            this.database.DP_Rodzaj_czynnosci.Add(newCzynnosc); // CREATE
            this.database.SaveChanges();
            initCombobox();
            this.textBox1.Text = "";
        }
        private void initCombobox()
        {
            this.comboBox1.DataSource = this.database.DP_Rodzaj_czynnosci.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_rodzaj_czynnosci";
        }

        private void initDataGridView()
        {
            this.GDV_czynnosci.DataSource = this.database.DP_Rodzaj_czynnosci;
        }


        private void btn_akt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.GDV_czynnosci.CurrentRow.Cells[0].Value);

            DP_Rodzaj_czynnosci toRemove = this.database.DP_Rodzaj_czynnosci.Where(nazwa => nazwa.Id_rodzaj_czynnosci == id).First();

            toRemove.Nazwa = textBox1.Text; // UPDATE

            //this.database.DZ_Stanowisko.Remove(toRemove); // DELETE

            this.database.SaveChanges();
            initDataGridView();
        }

        private void btn_del_czynnosc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.GDV_czynnosci.CurrentRow.Cells[0].Value);

            DP_Rodzaj_czynnosci toRemove = this.database.DP_Rodzaj_czynnosci.Where(nazwa => nazwa.Id_rodzaj_czynnosci == id).First();

            // toRemove.nr_seryjny = toRemove.nr_seryjny + " testowy"; // UPDATE

            this.database.DP_Rodzaj_czynnosci.Remove(toRemove); // DELETE

            this.database.SaveChanges();
            initDataGridView();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Czynnosci_do_Procesu czynnosci_Do_Procesu = new Czynnosci_do_Procesu(this.database);
            czynnosci_Do_Procesu.ShowDialog();
        }
    }
}
