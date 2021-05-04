using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Wlasciwosc : Form
    {
        DrukarniaEntities database;
        public Wlasciwosc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.dgvWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();

            initDataGridView();
        }


        private void initDataGridView()
        {
            this.dgvWlasciwosc.DataSource = this.database.vDM_Wlasciwosc.ToList();

        }

        private void btnDeletenarzedzie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć rodzaj materiału?", "Usuwanie rodzaju materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dgvWlasciwosc.CurrentRow.Cells[0].Value);

                DM_Wlasciwosc toRemove = this.database.DM_Wlasciwosc.Where(Wlasciwosc => Wlasciwosc.Id_wlasciwosc == id).First();

                this.database.DM_Wlasciwosc.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initDataGridView();

            }
            else
            {
                DialogResult dialog1Result = MessageBox.Show("Nie udało się usunąć materiału?");
            }
        }

        private void btnAddnarzedzie_Click(object sender, EventArgs e)
        {
            NowaWlasciwosc nowa = new NowaWlasciwosc(this.database);
            nowa.ShowDialog();
        }

        private void btnNarzedziePowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvWlasciwosc.DataSource = database.vDM_Wlasciwosc.Where(x => x.Nazwa.Contains(textBox1.Text)).ToList();

        }

        private void dgvWlasciwosc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdytujWlasciwosc edycja = new EdytujWlasciwosc(this.database);
            edycja.txtNew.Text = dgvWlasciwosc.CurrentRow.Cells[1].Value.ToString();
            edycja.txtNIP.Text = dgvWlasciwosc.CurrentRow.Cells[2].Value.ToString();
            edycja.ShowDialog();
        }
    }
        }


