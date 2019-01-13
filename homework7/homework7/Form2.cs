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
    public partial class Form2 : Form
    {
        static int i = 1;
        public Form2()
        {
            InitializeComponent();
           

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public delegate void TcpStatedelegate(string txt);//定义一个委托
        public event TcpStatedelegate myevent;//定义一个上述委托的事件
                                        //触发事件的方法
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (myevent != null&&i==1)//检查事件是否注册
            {
                myevent(textBox1.Text);i++;
            }
            
        }
    }
}


        //public List<Order> orderlists = new List<Order>();
        ////public IEnumerable<Order> orderlists;
        //Order s1 = new Order("liiii", "apple");
        //Order s2 = new Order("wang", "banana");


//public Form1()
//{
//    InitializeComponent();
//    richTextBox1.Text = "Orderlists\nno\tname\tgoods" + "\r\n";
//    orderlists.Add(s1); orderlists.Add(s2);
//    foreach (Order o in orderlists)
//    {
//        richTextBox1.Text = richTextBox1.Text +
//              string.Format("{0}\t{1}", o.Number, o.Customers) + "\r";
//        comboBox1.Items.Add(o.Number);
//        comboBox2.Items.Add(o.Customers);
//    }
//}

//private void button1_Click(object sender, EventArgs e)//Add
//{
//    Form2 form2 = new Form2();
//    form2.myevent += new Form2.TcpStatedelegate(form2_myevent);
//    form2.ShowDialog();
//}
//public void form2_myevent(string str)
//{
//    Order s3 = new Order("wang", "ban");
//    s3.Customers = str;
//    this.orderlists.Add(s3);
//    comboBox1.Items.Add(s3.Number);
//    comboBox2.Items.Add(s3.Customers);
//}


//private void button2_Click(object sender, EventArgs e)//Delete
//{
//    Form3 form3 = new Form3();
//    form3.ShowDialog();

//}

//private void button3_Click(object sender, EventArgs e)//Amend
//{
//    Form4 form4 = new Form4();
//    form4.Show();
//}



//private void richTextBox1_TextChanged(object sender, EventArgs e)
//{

//}

//private void groupBox1_Enter(object sender, EventArgs e)
//{

//}
//private void groupBox2_Enter(object sender, EventArgs e)
//{

//}
//private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//{
//        foreach (Order o in orderlists)
//        if (o.Number.ToString() == comboBox1.Text)
//            richTextBox1.Text = "Orderlists\nno\tname\tgoods" + "\r\n"+
//    string.Format("{0}\t{1}", o.Number, o.Customers) + "\r";
//}
//private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
//{
//    foreach (Order o in orderlists)
//        if (o.Customers == comboBox2.Text)
//            richTextBox1.Text = "Orderlists\nno\tname\tgoods" + "\r\n" +
//    string.Format("{0}\t{1}", o.Number, o.Customers) + "\r";

//}



//private void button4_Click(object sender, EventArgs e)//refresh
//{
//    richTextBox1.Text = "Orderlists\nno\tname\tgoods" + "\r\n";
//    foreach (Order o in orderlists)
//    {
//        richTextBox1.Text = richTextBox1.Text +
//              string.Format("{0}\t{1}", o.Number, o.Customers) + "\r";

//    }

//}
