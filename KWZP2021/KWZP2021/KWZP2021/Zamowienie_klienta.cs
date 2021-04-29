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
    public partial class Zamowienie_klienta : Form
    {
        DrukarniaEntities database;
        public Zamowienie_klienta(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dvgZamowienie_klienta.DataSource = this.database.vDZ_Zamowienie_klienta.ToList();

        }

        private void initdvgZamowienieKlienta()
        {
            this.dvgZamowienie_klienta.DataSource = this.database.vDZ_Zamowienie_klienta.ToList();

        }

        private void dvgZamowienie_klienta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dvgZamowienie_klienta.DataSource = this.database.vDZ_Zamowienie_klienta.ToList();
        }

        private void Zamowienie_klienta_Load(object sender, EventArgs e)
        {

        }

        private void button1_nowe_zamowienie_Click(object sender, EventArgs e)
        {
            Dodaj_zamowienie_klienta dodaj_Zamowienie_Klienta = new Dodaj_zamowienie_klienta(this.database);
            dodaj_Zamowienie_Klienta.ShowDialog();
            initdvgZamowienieKlienta();
            
        }

        private void button1_Usun_zamowienie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć wybrane zamówienie?", "Uwaga, po zatwierdzeniu rekord zostanie trwale usunięty z bazy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dvgZamowienie_klienta.CurrentRow.Cells[0].Value);

                DZ_Zamowienie_klienta toRemove = this.database.DZ_Zamowienie_klienta.Where(zamowiene_klienta => zamowiene_klienta.Id_zamowienia == id).First();


                this.database.DZ_Zamowienie_klienta.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgZamowienieKlienta();
            }
        }

        private void dvgZamowienie_klienta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edytuj_zamowienie_klienta Edytuj = new Edytuj_zamowienie_klienta(this.database);
            Edytuj.ShowDialog();
        }

    }
}
