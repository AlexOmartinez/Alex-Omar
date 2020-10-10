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
    public partial class FrmTotalaPagarBoleteria : Form
    {
        public FrmTotalaPagarBoleteria()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Cantidad");
                TxtCantidad.Focus();
                return;
            }
            double c, tp;

            c = Convert.ToDouble(TxtCantidad.Text);

            if (c >= 10)
            {
                tp = c * 80;
                TxtTotalaPagar.Text = tp.ToString();
            }
            else
            {
                tp = c * 100;
                TxtTotalaPagar.Text = tp.ToString();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCantidad.Clear();
            TxtTotalaPagar.Clear();
        }
    }
}
