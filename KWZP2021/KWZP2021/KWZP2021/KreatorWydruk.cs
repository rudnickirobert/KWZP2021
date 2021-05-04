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

    public partial class KreatorWydruk : Form
    {
        DrukarniaEntities database;
        public KreatorWydruk(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;


            this.cmbPlik.DataSource = this.database.DZ_Plik.ToList();
            this.cmbPlik.DisplayMember = "Nazwa_pliku";
            this.cmbPlik.ValueMember = "Id_pliku";

            this.cmbMaterial.DataSource = this.database.DM_Material.ToList();
            this.cmbMaterial.DisplayMember = "Nazwa";
            this.cmbMaterial.ValueMember = "Id_materialu";

            this.cmbWydruk.DataSource = this.database.DP_Wydruk.ToList();
            this.cmbWydruk.DisplayMember = "Id_wydruk";
            this.cmbWydruk.ValueMember = "Id_wydruk";

            this.cmbPOwydruk.DataSource = this.database.DP_Po_wydr_proc.ToList();
            this.cmbPOwydruk.DisplayMember = "Id_po_wydr_proces";
            this.cmbPOwydruk.ValueMember = "Id_po_wydr_proces";


            this.cmbMaszyna.DataSource = this.database.vDP_Maszyna_drukarki.ToList();
            this.cmbMaszyna.DisplayMember = "Nazwa_modelu_maszyny";
            this.cmbMaszyna.ValueMember = "Id_maszyny";

            this.dgv_PO_wydr_proc.DataSource = this.database.vDP_Wydruk_Proces1.ToList();
            initDGV();
            initCMB();
        }
        public void initDGV()
        {
            this.dgv_PO_wydr_proc.DataSource = this.database.vDP_Wydruk_Proces1.ToList();
        }
        public void initCMB()
        {
            this.cmbPlik.DataSource = this.database.DZ_Plik.ToList();
            this.cmbPlik.DisplayMember = "Nazwa_pliku";
            this.cmbPlik.ValueMember = "Id_pliku";

            this.cmbMaterial.DataSource = this.database.DM_Material.ToList();
            this.cmbMaterial.DisplayMember = "Nazwa";
            this.cmbMaterial.ValueMember = "Id_materialu";

            this.cmbWydruk.DataSource = this.database.DP_Wydruk.ToList();
            this.cmbWydruk.DisplayMember = "Id_wydruk";
            this.cmbWydruk.ValueMember = "Id_wydruk";

            this.cmbPOwydruk.DataSource = this.database.DP_Po_wydr_proc.ToList();
            this.cmbPOwydruk.DisplayMember = "Id_po_wydr_proces";
            this.cmbPOwydruk.ValueMember = "Id_po_wydr_proces";

            this.cmbMaszyna.DataSource = this.database.vDP_Maszyna_drukarki.ToList();
            this.cmbMaszyna.DisplayMember = "Nazwa_modelu_maszyny";
            this.cmbMaszyna.ValueMember = "Id_maszyny";
        }


        private void btnWydruk_Click(object sender, EventArgs e)
        {
            this.Hide();
            NowyWydruk kw = new NowyWydruk(this.database);
            kw.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcesDrukowania pd = new ProcesDrukowania(this.database);
            pd.ShowDialog();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DP_Po_maszyna_wydruk proces_wydruk1 = new DP_Po_maszyna_wydruk();
            proces_wydruk1.Id_maszyny = Convert.ToInt32(cmbMaszyna.SelectedValue);
            proces_wydruk1.Id_po_wydr_proces = Convert.ToInt32(cmbPOwydruk.SelectedValue);
            database.DP_Po_maszyna_wydruk.Add(proces_wydruk1);
            this.database.SaveChanges();

            DP_Po_material_wydruk proces_material = new DP_Po_material_wydruk();
            proces_material.Id_materialu = Convert.ToInt32(cmbMaterial.SelectedValue);
            proces_material.Id_po_wydr_proc = Convert.ToInt32(cmbPOwydruk.SelectedValue);



            database.DP_Po_maszyna_wydruk.Add(proces_wydruk1);
            this.database.SaveChanges();
            initDGV();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrzypiszMaterial pd = new PrzypiszMaterial(this.database);
            pd.ShowDialog();
        }



        /*
public void InitializeCombobox1()
{
//do pliku nazwa elementu
this.cmbPlik.DataSource = this.database.DZ_Plik.ToList();
this.cmbPlik.DisplayMember = "Nazwa_pliku";
this.cmbPlik.ValueMember = "Id_pliku";
}

public void InitializeCombobox2()
{
//do pliku nazwa elementu
this.cmbMaterial.DataSource = this.database.DZ_Plik.ToList();
this.cmbMaterial.DisplayMember = "Nazwa";
this.cmbMaterial.ValueMember = "Id_materialu";
}
*/


    }
}
