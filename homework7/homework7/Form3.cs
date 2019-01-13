using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using homework4_2;

namespace homework7
{
    public partial class Form3 : Form
    {
       
        
        public Form3(List<Order> orderlists)
        {
            InitializeComponent();
            foreach (Order o in orderlists)
            {
                comboBox1.Items.Add(o.Number);
                comboBox4.Items.Add(o.Customers);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
