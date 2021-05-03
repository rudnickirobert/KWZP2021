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
    public partial class EdytujWlasciwoscNarzedzia : Form
    {
        DrukarniaEntities database;

        public EdytujWlasciwoscNarzedzia(DrukarniaEntities database)
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
            WlasciwoscNarzedzia frm = (WlasciwoscNarzedzia)Application.OpenForms["WlasciwoscNarzedzia"];
            int row = Convert.ToInt32(frm.dgvWlasciwosc.CurrentRow.Cells[0].Value); ;
            DM_Parametr_narzedzia toUpdate = this.database.DM_Parametr_narzedzia.Where(narzedzie => narzedzie.Id_parametru == row).First();
            toUpdate.Id_narzedzia = Convert.ToInt32(cmbNazwa.SelectedValue);
            toUpdate.Id_wlasciwosc = Convert.ToInt32(cmbWlasciwosc.SelectedValue);
            toUpdate.Wartosc = txtWartosc.Text;
            

            database.SaveChanges();
            frm.dgvWlasciwosc.DataSource = this.database.vDM_Parametr_narzedzia.ToList();
            this.Close();
        }
    }
}
