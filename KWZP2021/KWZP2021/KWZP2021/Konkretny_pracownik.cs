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
    public partial class Konkretny_pracownik : Form
    {
        DrukarniaEntities database;
        public Konkretny_pracownik(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void Konkretny_pracownik_Load(object sender, EventArgs e)
        {

        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            
               
                txtImie2.Text = "";
                txtNazwisko2.Text = "";
                txtAdres2.Text = "";
                txtMiasto2.Text = "";
                txtKod_Pocztowy2.Text = "";
                txtEmail2.Text = "";
                txtTelefon2.Text = "";
                txtNumer_Rachunku2.Text = "";
            txtData2.Text = "";


        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
