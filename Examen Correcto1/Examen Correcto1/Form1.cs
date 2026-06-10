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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string nombre;
        public static string cedula;
        public static string cell;
        public static string carro;

        


        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtcedula.Text = "";
            txtcell.Text = "";
            cbcarro.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtcedula.Text == "" || txtcell.Text == "" || cbcarro.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");

            }else if (txtnombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre debe tener al menos 3 caracteres.");

            }else if (txtcedula .Text.Length != 10 )
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos y contener solo números.");
            }
            else
            {
                FRMResumen frmResumen = new FRMResumen();
                frmResumen.Show();
            }
        }
   

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
