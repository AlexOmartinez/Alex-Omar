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
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 1; i <= 100; i++)
            {
                j = i * (i + 1) / 2;
                TxtSuma.Text = j.ToString();

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtSuma.Clear();
        }
    }
}
