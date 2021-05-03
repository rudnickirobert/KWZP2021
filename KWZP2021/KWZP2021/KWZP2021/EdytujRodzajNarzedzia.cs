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
    public partial class EdytujRodzajNarzedzia : Form
    {
        DrukarniaEntities database;
        public EdytujRodzajNarzedzia(DrukarniaEntities database)
        {
            this.database = database;

            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rodzaj_narzedzia frm = (Rodzaj_narzedzia)Application.OpenForms["Rodzaj_narzedzia"];
            int row = Convert.ToInt32(frm.dgvRodzaj.CurrentRow.Cells[0].Value); ;
            DM_Rodzaj_narzedzia toUpdate = this.database.DM_Rodzaj_narzedzia.Where(narzedzie => narzedzie.Id_rodzaj_narzedzia == row).First();
            toUpdate.Nazwa = txtRodzaj.Text;
            

            database.SaveChanges();
            frm.dgvRodzaj.DataSource = this.database.vDM_Rodzaj_narzedzia.ToList();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
