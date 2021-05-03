﻿using System;
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
    public partial class Maszyna_glowny : Form
    {
        DrukarniaEntities database;
        public Maszyna_glowny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void btn2maszyna_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Maszyna maszyna = new Maszyna(this.database);
            maszyna.ShowDialog();
            
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FirmaSerwisowa firma = new FirmaSerwisowa(this.database);
            firma.ShowDialog();
        }
    }
}
