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
    public partial class Wlasciwosc : Form
    {
        DrukarniaEntities database;
        public Wlasciwosc(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            this.cmbWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.cmbWlasciwosc.DisplayMember = "Nazwa_wlasciwosci";
            this.cmbWlasciwosc.ValueMember = "Id_wlasciwosc";

            this.dgvWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();
            InitCombobox();
            initDataGridView();
        }
        private void InitCombobox()
        {
            this.cmbWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();
            this.cmbWlasciwosc.DisplayMember = "Nazwa";
        }

        private void initDataGridView()
        {
            this.dgvWlasciwosc.DataSource = this.database.DM_Wlasciwosc.ToList();

        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
           
                DM_Wlasciwosc newWlasciwosc = new DM_Wlasciwosc();
                newWlasciwosc.Nazwa_wlasciwosci = this.textBox3.Text;
            this.database.DM_Wlasciwosc.Add(newWlasciwosc);
            this.database.SaveChanges();
            this.textBox3.Text = "";
            DM_Wlasciwosc newjednostka = new DM_Wlasciwosc();
                newjednostka.Jednostka_pomiarowa = this.textBox2.Text;
            this.database.DM_Wlasciwosc.Add(newjednostka);
            this.database.SaveChanges();
                this.textBox2.Text = "";
                initDataGridView();
                InitCombobox();
            }
        }
    }

