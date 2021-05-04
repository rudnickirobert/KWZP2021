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
    public partial class Dodaj_wydanie_produktu : Form
    {
        DrukarniaEntities database;
        public Dodaj_wydanie_produktu(DrukarniaEntities database)
        {
            InitializeComponent();
        }
    }
}
