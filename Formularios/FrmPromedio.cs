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
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCalificacion1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Calificacion 1");
                TxtCalificacion1.Focus();
                return;
            }
            if (TxtCalificacion2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Calificacion 2");
                TxtCalificacion2.Focus();
                return;
            }
            if (TxtCalificacion3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Calificacion 3");
                TxtCalificacion3.Focus();
                return;
            }
            double p, c1, c2, c3;
            string Mensaje;

            c1 = Convert.ToDouble(TxtCalificacion1.Text);
            c2 = Convert.ToDouble(TxtCalificacion2.Text);
            c3 = Convert.ToDouble(TxtCalificacion3.Text);
            Mensaje = Convert.ToString(TxtMensaje.Text);

            p = (c1 + c2 + c3) / 3;

            if (p >= 65)
            {
                Mensaje = "Aprovo";
                TxtPromedio.Text = p.ToString();
                TxtMensaje.Text = Mensaje;


            }
            else
            {
                Mensaje = "Reprobo";
                TxtPromedio.Text = p.ToString();
                TxtMensaje.Text = Mensaje;

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCalificacion1.Clear();
            TxtCalificacion2.Clear();
            TxtCalificacion3.Clear();
            TxtPromedio.Clear();
            TxtMensaje.Clear();
        }
    }
}
