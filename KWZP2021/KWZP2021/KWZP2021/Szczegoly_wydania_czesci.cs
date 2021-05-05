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
    public partial class Szczegoly_wydania_czesci : Form
    {
        DrukarniaEntities database;
        public Szczegoly_wydania_czesci(DrukarniaEntities database, int id)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDM_Szczegoly_wydania_czesci.ToList();
            initDataGridView();
            DM_Szczegoly_wydania_czesci szczegoly = database.DM_Szczegoly_wydania_czesci.Where(wybrane => wybrane.Id_szczegolow_wydania_czesci == id).First();


            dataGridView1.DataSource = database.vDM_Szczegoly_wydania_czesci.Where(szcz => szcz.Identyfikator_wydania == szczegoly.Id_wydania_czesci).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void initDataGridView()
        {
            this.dataGridView1.DataSource = this.database.vDM_Szczegoly_wydania_czesci.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Lista_wypozyczen lista = new Lista_wypozyczen(this.database);
            lista.ShowDialog();
        }
    }
}
