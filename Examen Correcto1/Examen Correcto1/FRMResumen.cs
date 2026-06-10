using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Correcto1
{
    public partial class FRMResumen : Form
    {
        public FRMResumen()
        {
            InitializeComponent();
        }

        

        private void FRMResumen_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Nombre: " + Form1.nombre;
        }
    }
}
