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
    public partial class FrmOrdenAscendente : Form
    {
        public FrmOrdenAscendente()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (TxtPrimerNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Primer Numero");
                TxtPrimerNumero.Focus();
                return;
            }
            if (TxtSegundoNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Segundo Numero");
                TxtSegundoNumero.Focus();
                return;
            }
            double n1, n2,me,ma;

            n1 = Convert.ToDouble(TxtPrimerNumero.Text);
            n2 = Convert.ToDouble(TxtSegundoNumero.Text);

            if (n1>n2)
            {
                me = +n2;
                ma = +n1;
                TxtMenor.Text = me.ToString();
                TxtMayor.Text = ma.ToString();
            }
            else if(n1<n2)
            {
                ma = +n2;
                me = +n1;
                TxtMenor.Text = me.ToString();
                TxtMayor.Text = ma.ToString();
            }
            else
            {
                ma = +n1;
                me = +n2;
                TxtMenor.Text = me.ToString();
                TxtMayor.Text = ma.ToString();
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPrimerNumero.Clear();
            TxtSegundoNumero.Clear();
            TxtMenor.Clear();
            TxtMayor.Clear();
        }

        private void FrmOrdenAscendente_Load(object sender, EventArgs e)
        {

        }
    }
}
