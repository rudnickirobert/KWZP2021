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
    public partial class PrzypiszMaterial : Form
    {
        DrukarniaEntities database;
        public PrzypiszMaterial(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dataGridView1.DataSource = this.database.vDP_Po_material_wydruk.ToList();
            this.dgvMaterialWydruk.DataSource = this.database.DP_Po_material_wydruk.ToList();



            this.cmbMaterial.DataSource = this.database.DM_Material.ToList();
            this.cmbMaterial.DisplayMember = "Nazwa";
            this.cmbMaterial.ValueMember = "Id_materialu";

            this.cmbWydruk.DataSource = this.database.DP_Po_wydr_proc.ToList();
            this.cmbWydruk.DisplayMember = "Id_wydruk";
            this.cmbWydruk.ValueMember = "Id_wydruk";


            initDataGridView();
            initCMB();
        }
        public void initDataGridView()
        {
            this.dgvMaterialWydruk.DataSource = this.database.DP_Po_material_wydruk.ToList();
            this.dataGridView1.DataSource = this.database.vDP_Po_material_wydruk.ToList();
        }
        public void initCMB()
        {
            this.cmbMaterial.DataSource = this.database.DM_Material.ToList();
            this.cmbMaterial.DisplayMember = "Nazwa";
            this.cmbMaterial.ValueMember = "Id_materialu";

            this.cmbWydruk.DataSource = this.database.DP_Po_wydr_proc.ToList();
            this.cmbWydruk.DisplayMember = "Id_wydruk";
            this.cmbWydruk.ValueMember = "Id_wydruk";

        }

        private void btnSavin_Click(object sender, EventArgs e)
        {
            DP_Po_material_wydruk material_wydruk = new DP_Po_material_wydruk();
            material_wydruk.Id_materialu = Convert.ToInt32(this.cmbMaterial.SelectedValue);
            material_wydruk.Id_po_wydr_proc = Convert.ToInt32(this.cmbWydruk.SelectedValue);
            material_wydruk.Ilosc = Convert.ToInt32(this.txtMaterial.Text);

            database.DP_Po_material_wydruk.Add(material_wydruk);
            this.database.SaveChanges();




            database.DP_Po_material_wydruk.Add(material_wydruk);
            this.database.SaveChanges();
            this.txtMaterial.Text = "";
            initDataGridView();
            initCMB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogBoxDelete d = new DialogBoxDelete();
            d.ShowDialog();

            if (d.DialogResult.Equals(DialogResult.Yes))
            {
                int id = Convert.ToInt32(this.dgvMaterialWydruk.CurrentRow.Cells[0].Value);

                DP_Po_material_wydruk toRemove = this.database.DP_Po_material_wydruk.Where(material_wydruk => material_wydruk.Id_po_material_wydruk == id).First();

                this.database.DP_Po_material_wydruk.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
                initCMB();

            }
            else if (d.DialogResult.Equals(DialogResult.No))
            {
                d.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KreatorWydruk kw = new KreatorWydruk(this.database);
            kw.ShowDialog();
        }
    }
}
