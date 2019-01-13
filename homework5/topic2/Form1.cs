﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace topic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if (graphics == null) graphics = this.CreateGraphics();
           drawCaylayTree(10, 200, 310, 100, -Math.PI / 2);
           
            // pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\" +
             //   "asus\\Pictures\\Camera Roll\\1.jpg");

        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        void drawCaylayTree (int n,double x0,double y0,double length,double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            double x2 = x0 - length * Math.Cos(th);
            double y2 = y0 + length * Math.Sin(th);
            drawLine(x0,y0, x1, y1);
            drawCaylayTree(n - 1, x1, y1, per2 * length, th + th2);

            drawCaylayTree(n - 1, x2, y2, per1 * length, th - th1);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {  }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {  }

        private void pictureBox1_Click(object sender, EventArgs e)
       {
            
        }

       
    }
}
