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
    public partial class Edytuj_czesc : Form
    {
        DrukarniaEntities database;
        public Edytuj_czesc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = database.DP_Model_maszyny.ToList();
            this.comboBox1.DisplayMember = "Nazwa_modelu_maszyny";
            this.comboBox1.ValueMember = "Id_model_maszyny";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Czesc frm = (Czesc)Application.OpenForms["Czesc"];
            int row = Convert.ToInt32(frm.dgvCzesc.CurrentRow.Cells[0].Value);
            DM_Czesc toUpdate = this.database.DM_Czesc.Where(czesc => czesc.Id_czesci == row).First();
            toUpdate.Nazwa = textBox1.Text;
            toUpdate.Id_model_maszyny = Convert.ToInt32(comboBox1.SelectedValue);
            toUpdate.Ilosc_poczatkowa = Convert.ToInt32(textBox2Ilosc.Text);

            database.SaveChanges();
            frm.dgvCzesc.DataSource = this.database.vDM_Czesc.ToList();
            this.Close();
        }

        private void button2Powrot_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Czesc Czesc = new Czesc(this.database);
            Czesc.ShowDialog();
        }
    }
}
