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
    public partial class Dostawa_glowny : Form
    {
        DrukarniaEntities database;
        public Dostawa_glowny(DrukarniaEntities database)
        {
            InitializeComponent();
            this.database = database;
        }
    }
}
