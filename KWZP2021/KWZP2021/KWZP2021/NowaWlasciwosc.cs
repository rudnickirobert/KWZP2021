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
    public partial class NowaWlasciwosc : Form
    {
        DrukarniaEntities database;
        public NowaWlasciwosc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Wlasciwosc frm = (Wlasciwosc)Application.OpenForms["Wlasciwosc"];
            DM_Wlasciwosc newsnowy = new DM_Wlasciwosc();
            newsnowy.Nazwa_wlasciwosci = txtNew.Text;
            newsnowy.Jednostka_pomiarowa = txtNIP.Text;

            this.database.DM_Wlasciwosc.Add(newsnowy);
            this.database.SaveChanges();
            frm.dgvWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();
            this.Close();
        }
    }
}
