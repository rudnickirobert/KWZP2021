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
    public partial class DP1 : Form
    {
        DrukarniaEntities database;
        public DP1(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;

            initDGVFirma();
        }

        private void btnAddFirmaSerwisowa_Click(object sender, EventArgs e)
        {
            DP_Firma_serwisowa newFirmaSerwisowa = new DP_Firma_serwisowa();
            newFirmaSerwisowa.Nazwa_firmy = this.txtNewFirmaSerwisowa.Text;

            this.database.DP_Firma_serwisowa.Add(newFirmaSerwisowa);
            this.database.SaveChanges();
            this.txtNewFirmaSerwisowa.Text = "";
        }

        private void initDGVFirma()
        {
            this.DGVFirma.DataSource = this.database.DP_Firma_serwisowa.ToList();

        }
    }
}
