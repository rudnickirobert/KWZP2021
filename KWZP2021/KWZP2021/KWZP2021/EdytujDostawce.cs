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
    public partial class EdytujDostawce : Form
    {
        DrukarniaEntities database;

        public EdytujDostawce(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dostawcy frm = (Dostawcy)Application.OpenForms["Dostawcy"];
            int row = Convert.ToInt32(frm.dgvDostawca.CurrentRow.Cells[0].Value); ;
            DM_Dostawca toUpdate = this.database.DM_Dostawca.Where(dostawce => dostawce.Id_dostawcy == row).First();
            toUpdate.Nazwa = txtNew.Text;
            toUpdate.NIP = txtNIP.Text;
            toUpdate.Uwagi = txtUwagi.Text;
            database.SaveChanges();
            frm.dgvDostawca.DataSource = this.database.vDM_Dostawca.ToList();
            this.Close();
        }
    }
}
