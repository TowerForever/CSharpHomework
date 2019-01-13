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
    

    public partial class Form1 : Form
    {
        public List<Order> orderlists = new List<Order>();
        Order s1 = new Order("liiii", "apple");
        Order s2 = new Order("wang", "banana");
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Orderlists\nno\tname\tgoods" + "\r\n";
            orderlists.Add(s1); orderlists.Add(s2);
            foreach (Order o in orderlists)
            {
                richTextBox1.Text = richTextBox1.Text +
                      string.Format("{0}\t{1}", o.Number, o.Customers) + "\r";
                comboBox1.Items.Add(o.Number);
                comboBox2.Items.Add(o.Customers);
            }
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            Form2 form2 = new Form2();
               form2.myevent += new Form2.TcpStatedelegate(form2_myevent);
              form2.ShowDialog();
        }
        public void form2_myevent(string str)
        {
            Order s3 = new Order("wang", "ban");
            s3.Customers = str;
            this.orderlists.Add(s3);
            comboBox1.Items.Add(s3.Number);
            comboBox2.Items.Add(s3.Customers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(orderlists);
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//refresh
        {

            richTextBox1.Text = "Orderlists\nno\tname\tgoods" + "\r\n";
            foreach (Order o in orderlists)
            {
                richTextBox1.Text = richTextBox1.Text +
                      string.Format("{0}\t{1}", o.Number, o.Customers) + "\r";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
