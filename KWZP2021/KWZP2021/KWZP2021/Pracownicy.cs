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
    public partial class Pracownicy : Form
    {
        DrukarniaEntities database;
        public Pracownicy(DrukarniaEntities database)
        {
            
            InitializeComponent();
            this.database = database;
            initdvgPracownik();

        }
        private void dvgPracownik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dvgPracownik.DataSource = this.database.vDZ_Pracownik.ToList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
       public void initdvgPracownik()
        {
            this.dvgPracownik.DataSource = this.database.vDZ_Pracownik.ToList();

        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dvgPracownik.DataSource = database.vDZ_Pracownik.Where(x => x.Nazwisko.Contains(textBox1.Text) || x.Imiê.Contains(textBox1.Text)).ToList();
        }

        private void dvgPracownik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Konkretny_pracownik konkretny_pracownik = new Konkretny_pracownik(this.database);
            konkretny_pracownik.txtImie2.Text = dvgPracownik.CurrentRow.Cells[1].Value.ToString();
            konkretny_pracownik.txtNazwisko2.Text = dvgPracownik.CurrentRow.Cells[2].Value.ToString();
            konkretny_pracownik.txtAdres2.Text = dvgPracownik.CurrentRow.Cells[4].Value.ToString();
            konkretny_pracownik.txtMiasto2.Text = dvgPracownik.CurrentRow.Cells[5].Value.ToString();
            konkretny_pracownik.txtKod_Pocztowy2.Text = dvgPracownik.CurrentRow.Cells[6].Value.ToString();
            konkretny_pracownik.txtEmail2.Text = dvgPracownik.CurrentRow.Cells[3].Value.ToString();
            konkretny_pracownik.txtTelefon2.Text = dvgPracownik.CurrentRow.Cells[8].Value.ToString();
            konkretny_pracownik.txtNumer_Rachunku2.Text = dvgPracownik.CurrentRow.Cells[9].Value.ToString();
            konkretny_pracownik.dateTimePicker1.Value = Convert.ToDateTime(dvgPracownik.CurrentRow.Cells[7].Value);

            //database.DZ_Klient.Add(konkretny_klient);
            //database.SaveChanges();
            //this.Close();
            konkretny_pracownik.ShowDialog();
            initdvgPracownik();
        }

        private void buttonWyszukajPracownika_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;

            dvgPracownik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dvgPracownik.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;

                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void buttonUsunPracownika_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć pracownika", "Usuwanie pracowników", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dvgPracownik.CurrentRow.Cells[0].Value);

                DZ_Pracownik toRemove = this.database.DZ_Pracownik.Where(pracownik => pracownik.Id_pracownika == id).First();


                this.database.DZ_Pracownik.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgPracownik();
            }
        }

        private void buttonNowyPracownik_Click(object sender, EventArgs e)
        {
            Nowy_pracownik nowy_pracownik = new Nowy_pracownik(this.database);
            nowy_pracownik.ShowDialog();
            initdvgPracownik();
        }
    }
}
