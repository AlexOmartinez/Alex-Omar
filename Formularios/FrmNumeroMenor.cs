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
    public partial class FrmNumeroMenor : Form
    {
        public FrmNumeroMenor()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtPrimerNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar el Primer Numero");
                TxtPrimerNumero.Focus();
                return;
            }
            if (TxtSegundoNumero.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingresar el Segundo Numero");
                TxtSegundoNumero.Focus();
                return;
            }
            double n1, n2;
            string r;

            n1 = Convert.ToDouble(TxtPrimerNumero.Text);
            n2 = Convert.ToDouble(TxtSegundoNumero.Text);

            if (n1 > n2)
            {
                r = "El Mayor es " + n1;            
                TxtMensaje.Text = r.ToString();


            }
            else if(n1==n2){
                r = "Son Iguales ";           
                TxtMensaje.Text = r.ToString();

            }
            else
            {
                r = "El Mayor es " + n2;             
                TxtMensaje.Text = r.ToString();

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPrimerNumero.Clear();
            TxtSegundoNumero.Clear();
            TxtMensaje.Clear();
        }
    }
}
