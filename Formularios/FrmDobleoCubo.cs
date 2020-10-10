using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasdeControl_AlexOmarMartinez.Formularios
{
    public partial class FrmDobleoCubo : Form
    {
        public FrmDobleoCubo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNumero.Clear();
            TxtResultado.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Numero");
                TxtNumero.Focus();
                return;
            }
            double n, r;

            n = Convert.ToDouble(TxtNumero.Text);

            if (n >= 10)
            {
                r = n * n;
                TxtResultado.Text = r.ToString();
            }
            else
            {
                r = n * n * n;
                TxtResultado.Text = r.ToString();
            }

            


        }
    }
}
