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
    public partial class Maszyna : Form
    {
        DrukarniaEntities database;
        public DataGridViewRow dataGridView;
        public Maszyna(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dgvMaszyna.DataSource = this.database.vDP_Maszyna.ToList();
            dataGridView1_CellContentClick();
        }

    
        //private void dataGridView1_CellContentClick()
        //{
        //    this.dgv_Maszyna.DataSource = this.database.vDP_Maszyna.ToList();
        //}

        private void dataGridView1_CellContentClick()
        {
            this.dgvMaszyna.DataSource = this.database.vDP_Maszyna.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvMaszyna.DataSource = database.vDP_Maszyna.Where(x => x.Rodzaj_maszyny.Contains(textBox1.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dzial_produkcji dzialProdukcji = new Dzial_produkcji(this.database);
            dzialProdukcji.ShowDialog();
        }
    }
}