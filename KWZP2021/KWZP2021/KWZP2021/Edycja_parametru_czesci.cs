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
    public partial class Edycja_parametru_czesci : Form
    {
       DrukarniaEntities database;
        public Edycja_parametru_czesci(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parametr_czesci parametr = new Parametr_czesci(this.database);
            parametr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parametr_czesci frm = (Parametr_czesci)Application.OpenForms["Parametr_czesci"];
            int row = Convert.ToInt32(frm.dgvParametrCzesci.CurrentRow.Cells[0].Value);
            DM_Parametr_czesci toUpdate = this.database.DM_Parametr_czesci.Where(czesc => czesc.Id_parametr_czesci == row).First();
            toUpdate.Wartosc = textBox1.Text;

            database.SaveChanges();
            frm.dgvParametrCzesci.DataSource = this.database.vDM_Parametr_czesci.ToList();
            this.Close();
        }
    }
}
