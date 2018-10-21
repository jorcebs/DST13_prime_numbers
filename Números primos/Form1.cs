using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Números_primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            escribePrimos(100);
        }

        private bool esPrimo(int num)
        {
            bool esPrimo = (num > 1) ? true : false;

            for (int i = num - 1; i > 1; i--)
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            return esPrimo;
        }

        private void escribePrimos(int total)
        {
            for (int num = 2; total > 0; num++)
            {
                if (esPrimo(num))
                {
                    txtPrimos.Text += num.ToString() + Environment.NewLine;
                    total--;
                }
            }
        }
    }
}