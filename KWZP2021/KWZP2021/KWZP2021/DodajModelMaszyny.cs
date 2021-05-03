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
    public partial class DodajModelMaszyny : Form
    {
        DrukarniaEntities database;
        public DodajModelMaszyny(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DP_Model_maszyny news = new DP_Model_maszyny();
            news.Nazwa_modelu_maszyny = this.txtNew.Text;

            this.database.DP_Model_maszyny.Add(news);
            this.database.SaveChanges();

            var MachineModelForm = Application.OpenForms.OfType<Model_maszyny>().Single();
            MachineModelForm.initDataGridView();
            this.Close();
        }
    }
}
