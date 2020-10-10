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
    public partial class FrmMostrarNumeros : Form
    {
        public FrmMostrarNumeros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int i=100;

            for (i = 100; i <= 200; i+=1)
            {
                          
                TxtNumeros.Text =TxtNumeros.Text + i.ToString() + "-";

            }
        }

        private void FrmMostrarNumeros_Load(object sender, EventArgs e)
        {

        }
    }
}
