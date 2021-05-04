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
    public partial class NowyWydruk : Form
    {
        DrukarniaEntities database;
        public NowyWydruk(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbPlik.DataSource = this.database.DZ_Plik.ToList();
            this.cmbPlik.DisplayMember = "Nazwa_pliku";
            this.cmbPlik.ValueMember = "Id_pliku";
            this.dgvWydruk.DataSource = this.database.DP_Wydruk.ToList();
            initDataGridView();

        }
        private void initDataGridView()
        {
            this.dgvWydruk.DataSource = this.database.DP_Wydruk.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DP_Wydruk wydruk = new DP_Wydruk();
            wydruk.Wypelnienie = this.txtWypelnienie.Text;
            wydruk.Estymowany_czas = Convert.ToInt32(this.txtCzas.Text);
            wydruk.Estymowana_masa = this.txtMasa.Text;
            wydruk.Id_pliku = Convert.ToInt32(cmbPlik.SelectedValue);


            database.DP_Wydruk.Add(wydruk);
            database.SaveChanges();
            this.txtWypelnienie.Text = "";
            this.txtCzas.Text = "";
            this.txtMasa.Text = "";
            initDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            KreatorWydruk kw = new KreatorWydruk(this.database);
            kw.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogBoxDelete d = new DialogBoxDelete();
            d.ShowDialog();

            if (d.DialogResult.Equals(DialogResult.Yes))
            {
                int id = Convert.ToInt32(this.dgvWydruk.CurrentRow.Cells[0].Value);

                DP_Wydruk toRemove = this.database.DP_Wydruk.Where(wydruk => wydruk.Id_wydruk == id).First();

                this.database.DP_Wydruk.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();
                
            }
            else if (d.DialogResult.Equals(DialogResult.No))
            {
                d.Hide();
            }
        }
    }
}
