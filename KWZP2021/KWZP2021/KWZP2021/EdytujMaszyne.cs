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
    public partial class EdytujMaszyne : Form
    {
        internal object textBox1;
        DrukarniaEntities database;

        public EdytujMaszyne(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.comboBox1.DataSource = this.database.DP_Rodzaj_maszyny.ToList();
            this.comboBox2.DataSource = this.database.DP_Model_maszyny.ToList();
            this.comboBox1.DisplayMember = "Rodzaj_maszyny";
            this.comboBox1.ValueMember = "Id_rodzaj_maszyny";
            this.comboBox2.DisplayMember = "Nazwa_modelu_maszyny";
            this.comboBox2.ValueMember = "Id_model_maszyny";
        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            txtNumer_seryjny.Text = "";
            txtKoszt_1rh.Text = "";
        }

        private void buttonZapiszNowaMaszyna_Click(object sender, EventArgs e)
        {            
            Maszyna frm = (Maszyna)Application.OpenForms["Maszyna"];
            int row = Convert.ToInt32(frm.dgvMaszyna.CurrentRow.Cells[0].Value);

            DP_Maszyna toUpdate = this.database.DP_Maszyna.Where(maszyna => maszyna.Id_maszyny == row).First();

            toUpdate.Id_rodzaj_maszyny = Convert.ToInt32(comboBox1.SelectedValue);
            toUpdate.Id_model_maszyny = Convert.ToInt32(comboBox2.SelectedValue);
            toUpdate.Nr_seryjny = txtNumer_seryjny.Text;
            toUpdate.Data_wprowadzenia = Convert.ToDateTime(dateTimePicker1.Value);
            toUpdate.Koszt_1rh = Convert.ToInt32(txtKoszt_1rh.Text);
            database.SaveChanges();
            frm.dgvMaszyna.DataSource = this.database.vDP_Maszyna.ToList();
            this.Close();
        }
    }
}
