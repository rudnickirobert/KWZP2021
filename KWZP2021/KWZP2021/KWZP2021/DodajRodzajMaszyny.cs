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
    public partial class DodajRodzajMaszyny : Form
    {
        DrukarniaEntities database;
        public DodajRodzajMaszyny(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DP_Rodzaj_maszyny news = new DP_Rodzaj_maszyny();
            news.Rodzaj_maszyny = this.txtNew.Text;

            this.database.DP_Rodzaj_maszyny.Add(news);
            this.database.SaveChanges();

            var MachineTypeForm = Application.OpenForms.OfType<Rodzaj_maszyny>().Single();
            MachineTypeForm.initDataGridView();
            this.Close();
        }
    }
}
