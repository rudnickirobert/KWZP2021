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
    public partial class DodajCzesc : Form
    {
        DrukarniaEntities database;

        public DodajCzesc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAnulujDodanieCzesci_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Czesc czesc = new Czesc(this.database);
            czesc.ShowDialog();
        }

        private void btnDodajCzesc_Click(object sender, EventArgs e)
        {
            DM_Czesc newCzesc = new DM_Czesc();
            newCzesc.Nazwa = txtDodajCzescNazwa.Text;
            newCzesc.Ilosc_poczatkowa = Convert.ToInt32(txtDodajCzescIlosc.Text);
            newCzesc.Id_model_maszyny = Convert.ToInt32(txtModelMaszyny.Text);

            this.database.DM_Czesc.Add(newCzesc);
            database.SaveChanges();
            Czesc czesc = new Czesc(this.database);
            czesc.ShowDialog();
            this.Close();
        }
    }
}
