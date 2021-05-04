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
    public partial class EdytujRodzajMaszyny : Form
    {
        DrukarniaEntities database;
        
        public EdytujRodzajMaszyny(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rodzaj_maszyny frm = (Rodzaj_maszyny)Application.OpenForms["Rodzaj_maszyny"];
            int row = Convert.ToInt32(frm.dgvRodzajMaszyny.CurrentRow.Index) + 1;
            DP_Rodzaj_maszyny toUpdate = this.database.DP_Rodzaj_maszyny.Where(maszyna => maszyna.Id_rodzaj_maszyny == row).First();
            toUpdate.Rodzaj_maszyny = txtRodzaj.Text;
            database.SaveChanges();
            frm.dgvRodzajMaszyny.DataSource = this.database.vDP_Rodzaj_maszyny.ToList();
            this.Close();
        }
    }
}
