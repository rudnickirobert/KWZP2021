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
    public partial class EdytujWlasciwosc : Form
    {
        DrukarniaEntities database;

        public EdytujWlasciwosc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Wlasciwosc frm = (Wlasciwosc)Application.OpenForms["Wlasciwosc"];
            int row = Convert.ToInt32(frm.dgvWlasciwosc.CurrentRow.Cells[0].Value); ;
            DM_Wlasciwosc toUpdate = this.database.DM_Wlasciwosc.Where(wlasc => wlasc.Id_wlasciwosc == row).First();
            toUpdate.Nazwa_wlasciwosci = txtNew.Text;
            toUpdate.Jednostka_pomiarowa = txtNIP.Text;
            database.SaveChanges();
            frm.dgvWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
