using System;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Dzial_zarzadzania : Form
    {
        DrukarniaEntities database;
        public Dzial_zarzadzania(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

         
        }
    
        private void Dzial_zarzadzania_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stanowiska stanowiska = new Stanowiska(this.database);
            stanowiska.ShowDialog();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Klienci klienci = new Klienci(this.database);
            klienci.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zatrudnienie zatrudnienie = new Zatrudnienie(this.database);
            zatrudnienie.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pracownicy pracownicy = new Pracownicy(this.database);
            pracownicy.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Oplaty_firmy oplaty_firmy = new Oplaty_firmy(this.database);
            oplaty_firmy.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Obsluga_klienta obsluga_klienta = new Obsluga_klienta(this.database);
            obsluga_klienta.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak bilansu do wyświetlenia", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Archiwum archiwum = new Archiwum(this.database);
            archiwum.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_zamowienia_klienta_Click(object sender, EventArgs e)
        {
            Zamowienie_klienta zamowienie_klienta = new Zamowienie_klienta(this.database);
            zamowienie_klienta.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Plik plik = new Plik(this.database);
            plik.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StatusZamowienia status = new StatusZamowienia(this.database);
            status.ShowDialog();
        }

        private void button10_zamowienia_wewnetrzne_Click(object sender, EventArgs e)
        {
            ZamowienieZewn ZamZewn = new ZamowienieZewn(this.database);
            ZamZewn.ShowDialog();
        }
    }
}
