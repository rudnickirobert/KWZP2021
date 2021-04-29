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
    public partial class Klienci : Form
    {
        DrukarniaEntities database;
        public Klienci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            /*this.comboBox1.DataSource = this.database.DZ_Stanowisko.ToList();
            this.comboBox1.DisplayMember = "Stanowisko";
            this.comboBox1.ValueMember = "Id_stanowiska";*/

            this.dvgKlient.DataSource = this.database.vDZ_Klient.ToList();
            

        }

        private void Klienci_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
         
        }


        private void dvgKlient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dvgKlient.DataSource = this.database.vDZ_Klient.ToList();
        }
      
        private void buttonNowyKlient_Click(object sender, EventArgs e)
        {
            Nowy_klient nowy_klient = new Nowy_klient(this.database);
            nowy_klient.ShowDialog();
            initdvgKlient();
        }

        private void buttonWyszukajKlienta_Click(object sender, EventArgs e)
        {
            int firma = Convert.ToInt32(this.dvgKlient.CurrentRow.Cells[0].Value);

            DZ_Klient toUpgrade = this.database.DZ_Klient.Where(nazwa_firmy => nazwa_firmy.Id_klienta == firma).First();

            toUpgrade.Nazwa_firmy = textBox1.Text;

            this.database.SaveChanges();
        }
        private void initdvgKlient()
        {
            this.dvgKlient.DataSource = this.database.vDZ_Klient.ToList();

        }
        private void dvgKlient_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dvgKlient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Konkretny_klient konkretny_klient = new Konkretny_klient(this.database);
            konkretny_klient.ShowDialog();
            initdvgKlient();
        }

        private void buttonUsunKlienta_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć klienta?", "Usuwanie klientów", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dvgKlient.CurrentRow.Cells[0].Value);

            DZ_Klient toRemove = this.database.DZ_Klient.Where(klient => klient.Id_klienta == id).First();


            this.database.DZ_Klient.Remove(toRemove); // DELETE

            this.database.SaveChanges();
            initdvgKlient();
            }
        }
    }
}


