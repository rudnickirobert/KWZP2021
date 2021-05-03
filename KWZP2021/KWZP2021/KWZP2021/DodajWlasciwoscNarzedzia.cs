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
    public partial class DodajWlasciwoscNarzedzia : Form
    {
        DrukarniaEntities database;
        public DodajWlasciwoscNarzedzia(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.cmbNazwa.DataSource = this.database.DM_Narzedzie.ToList();
            this.cmbNazwa.DisplayMember = "Nazwa";
            this.cmbNazwa.ValueMember = "Id_narzedzia";
            this.cmbWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.cmbWlasciwosc.DisplayMember = "Nazwa_wlasciwosci";
            this.cmbWlasciwosc.ValueMember = "Id_wlasciwosc";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //WlasciwoscNarzedzia frm = (WlasciwoscNarzedzia)Application.OpenForms["WlasciwoscNarzedzia"];
            DM_Parametr_narzedzia news = new DM_Parametr_narzedzia();
            news.Id_narzedzia = Convert.ToInt32(cmbNazwa.SelectedValue);
            news.Id_wlasciwosc = Convert.ToInt32(cmbWlasciwosc.SelectedValue);
            news.Wartosc = txtWartosc.Text;

            this.database.DM_Parametr_narzedzia.Add(news);
            this.database.SaveChanges();
            //frm.dgvWlasciwosc.DataSource = this.database.vDM_Parametr_narzedzia.ToList();
            var MaterialForm = Application.OpenForms.OfType<WlasciwoscNarzedzia>().Single();
            MaterialForm.initDataGridView();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
