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
    public partial class StatusZamowienia : Form
    {
        DrukarniaEntities database;
        public StatusZamowienia(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDZ_Status_zamowienia.ToList();


            this.comboBox1.DataSource = this.database.DZ_Zamowienie_klienta.ToList();
            this.comboBox1.DisplayMember = "Id_zamowienia";
            this.comboBox1.ValueMember = "Id_zamowienia";

            this.comboBox2.DataSource = this.database.DZ_Rodzaj_statusu_zamowienia.ToList();
            this.comboBox2.DisplayMember = "Status_zam";
            this.comboBox2.ValueMember = "Id_rodzaj_statusu_zam";
        }

        private void StatusZamowienia_Load(object sender, EventArgs e)
        {

        }

        private void initdvg()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Status_zamowienia.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ_Status_zamowienia status = new DZ_Status_zamowienia();
            status.Id_zamowienia = Convert.ToInt32(comboBox1.SelectedValue);
            status.Id_rodzaj_statusu_zam = Convert.ToInt32(comboBox2.SelectedValue);
            database.DZ_Status_zamowienia.Add(status);
            database.SaveChanges();
            initdvg();
        }
    }
}
