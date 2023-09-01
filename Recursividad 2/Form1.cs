using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad_2
{
    public partial class lblNumero : Form
    {
        public lblNumero()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double n=int.Parse(txtNumero.Text);
            Metodos facto=new Metodos();
            double total = Metodos.factorial(n);
            txtResultado.Text=Convert.ToString(total);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            int potenc=int.Parse(txtPotencia.Text);
            int n=int.Parse(txtNumero.Text);
            Metodos potenci=new Metodos();
            int total=Metodos.potencia(n, potenc);
            txtResultado.Text=Convert.ToString(total);
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumero.Text);
            Metodos fibo=new Metodos();
            int total = Metodos.fibonacci(n);
            txtResultado.Text=Convert.ToString(total);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
