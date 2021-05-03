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
    public partial class NoweWypozyczenie : Form
    {
        DrukarniaEntities database;
        public NoweWypozyczenie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox1.DisplayMember = "Nazwisko";
            this.comboBox1.ValueMember = "Id_pracownika";
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            WypozyczenieNarzedzia frm = (WypozyczenieNarzedzia)Application.OpenForms["WypozyczenieNarzedzia"];
            DM_Wypozyczenie_narzedzia narzedzie = new DM_Wypozyczenie_narzedzia();
            narzedzie.Id_pracownika_wypozyczajacego = Convert.ToInt32(comboBox1.SelectedValue);
            narzedzie.Data_i_godzina_wypozyczenia = Convert.ToDateTime(dateTimePicker2.Value);
            narzedzie.Data_i_godzina_zwrotu = Convert.ToDateTime(dateTimePicker2.Value);
            narzedzie.Uwagi = textBox1.Text;
            this.database.DM_Wypozyczenie_narzedzia.Add(narzedzie);
            database.SaveChanges();
            frm.dgvWypozyczenie.DataSource = this.database.vDM_Wypozyczenie_narzedzia.ToList();
            this.Close();
        }
    }
}

