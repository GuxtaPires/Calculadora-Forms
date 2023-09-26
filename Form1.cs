using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Num1.Text);
            int num2 = Int32.Parse(Num2.Text);
            int soma;
            soma = num1 + num2;
            Resultado.Text = soma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Num1.Text);
            int num2 = Int32.Parse(Num2.Text);
            int sub;
            sub = num1 - num2;
            Resultado.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Num1.Text);
            int num2 = Int32.Parse(Num2.Text);
            int multi;
            multi = num1 * num2;
            Resultado.Text = multi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(Num1.Text);
            float num2 = float.Parse(Num2.Text);
            float divisao;
            divisao = num1 / num2;
            Resultado.Text = divisao.ToString();
        }
    }
}
