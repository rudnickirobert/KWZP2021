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
    public partial class Nowe_narzedzie : Form
    {
        DrukarniaEntities database;

        public Nowe_narzedzie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.comboBox1.DataSource = this.database.DM_Rodzaj_narzedzia.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_rodzaj_narzedzia";
            
        }  
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Narzedzie frm = (Narzedzie)Application.OpenForms["Narzedzie"];
            DM_Narzedzie narzedzie = new DM_Narzedzie();
            narzedzie.Nazwa = txtNazwa.Text;
            narzedzie.Id_rodzaj_narzedzia = Convert.ToInt32(comboBox1.SelectedValue); ;
            narzedzie.Nr_seryjny = txtNumer.Text;
            narzedzie.Data_zuzycia = dateTimePicker1.Value;
            this.database.DM_Narzedzie.Add(narzedzie);
            database.SaveChanges();
            frm.dgvNarzedzie.DataSource = this.database.vDM_Narzedzie.ToList();
            this.Close();
            

        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
