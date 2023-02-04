using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1primerparcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularbutton1_Click(object sender, EventArgs e)
        {
            decimal Numero = Convert.ToDecimal(numerotextBox1.Text);
            decimal num = Convert.ToDecimal(numerotextBox1.Text);

            imparoparlabel2.Text= EsPar( Numero ).ToString();

            int n;
            n= Convert.ToInt32(numerotextBox1.Text);
            if (n > 0)
            {
                MessageBox.Show("el Numero es Positivo" + n);
            }
            else
            {
                MessageBox.Show("el Numero es Negativo" + n);
            }





        }
        public static bool EsPar(decimal Numero)
        {
            return Convert.ToBoolean((Numero % 2 == 0 ? true : false));
        }




    }

    }



