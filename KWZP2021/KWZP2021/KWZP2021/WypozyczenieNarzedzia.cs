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
    public partial class WypozyczenieNarzedzia : Form
    {
       public DrukarniaEntities database;

        public WypozyczenieNarzedzia(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvWypozyczenie.DataSource = this.database.vDM_Wypozyczenie_narzedzia.ToList();
            initDataGridView();
        }
        public void initDataGridView()
        {
            this.dgvWypozyczenie.DataSource = this.database.vDM_Wypozyczenie_narzedzia.ToList();

        }
        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            dgvWypozyczenie.DataSource = database.vDM_Wypozyczenie_narzedzia.Where(x => x.Nazwisko_pracownika_wypozyczajacego.Contains(txtFind.Text)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NoweWypozyczenie nowe = new NoweWypozyczenie(this.database);
            nowe.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*int id = Convert.ToInt32(dgvWypozyczenie.CurrentRow.Cells[0].Value);
            UsunNarzedzieZeSzczegolow usun = new UsunNarzedzieZeSzczegolow(this.database, Decimal.ToInt32(id));
            usun.ShowDialog();*/
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć narzędzie?", "Usuwanie narzędzia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWypozyczenie.CurrentRow.Cells[0].Value);

                DM_Wypozyczenie_narzedzia toRemove = this.database.DM_Wypozyczenie_narzedzia.Where(wypo => wypo.Id_wypozyczenia_narzedzia == id).First();

                this.database.DM_Wypozyczenie_narzedzia.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć narzędzia!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZwrotNarzedzi zwrot = new ZwrotNarzedzi(this.database);
            zwrot.ShowDialog();
        }

        private void dgvWypozyczenie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerwypozyczenia = Convert.ToInt32(dgvWypozyczenie.CurrentRow.Cells[0].Value);
            SzczegolyWypozyczenia szczegoly = new SzczegolyWypozyczenia(database, Decimal.ToInt32(numerwypozyczenia));
            szczegoly.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoweSzczegolyWypozyczeniaNarzedzia news = new NoweSzczegolyWypozyczeniaNarzedzia(this.database);
            news.ShowDialog();
        }

        private void WypozyczenieNarzedzia_Load(object sender, EventArgs e)
        {
            dgvWypozyczenie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWypozyczenie.DataSource = this.database.vDM_Wypozyczenie_narzedzia.ToList();
        }
    }
}
