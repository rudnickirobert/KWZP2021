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
    public partial class EdytujModelMaszyny : Form
    {
        DrukarniaEntities database;
        public EdytujModelMaszyny(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Model_maszyny frm = (Model_maszyny )Application.OpenForms["Model_maszyny"];
            int row = Convert.ToInt32(frm.dgvModelMaszyny.CurrentRow.Cells[0].Value) ;

            DP_Model_maszyny toUpdate = this.database.DP_Model_maszyny.Where(maszyna => maszyna.Id_model_maszyny == row).First();
            //DP_Rodzaj_maszyny toUpdate = this.database.DP_Rodzaj_maszyny.Where(maszyna => maszyna.Id_rodzaj_maszyny == row).First();
            //dgvWlasciwosc.Columns[0].Visible = false; kod do ukrywania id w posredniczacej
            toUpdate.Nazwa_modelu_maszyny = txtModel.Text;


            database.SaveChanges();
            frm.dgvModelMaszyny.DataSource = this.database.vDP_Model_maszyny.ToList();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
