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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio Promedio = new Formularios.FrmPromedio();
            Promedio.Show();
        }

        private void BtnNumeroMenor_Click(object sender, EventArgs e)
        {
            Formularios.FrmNumeroMenor NumeroMenor = new Formularios.FrmNumeroMenor();
            NumeroMenor.Show();
        }

        private void BtnPositivooNegativo_Click(object sender, EventArgs e)
        {
            Formularios.FrmPositivooNegativo positivooNegativo = new Formularios.FrmPositivooNegativo();
            positivooNegativo.Show();
        }

        private void BtnDobleoCubo_Click(object sender, EventArgs e)
        {
            Formularios.FrmDobleoCubo dobleoCubo = new Formularios.FrmDobleoCubo();
            dobleoCubo.Show();
        }

        private void BtnTotalaPagarV_Click(object sender, EventArgs e)
        {
            Formularios.FrmTotalaPagarVenta totalaPagarVenta = new Formularios.FrmTotalaPagarVenta();
            totalaPagarVenta.Show();
        }

        private void BtnTotalaPagarB_Click(object sender, EventArgs e)
        {
            Formularios.FrmTotalaPagarBoleteria totalaPagarBoleteria = new Formularios.FrmTotalaPagarBoleteria();
            totalaPagarBoleteria.Show();
        }

        private void BtnAscendente_Click(object sender, EventArgs e)
        {
            Formularios.FrmOrdenAscendente ordenAscendente = new Formularios.FrmOrdenAscendente();
            ordenAscendente.Show();
        }

        private void BtnMultiplos_Click(object sender, EventArgs e)
        {
            Formularios.FrmMultiplosde5 multiplosde5 = new Formularios.FrmMultiplosde5();
            multiplosde5.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Formularios.FrmTotalaPagarProductos totalaPagarProductos = new Formularios.FrmTotalaPagarProductos();
            totalaPagarProductos.Show();
        }

        private void BtnEdadP_Click(object sender, EventArgs e)
        {
            Formularios.FrmEdadPromedio edadPromedio = new Formularios.FrmEdadPromedio();
            edadPromedio.Show();
        }

        private void BtnTablaM_Click(object sender, EventArgs e)
        {
            Formularios.FrmTabladeMultiplicar tabladeMultiplicar = new Formularios.FrmTabladeMultiplicar();
            tabladeMultiplicar.Show();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Formularios.FrmSuma suma = new Formularios.FrmSuma();
            suma.Show();
        }

        private void BtnMostrarN_Click(object sender, EventArgs e)
        {
            Formularios.FrmMostrarNumeros mostrarNumeros = new Formularios.FrmMostrarNumeros();
            mostrarNumeros.Show();
        }

        private void BtnPromedioE_Click(object sender, EventArgs e)
        {
            Formularios.FrmNotadeE notadeE = new Formularios.FrmNotadeE();
            notadeE.Show();
        }
    }
}
