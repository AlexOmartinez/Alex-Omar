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
    public partial class FrmNotadeE : Form
    {
        int contador = 1;
        public FrmNotadeE()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Nombre del Estudiante");
                TxtNombre.Focus();
                return;
            }
            if (TxtCalif.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la Calificacion del Estudiante");
                TxtCalif.Focus();
                return;
            }

            LsbNombre.Items.Add(TxtNombre.Text.Trim());
            LsbCalif.Items.Add(TxtNombre.Text.Trim());

            double cal;

            cal = Convert.ToDouble(TxtCalif.Text);

            if (cal >= 65)
            {
                LsbObser.Items.Add("Aprovado");
            }
            else
            {
                LsbObser.Items.Add("Reprobado");
            }

           
            contador++;
            LblEstudiante.Text = "Nombre del Estudiante" + contador.ToString() + ":";
            LblCalificacion.Text = "Calificacion del Estudiante" + contador.ToString() + ":";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtCalif.Clear();
            TxtNombre.Focus();

        }
    }
}
