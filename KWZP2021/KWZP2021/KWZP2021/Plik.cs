using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KWZP2021
{
    public partial class Plik : Form
    {
        DrukarniaEntities database;
        public Plik(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
            this.dataGridView1.DataSource = this.database.vDZ_Plik.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileSelected = openFileDialog1.FileName;
                    string fileName = Path.GetFileNameWithoutExtension(fileSelected);
                    string ext = Path.GetExtension(fileSelected);
                    textBox1.Text = fileName;
                    textBox2.Text = ext;
                }
            }
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void initdvgplik()
        {
            this.dataGridView1.DataSource = this.database.vDZ_Plik.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć wybrany plik?", "Uwaga, po zatwierdzeniu rekord zostanie trwale usunięty z bazy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

                DZ_Plik toRemove = this.database.DZ_Plik.Where(plik => plik.Id_pliku == id).First();


                this.database.DZ_Plik.Remove(toRemove); // DELETE

                this.database.SaveChanges();
                initdvgplik();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DZ_Plik plik = new DZ_Plik();
            plik.Nazwa_pliku = textBox1.Text;
            plik.Rozszerzenie = textBox2.Text;
            database.DZ_Plik.Add(plik);
            database.SaveChanges();
            initdvgplik();
        }

        private void Plik_Load(object sender, EventArgs e)
        {

        }
    }
}
