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
    public partial class Szczegoly_wydania_produktu : Form
    {
        DrukarniaEntities database;
        public Szczegoly_wydania_produktu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

          //  this.txtProdukt.DataSource = this.database.DP_Produkt.ToList();
            this.txtProdukt.Text = "Nazwa_produktu";
          //  this.txtProdukt.ValueMember = "Id_produkt";
        }

        private void btnPreviousScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
