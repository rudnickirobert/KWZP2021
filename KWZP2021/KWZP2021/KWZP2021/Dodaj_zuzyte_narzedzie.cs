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
    public partial class Dodaj_zuzyte_narzedzie : Form
    {
        public DrukarniaEntities database;
        public Dodaj_zuzyte_narzedzie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.comboBox1.DataSource = this.database.DM_Narzedzie.ToList();
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.ValueMember = "Id_narzedzia";
            initCombobox();

        }

        private void initCombobox()
        {
            this.comboBox1.DataSource = this.database.vDM_Narzedzie.ToList();
        }
        private void btnDodajZuzyteNarzedziePowrot_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
            Zuzyte_narzedzie zuzyte_narzedzie = new Zuzyte_narzedzie(this.database);
            zuzyte_narzedzie.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
