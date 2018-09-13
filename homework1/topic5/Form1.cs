using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace topic5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number1, number2, result;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox1.Text.ToString());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            number2 = Convert.ToInt32(textBox2.Text.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = number1 * number2;
            textBox3.Text = (result.ToString());

        }
    }
}
