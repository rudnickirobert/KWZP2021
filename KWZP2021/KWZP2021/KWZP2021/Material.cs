using System;
using System.Linq;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Material : Form
    {
        DrukarniaEntities database;
        public Material(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvMaterial.DataSource = this.database.vDM_Material.ToList();
            initDataGridView();
        }
        private void initDataGridView()
        {
            this.dgvMaterial.DataSource = this.database.vDM_Material.ToList();

        }
        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            DodajMaterial dodajmaterial = new DodajMaterial(this.database);
            dodajmaterial.ShowDialog();
        }
        

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchValue = txtFindMaterial.Text;

            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvMaterial.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                
            }
        }

        private void txtFindMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Material_Load(object sender, EventArgs e)
        {

        }
    }
}
    
