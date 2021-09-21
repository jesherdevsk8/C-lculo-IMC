using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Jesher
{
    public partial class frm_imc : Form
    {
        public frm_imc()
        {
            InitializeComponent();
        }

        private void Frm_imc_Load(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            lblmsgTela.Visible = false;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double altura = 0, peso = 0, resultado = 0;
            double pesoMin = 0, pesoMax = 0;
            string msg_Tela = "";

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            resultado = peso / (altura * altura);

            pesoMin = Convert.ToDouble(18.5 * (altura * altura));
            pesoMax = Convert.ToDouble(25 * (altura * altura));

            lblResultado.Visible = true;
            lblmsgTela.Visible = true;
            lblResultado.Text = resultado.ToString("n2");

            if (resultado < 18.5) msg_Tela = "Abaixo do Peso Normal";
            if (resultado >= 18.5 && resultado < 25) msg_Tela = "Peso Normal";
            if (resultado >= 25 && resultado < 30) msg_Tela = "Sobrepeso";
            if (resultado >= 30 && resultado < 35) msg_Tela = "Obesidade grau I";
            if (resultado >= 35 && resultado < 40) msg_Tela = "Obesidade grau II";
            if (resultado >= 40) msg_Tela = "Obesidade grau III";

            lblmsgTela.Text = "Peso Ideal de: " + pesoMin.ToString("n2") + " Kg Até "
            + pesoMax.ToString("n2") + " Kg. ";
            
            // outra forma que pode ser feito 
            //lblmsgTela.Text = string.Format("Peso Ideal de {0:n2} Kg até {1:n2} Kg.", pesoMin, pesoMax);

            
            MessageBox.Show(msg_Tela);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";

            lblResultado.Visible = false;
            lblmsgTela.Visible = false;
        }
    }
}
