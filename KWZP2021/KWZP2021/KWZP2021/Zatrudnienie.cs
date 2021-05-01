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
    public partial class Zatrudnienie : Form
    {
        DrukarniaEntities database;
        public Zatrudnienie(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initDataGridView();
        }

        private void Zatrudnienie_Load(object sender, EventArgs e)
        {

        }
        private void initDataGridView()
        {
            this.dgvZatrudnienie.DataSource = this.database.vDZ_Zatrudnienie.ToList();

        }
        private void dgvZatrudnienie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            initDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nowe_zatrudnienie nowe_zatrudnienie = new Nowe_zatrudnienie(this.database);
            nowe_zatrudnienie.ShowDialog();
        }

        private void dgvZatrudnienie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
            //szczegoly_zatrudnienia.txtNumerUmowy = .CurrentRow.Cells[1].Value.ToString();
            //szczegoly_zatrudnienia.txtNip1.Text = dvgKlient.CurrentRow.Cells[2].Value.ToString();
            //szczegoly_zatrudnienia.txtImie1.Text = dvgKlient.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Szczegoly_zatrudnienia szczegoly_zatrudnienia = new Szczegoly_zatrudnienia(this.database);
            szczegoly_zatrudnienia.ShowDialog();
        }
    }
}
