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
    public partial class Szczegoly_zatrudnienia : Form
    {
        DrukarniaEntities database;
        public Szczegoly_zatrudnienia(DrukarniaEntities database)
        {

            InitializeComponent();
            this.database = database;
            this.dataSzczegoly.DataSource = this.database.vDZ_Szczegoly_zatrudnienia.ToList();
        }

        private void Szczegoly_zatrudnienia_Load(object sender, EventArgs e)
        {

        }

        private void dataSzczegoly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataSzczegoly.DataSource = this.database.vDZ_Szczegoly_zatrudnienia.ToList();
        }

        private void dataSzczegoly_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSzczegoly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Szcz_zatrudnienia_2 szcz_zatrudnienia_2 = new Szcz_zatrudnienia_2(this.database);
            szcz_zatrudnienia_2.txtPracownik.Text = dataSzczegoly.CurrentRow.Cells[1].Value.ToString();
            szcz_zatrudnienia_2.txtNumerUmowy.Text = dataSzczegoly.CurrentRow.Cells[0].Value.ToString();
            szcz_zatrudnienia_2.txtDataZmiany.Text = dataSzczegoly.CurrentRow.Cells[2].Value.ToString();
            szcz_zatrudnienia_2.txtWynagrodzenie.Text = dataSzczegoly.CurrentRow.Cells[3].Value.ToString();
            szcz_zatrudnienia_2.ShowDialog();
        }
    }
}
