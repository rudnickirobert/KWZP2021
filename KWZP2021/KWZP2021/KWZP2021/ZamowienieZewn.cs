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
    public partial class ZamowienieZewn : Form
    {
        DrukarniaEntities database;
        public ZamowienieZewn(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.comboBox1.DataSource = this.database.DZ_Pracownik.ToList();
            this.comboBox1.DisplayMember = "Nazwisko";
            this.comboBox1.ValueMember = "Id_pracownika";
            this.dvgZamowienie_zewn.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();
        }

        private void initdvgZamowienieZewn()
        {
            this.dvgZamowienie_zewn.DataSource = this.database.vDZ_Zamowienie_zewn.ToList();

        }
        private void ZamowienieZewn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Usun_zamowienie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć wybrane zamówienie?", "Uwaga, po zatwierdzeniu rekord zostanie trwale usunięty z bazy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dvgZamowienie_zewn.CurrentRow.Cells[0].Value);

                DZ_Zamowienie_zewn toRemove = this.database.DZ_Zamowienie_zewn.Where(zamowiene => zamowiene.Id_zamowienia_zewn == id).First();


                this.database.DZ_Zamowienie_zewn.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgZamowienieZewn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_nowe_zamowienie_Click(object sender, EventArgs e)
        {
            DZ_Zamowienie_zewn zamowienie = new DZ_Zamowienie_zewn();
            zamowienie.Id_pracownika= Convert.ToInt32(comboBox1.SelectedValue);
            zamowienie.Data_zamowienia_zewn = dateTimePicker1.Value;
            database.DZ_Zamowienie_zewn.Add(zamowienie);
            database.SaveChanges();
            initdvgZamowienieZewn();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void dvgZamowienie_zewn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SzczegolyZamZewn szczegoly = new SzczegolyZamZewn(this.database);
            szczegoly.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SzczegolyZamMaterialu szczegoly_zam_mat = new SzczegolyZamMaterialu(this.database);
            szczegoly_zam_mat.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SzczegolyZamNarzedzi szczegoly_zam_narzedzi = new SzczegolyZamNarzedzi(this.database);
            szczegoly_zam_narzedzi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SzczegolyZamMaszyn szczegoly_zam_maszyn = new SzczegolyZamMaszyn(this.database);
            szczegoly_zam_maszyn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SzczegolyZamCzesci szczegoly_zam_czesci = new SzczegolyZamCzesci(this.database);
            szczegoly_zam_czesci.ShowDialog();
        }
    }
}
