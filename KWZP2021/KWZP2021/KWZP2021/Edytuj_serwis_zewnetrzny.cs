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
    public partial class Edytuj_serwis_zewnetrzny : Form
    {
        DrukarniaEntities database;
        public Edytuj_serwis_zewnetrzny(DrukarniaEntities database)
        {
            this.database = database;
            InitializeComponent();

            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            this.comboBox1.DataSource = this.database.DP_Firma_serwisowa.ToList();
            this.comboBox2.DataSource = this.database.DP_Maszyna.ToList();
            this.comboBox3.DataSource = this.database.DP_Usluga_serwisu_zewnetrznego.ToList();
            this.comboBox1.DisplayMember = "Nazwa_firmy";
            this.comboBox1.ValueMember = "Id_firma_serwisowa";
            this.comboBox2.DisplayMember = "Nr_seryjny";
            this.comboBox2.ValueMember = "Id_maszyny";
            this.comboBox3.DisplayMember = "Nazwa_uslugi_serwisu_zewnetrznego";
            this.comboBox3.ValueMember = "Id_usluga_serwisu_zewnetrznego";

        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            txtKoszt.Text = "";
            //textBox2.Text = "";
            textBox1.Text = "";
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdytujSerwisZewn_Click(object sender, EventArgs e)
        {
            Serwis_zewnetrzny frm = (Serwis_zewnetrzny)Application.OpenForms["Serwis_zewnetrzny"];
            int row = Convert.ToInt32(frm.dgvSerwisZew.CurrentRow.Cells[0].Value);

            DP_Serwis_zewnetrzny toUpdate = this.database.DP_Serwis_zewnetrzny.Where(serwzewn => serwzewn.Id_serwis_zewnetrzny == row).First();

            toUpdate.Id_firma_serwisowa = Convert.ToInt32(comboBox1.SelectedValue);
            toUpdate.Id_maszyny = Convert.ToInt32(comboBox2.SelectedValue);
            toUpdate.Id_usluga_serwisu_zewnetrznego = Convert.ToInt32(comboBox3.SelectedValue);
            toUpdate.Koszt = Convert.ToInt32(txtKoszt.Text);
            toUpdate.Data_rozpoczecia = Convert.ToDateTime(dateTimePicker1.Value);
            toUpdate.Data_zakonczenia = Convert.ToDateTime(dateTimePicker2.Value);
            toUpdate.Uwagi = textBox1.Text;
            database.SaveChanges();
            frm.dgvSerwisZew.DataSource = this.database.vDP_Serwis_zewnetrzny.ToList();
            this.Close();
        }
    }
    
}
