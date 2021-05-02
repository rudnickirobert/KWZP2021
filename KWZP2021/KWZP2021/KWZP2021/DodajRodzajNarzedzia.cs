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
    public partial class DodajRodzajNarzedzia : Form
    {
        DrukarniaEntities database;
        public DodajRodzajNarzedzia(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DM_Rodzaj_narzedzia news = new DM_Rodzaj_narzedzia();
            news.Nazwa = this.txtNew.Text;

            this.database.DM_Rodzaj_narzedzia.Add(news);
            this.database.SaveChanges();

            var MaterialForm = Application.OpenForms.OfType<Rodzaj_narzedzia>().Single();
            MaterialForm.initDataGridView();
            this.Close();

        }
    }
}
