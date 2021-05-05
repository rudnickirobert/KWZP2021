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
    public partial class Dodaj_usluge_serwisu_zewnetrznego : Form
    {
        DrukarniaEntities database;
        public Dodaj_usluge_serwisu_zewnetrznego(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DP_Usluga_serwisu_zewnetrznego news = new DP_Usluga_serwisu_zewnetrznego();
            news.Nazwa_uslugi_serwisu_zewnetrznego = this.txtNew.Text;

            this.database.DP_Usluga_serwisu_zewnetrznego.Add(news);
            this.database.SaveChanges();

            var UslugaSerwZewForm = Application.OpenForms.OfType<Uslugi_serwisu_zewnetrznego>().Single();
            UslugaSerwZewForm.initDataGridView();
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
