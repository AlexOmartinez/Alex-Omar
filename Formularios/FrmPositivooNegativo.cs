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
    public partial class FrmPositivooNegativo : Form
    {
        public FrmPositivooNegativo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingresar Numero");
                TxtNumero.Focus();
                return;
            }
            double n;
            string r;

            n = Convert.ToDouble(TxtNumero.Text);
            r = Convert.ToString(TxtRespuesta.Text);

            if (n>0) 
            {
                r = "Es Positivo";
                TxtRespuesta.Text=r.ToString();
            }
            else
            {
                r = "Es Negativo";
                TxtRespuesta.Text=r.ToString();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNumero.Clear();
            TxtRespuesta.Clear();
        }
    }
}
