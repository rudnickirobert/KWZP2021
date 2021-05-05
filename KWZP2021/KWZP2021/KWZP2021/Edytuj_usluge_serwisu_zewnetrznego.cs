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
    public partial class Edytuj_usluge_serwisu_zewnetrznego : Form


    {
        DrukarniaEntities database;
        public Edytuj_usluge_serwisu_zewnetrznego(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Uslugi_serwisu_zewnetrznego frm = (Uslugi_serwisu_zewnetrznego)Application.OpenForms["Uslugi_serwisu_zewnetrznego"];
            int row = Convert.ToInt32(frm.dgvUslugiSerwZew.CurrentRow.Cells[0].Value);

            DP_Usluga_serwisu_zewnetrznego toUpdate = this.database.DP_Usluga_serwisu_zewnetrznego.Where(uslugaserwzewn => uslugaserwzewn.Id_usluga_serwisu_zewnetrznego == row).First();
            //DP_Rodzaj_maszyny toUpdate = this.database.DP_Rodzaj_maszyny.Where(maszyna => maszyna.Id_rodzaj_maszyny == row).First();
            //dgvWlasciwosc.Columns[0].Visible = false; kod do ukrywania id w posredniczacej
            toUpdate.Nazwa_uslugi_serwisu_zewnetrznego = txtNazwaUslugiSerwZew.Text;


            database.SaveChanges();
            frm.dgvUslugiSerwZew.DataSource = this.database.vDP_Usluga_serwisu_zewnetrznego.ToList();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
