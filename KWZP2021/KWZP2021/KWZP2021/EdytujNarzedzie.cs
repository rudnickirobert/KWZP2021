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
    public partial class EdytujNarzedzie : Form
    {
        DrukarniaEntities database;

        public EdytujNarzedzie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = database.DM_Rodzaj_narzedzia.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_rodzaj_narzedzia";
            
        }
       
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Narzedzie frm = (Narzedzie)Application.OpenForms["Narzedzie"];
            int row = (frm.dgvNarzedzie.CurrentRow.Index) + 1;
            DM_Narzedzie toUpdate = this.database.DM_Narzedzie.Where(narzedzie => narzedzie.Id_narzedzia == row).First();
            toUpdate.Nazwa = textBox2.Text;
            toUpdate.Id_rodzaj_narzedzia= Convert.ToInt32(comboBox1.SelectedValue);
            toUpdate.Nr_seryjny = textBox1.Text;
            toUpdate.Data_zuzycia = dateTimePicker1.Value;

            database.SaveChanges();
            frm.dgvNarzedzie.DataSource = this.database.vDM_Narzedzie.ToList();
            this.Close();
        }

        private void EdytujNarzedzie_Load(object sender, EventArgs e)
        {

        }
    }
}
