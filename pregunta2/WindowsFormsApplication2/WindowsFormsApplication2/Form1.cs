using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double primero, segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        clases.suma obj = new clases.suma();
        clases.resta obj2 = new clases.resta();
        clases.multiplicacion obj3 = new clases.multiplicacion();
        clases.division1 obj4 = new clases.division1();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double sum, res, mul, dic;

            switch(operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    textBox1.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.Restar((primero), (segundo));
                    textBox1.Text = res.ToString();
                    break;
                case "x":
                    mul = obj3.Multiplcar((primero), (segundo));
                    textBox1.Text = mul.ToString();
                    break;
                case "/":
                    dic = obj4.Dividir((primero), (segundo));
                    textBox1.Text = dic.ToString();
                    break;
            }
        }
    }
}
