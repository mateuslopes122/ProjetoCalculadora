using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //contatenando o número 0
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {

                //aqui vamos pegar valor1 e
                //armazenar o texto do TxtResultado
                //dentro dela
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                //limpando o TxtResultado
                TxtResultado.Text = "";
                //informar para o programa que é uma Soma
                operacao = "SOMA";
                //informar para o usuário a operação que estamos usando
                labelOperacao.Text = "+";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //pegando valor2 
            valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            //verificando qual é a opreaç~]ao matemática
            if(operacao == "SOMA")
            {
                //colocando a soma de valor1 e valor2 no campo de texto da calculadora
                TxtResultado.Text = Convert.ToString(valor1 + valor2);
            }else if(operacao == "SUB")
            {
                TxtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                TxtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                TxtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {

                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "SUB";

                labelOperacao.Text = "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "MULT";

                labelOperacao.Text = "x";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "DIV";

                labelOperacao.Text = "/";
            }
        }

        private void labelOperacao_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }
    }
}
