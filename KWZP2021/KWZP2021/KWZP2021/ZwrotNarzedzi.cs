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
    public partial class ZwrotNarzedzi : Form
    {
        DrukarniaEntities database;
        public ZwrotNarzedzi(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            WypozyczenieNarzedzia frm = (WypozyczenieNarzedzia)Application.OpenForms["WypozyczenieNarzedzia"];
            int row = Convert.ToInt32(frm.dgvWypozyczenie.CurrentRow.Cells[0].Value); ;
            DM_Wypozyczenie_narzedzia toUpdate = this.database.DM_Wypozyczenie_narzedzia.Where(narzedzie => narzedzie.Id_wypozyczenia_narzedzia == row).First();
            toUpdate.Data_i_godzina_zwrotu = Convert.ToDateTime(dateTimePicker2.Value);
            toUpdate.Uwagi = textBox1.Text;

            database.SaveChanges();
            frm.dgvWypozyczenie.DataSource = this.database.vDM_Wypozyczenie_narzedzia.ToList();
            this.Close();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
