using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double FACTURAR = double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text);
            textBox4.Text = FACTURAR.ToString();

            double IVA = double.Parse(textBox4.Text) * .16;
            textBox5.Text = IVA.ToString();

            double SUBTOTAL = double.Parse(textBox4.Text) + double.Parse(textBox5.Text);
            textBox6.Text = SUBTOTAL.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
    

