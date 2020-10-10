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
    public partial class FrmTotalaPagarVenta : Form
    {
        public FrmTotalaPagarVenta()
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
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Precio");
                TxtPrecio.Focus();
                return;
            }
            double c, p, subt, t, tp;

            c = Convert.ToDouble(TxtCantidad.Text);
            p = Convert.ToDouble(TxtPrecio.Text);
            if (c>=3)
            {
                t = c * p;
                subt = (c * p) *0.20;
                tp = t - subt;
                TxtSubtotal.Text = subt.ToString();
                TxtTotalaPagar.Text = tp.ToString();
            }
            else
            {
                t = c * p;
                subt = (c * p) * 0.20;
                tp = t - subt;
                TxtSubtotal.Text = subt.ToString();
                TxtTotalaPagar.Text = tp.ToString();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtSubtotal.Clear();
            TxtTotalaPagar.Clear();
        }

        private void FrmTotalaPagarVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
