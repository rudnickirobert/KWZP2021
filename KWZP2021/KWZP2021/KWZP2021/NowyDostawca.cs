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
    public partial class NowyDostawca : Form
    {
        DrukarniaEntities database;

        public NowyDostawca(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DM_Dostawca newsnowy = new DM_Dostawca();
            newsnowy.Nazwa = txtNew.Text;
            newsnowy.NIP = txtNIP.Text;
            newsnowy.Uwagi = txtUwagi.Text;

            this.database.DM_Dostawca.Add(newsnowy);
            this.database.SaveChanges();
            var MaterialForm = Application.OpenForms.OfType<Dostawcy>().Single();
            MaterialForm.initDataGridView();
            this.Close();
            
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
