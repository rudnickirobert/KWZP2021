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
    public partial class NowaDostawaMaterialu : Form
    {
        DrukarniaEntities database;

        public NowaDostawaMaterialu(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox1.DisplayMember = "Nazwisko";
            this.comboBox1.ValueMember = "Id_pracownika";
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DostawaMaterialu frm = (DostawaMaterialu)Application.OpenForms["DostawaMaterialu"];
            DM_Dostawa_materialu dostawa = new DM_Dostawa_materialu();
            dostawa.Id_pracownika = Convert.ToInt32(comboBox1.SelectedValue);
            dostawa.Data_dostawy = Convert.ToDateTime(dateTimePicker2.Value);
            dostawa.Uwagi = textBox1.Text;
            this.database.DM_Dostawa_materialu.Add(dostawa);
            database.SaveChanges();
            frm.dgvDostawa.DataSource = this.database.vDM_Dostawa_materialu.ToList();
            this.Close();
        }
    }
}
