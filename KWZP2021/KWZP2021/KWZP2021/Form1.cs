﻿using System;
using System.Windows.Forms;

namespace KWZP2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            database = new DrukarniaEntities();
        }
        DrukarniaEntities database;
        private void DZ_Button_Click(object sender, EventArgs e)
        {
            Dzial_zarzadzania Dzial_zarzadzania = new Dzial_zarzadzania(this.database);
            Dzial_zarzadzania.ShowDialog();
        }

        private void DM_button_Click(object sender, EventArgs e)
        {
            Dzial_magazynowy Dzial_magazynowy = new Dzial_magazynowy(this.database);
            Dzial_magazynowy.ShowDialog();
        }

        private void DP_Button_Click(object sender, EventArgs e)
        {
            Dzial_produkcji Dzial_produkcji = new Dzial_produkcji(this.database);
            Dzial_produkcji.ShowDialog();
        }
    }
}
