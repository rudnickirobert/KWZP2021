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
    public partial class Nowa_maszyna : Form
    {
        DrukarniaEntities database;
        public Nowa_maszyna(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {

            
                txtRodzaj_maszyny.Text = "";
                txtNazwa_modelu.Text = "";
                txtNumer_seryjny.Text = "";
                txtData_wprowadzenia.Text = "";
                txtKoszt_1rh.Text = "";
               

            
        }

        private void buttonZapiszNowaMaszyna_Click(object sender, EventArgs e)
        {
            DP_Maszyna maszyna = new DP_Maszyna();
            DP_Rodzaj_maszyny rodzajMaszyny = new DP_Rodzaj_maszyny();
            DP_Model_maszyny modelMaszyny = new DP_Model_maszyny();
            rodzajMaszyny.Rodzaj_maszyny = txtRodzaj_maszyny.Text;
            modelMaszyny.Nazwa_modelu_maszyny = txtNazwa_modelu.Text;
            maszyna.Nr_seryjny = txtNumer_seryjny.Text;
            maszyna.Data_wprowadzenia = Convert.ToDateTime(txtData_wprowadzenia.Text);
            maszyna.Koszt_1rh = Convert.ToInt32(txtKoszt_1rh.Text);

            database.DP_Maszyna.Add(maszyna);
            database.DP_Rodzaj_maszyny.Add(rodzajMaszyny);
            database.DP_Model_maszyny.Add(modelMaszyny);
            database.SaveChanges();
            this.Close();
        }
    }
}
