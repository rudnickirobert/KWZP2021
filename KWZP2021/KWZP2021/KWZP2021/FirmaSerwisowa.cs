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
        public FirmaSerwisowa(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            initCombobox1();
            initDataGridView1();

            this.comboBox1.DataSource = this.database.DP_Firma_serwisowa.ToList();
            this.comboBox1.DisplayMember = "Nazwa_firmy";
            this.comboBox1.DisplayMember = "Adres";
            this.comboBox1.DisplayMember = "Miasto";
            this.comboBox1.ValueMember = "Id_firma_serwisowa";

            this.dataGridView1.DataSource = this.database.DP_Firma_serwisowa.ToList();


        }
        private void initCombobox1()
        {
            this.comboBox1.DataSource = this.database.DP_Firma_serwisowa.ToList();
            this.comboBox1.DisplayMember = "Miasto";
            this.comboBox1.ValueMember = "Id_firma_serwisowa";
        }
        
        private void initDataGridView1()
        {
            this.dataGridView1.DataSource = this.database.DP_Firma_serwisowa.ToList();

        }



        private void FirmaSerwisowa_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDeleteFirma_Click(object sender, EventArgs e)
        {
            DialogBoxDelete dnew = new DialogBoxDelete();
            dnew.ShowDialog();

            if (dnew.DialogResult.Equals(DialogResult.Yes))
            {
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

                DP_Firma_serwisowa toRemove = this.database.DP_Firma_serwisowa.Where(rodzaj_czynnosci => rodzaj_czynnosci.Id_firma_serwisowa == id).First();

                this.database.DP_Firma_serwisowa.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView1();
                initCombobox1();
            }
            else if (dnew.DialogResult.Equals(DialogResult.No))
            {
                dnew.Hide();
            }
        }

        private void btnAddFirma_Click(object sender, EventArgs e)
        {
            AddFirmaSerwisowa Addnew = new AddFirmaSerwisowa();
            Addnew.ShowDialog();
        }
    }
}
