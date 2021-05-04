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
    public partial class ProcesDrukowania : Form
    {
        DrukarniaEntities database;
        public ProcesDrukowania(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbProcesTechno.DataSource = this.database.DP_Proces_technologiczny.ToList();
            this.cmbProcesTechno.DisplayMember = "Nazwa";
            this.cmbProcesTechno.ValueMember = "Id_proces_technologiczny";

            this.cmbWydruk.DataSource = this.database.DP_Wydruk.ToList();
            this.cmbWydruk.DisplayMember = "Id_wydruk";
            this.cmbWydruk.DisplayMember = "Id_plik";
            this.cmbWydruk.ValueMember = "Id_wydruk";

            this.cmbDelete.DataSource = this.database.DP_Po_wydr_proc.ToList();
            this.cmbDelete.DisplayMember = "Id_po_wydr_proces";
            this.cmbDelete.ValueMember = "Id_po_wydr_proces";

            this.dgvProcesDrukowania.DataSource = this.database.vDP_Po_wydr_proc.ToList();
        }
        public void initcmb()
        {
            this.cmbDelete.DataSource = this.database.DP_Po_wydr_proc.ToList();
            this.cmbDelete.DisplayMember = "Id_po_wydr_proces";
            this.cmbDelete.ValueMember = "Id_po_wydr_proces";
        }

        public void initDataGridView()
        {
            this.dgvProcesDrukowania.DataSource = this.database.vDP_Po_wydr_proc.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DP_Po_wydr_proc proc_wydruk = new DP_Po_wydr_proc();

            proc_wydruk.Id_wydruk = Convert.ToInt32(cmbWydruk.SelectedValue);
            proc_wydruk.Id_proces_technologiczny = Convert.ToInt32(cmbProcesTechno.SelectedValue);
            proc_wydruk.Czas_zamierzony = Convert.ToInt32(this.txtCzas.Text);


            database.DP_Po_wydr_proc.Add(proc_wydruk);
            database.SaveChanges();
            this.txtCzas.Text = "";
            initDataGridView();
            initcmb();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogBoxDelete d = new DialogBoxDelete();
            d.ShowDialog();

            if (d.DialogResult.Equals(DialogResult.Yes))
            {
                int id = Convert.ToInt32(this.cmbDelete.SelectedValue);

                DP_Po_wydr_proc toRemove = this.database.DP_Po_wydr_proc.Where(proc_wydruk => proc_wydruk.Id_po_wydr_proces == id).First();

                this.database.DP_Po_wydr_proc.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();

            }
            else if (d.DialogResult.Equals(DialogResult.No))
            {
                d.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            KreatorWydruk kw = new KreatorWydruk(this.database);
            kw.ShowDialog();
        }

        private void cmbDelete_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogBoxDelete d = new DialogBoxDelete();
            d.ShowDialog();

            if (d.DialogResult.Equals(DialogResult.Yes))
            {
                int id = Convert.ToInt32(this.cmbDelete.SelectedValue);

                DP_Po_wydr_proc toRemove = this.database.DP_Po_wydr_proc.Where(proc_wydruk => proc_wydruk.Id_po_wydr_proces == id).First();

                this.database.DP_Po_wydr_proc.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
                initcmb();


            }
            else if (d.DialogResult.Equals(DialogResult.No))
            {
                d.Hide();
            }
        }
    }
}
