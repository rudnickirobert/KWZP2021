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
    public partial class AddProcesTechnologiczny : Form
    {
        DrukarniaEntities database;
        public AddProcesTechnologiczny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initDGV();
            this.dgvProcesTechnologiczny.DataSource = this.database.vDP_Proces_technologiczny.ToList();
        }
        public void initDGV()
        {
            dgvProcesTechnologiczny.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProcesTechnologiczny.DataSource = this.database.vDP_Proces_technologiczny.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcesDrukowania pd = new ProcesDrukowania(this.database);
            pd.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DP_Proces_technologiczny proces = new DP_Proces_technologiczny();
            proces.Nazwa = this.txtNazwaProces.Text;
            this.database.DP_Proces_technologiczny.Add(proces);
            this.database.SaveChanges();
            this.txtNazwaProces.Text = "";
            initDGV();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*int id = Convert.ToInt32(dgvWypozyczenie.CurrentRow.Cells[0].Value);
           UsunNarzedzieZeSzczegolow usun = new UsunNarzedzieZeSzczegolow(this.database, Decimal.ToInt32(id));
           usun.ShowDialog();*/
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć proces technologiczny?", "Usuwanie proces", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvProcesTechnologiczny.CurrentRow.Cells[0].Value);

                DP_Proces_technologiczny toRemove = this.database.DP_Proces_technologiczny.Where(wypo => wypo.Id_proces_technologiczny == id).First();

                this.database.DP_Proces_technologiczny.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDGV();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć procesu");
            }
        }
    }
}
