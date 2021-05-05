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
    public partial class Nowy_serwis_zewnetrzny : Form
    {
        DrukarniaEntities database;
        public Nowy_serwis_zewnetrzny(DrukarniaEntities database)
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

        private void buttonZapiszNowySerwis_Click(object sender, EventArgs e)
        {

            Serwis_zewnetrzny frm = (Serwis_zewnetrzny)Application.OpenForms["Serwis_zewnetrzny"];

            DP_Serwis_zewnetrzny serwis_zewnetrzny = new DP_Serwis_zewnetrzny();

            serwis_zewnetrzny.Id_firma_serwisowa = Convert.ToInt32(comboBox1.SelectedValue);
            serwis_zewnetrzny.Id_maszyny = Convert.ToInt32(comboBox2.SelectedValue);
            serwis_zewnetrzny.Id_usluga_serwisu_zewnetrznego = Convert.ToInt32(comboBox3.SelectedValue);
            serwis_zewnetrzny.Koszt = Convert.ToInt32(txtKoszt.Text);
            serwis_zewnetrzny.Data_rozpoczecia = Convert.ToDateTime(dateTimePicker1.Value);
            serwis_zewnetrzny.Data_zakonczenia = Convert.ToDateTime(dateTimePicker2.Value);
           // serwis_zewnetrzny.Ilosc= Convert.ToInt32(textBox2.Text);
            serwis_zewnetrzny.Uwagi = textBox1.Text;
            this.database.DP_Serwis_zewnetrzny.Add(serwis_zewnetrzny);
            database.SaveChanges();

            frm.dgvSerwisZew.DataSource = this.database.vDP_Serwis_zewnetrzny.ToList();
            this.Close();
        }
    }
}
