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
    public partial class FirmaSerwisowa : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow dataGridView;
        public FirmaSerwisowa(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvFirma.DataSource = this.database.vDP_Firma_serwisowa.ToList();
            dgvFirma_CellContentClick();
        }

        private void dgvFirma_CellContentClick()
        {
            this.dgvFirma.DataSource = this.database.vDP_Firma_serwisowa.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvFirma.DataSource = database.vDP_Firma_serwisowa.Where(x => x.Nazwa_firmy.Contains(textBox1.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_produkcji dzialProdukcji = new Dzial_produkcji(this.database);
            dzialProdukcji.ShowDialog();
        }

        private void btnUsunFirma_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć firmę?", "Usuwanie firmy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvFirma.CurrentRow.Cells[0].Value);

                DP_Firma_serwisowa toRemove = this.database.DP_Firma_serwisowa.Where(firma => firma.Id_firma_serwisowa == id).First();


                this.database.DP_Firma_serwisowa.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdgvFirma();
            }
        }

        public void initdgvFirma()
        {
            this.dgvFirma.DataSource = this.database.vDP_Firma_serwisowa.ToList();

        }

        private void btnAddMaszyna_Click(object sender, EventArgs e)
        {
            NowaFirmaSerwisowa nowa_firma_serwisowa = new NowaFirmaSerwisowa(this.database);
            nowa_firma_serwisowa.ShowDialog();
            initdgvFirma();
        }
    }
}
