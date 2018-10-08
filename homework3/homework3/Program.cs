using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace homework3
{
    public abstract class Graphics
    {
        public string type;
        public Graphics()
        {
            
        }
        public abstract double GetArea();
        public void telling() {
            Console.WriteLine("This is a graphic of " + type +
           "\n" + "Its area is " + GetArea());
        }   
    }
    public class Circles : Graphics
    {
        public int radius;
        public Circles(int radius)
        {
            type = "circle";
            this.radius = radius;
            telling();
        }
        public override double GetArea()
        {
            return (radius * radius*Math.PI);
        }
    }
    public class Squares : Graphics
    {
        public int quadrate;
        public Squares (int quadrate)
        {
            this.type = "square";
            this.quadrate = quadrate;
            telling();
        }
        public override double GetArea()
        {
            return quadrate * quadrate * 1.0;
        }
    }
    public class Rectangulars:Graphics
    {
        int edge_1,edge_2;
        public Rectangulars(int edge_1,int edge_2)
        {
            this.type = "rectangular";
            this.edge_1= edge_1;
            this.edge_2 = edge_2;
            telling();
        }
        public override double GetArea()
        {
            return (edge_1 * edge_2 * 1.0);
        }
    }
    public class Triangles : Graphics
    {

        int edge_1, edge_2,edge_3;
        public Triangles (int edge_1,int edge_2,int edge_3)
        {
            this.type = "triangle";
            this.edge_1 = edge_1;
            this.edge_2 = edge_2;
            this.edge_3 = edge_3;
            telling();
        }
        public override double GetArea()
        {
            int p = (edge_3 + edge_1 + edge_2) / 2;
            p = p * (p - edge_3) * (p - edge_1) * (p - edge_2);
            return (System.Math.Sqrt(p));
        }
    }
    public class DrawGraphics
    {
        Graphics graphic;
        public DrawGraphics()
        {
            Console.WriteLine("Which type of graphic do you want to draw ?\n" +
               "A.circle   B.square   C.rectangular   D.triangle" +
               "\nPlease enter your options");
            string s = Console.ReadLine();Options(s);Options_1(s);
            
        }
        public void Options(string s)
        {
            string option = null;
            if (s == "A") option = " radius";
            else if (s == "B") option = " quadrate";
            else if (s == "C") option = " oblong and width";
            else if (s == "D") option = " three sides, respectively";
            else option = " nothing";
            Console.WriteLine("Please enter the length of" + option);
            
        }
        public void Options_1(string s)
        {
            
            if (s == "A")
                this.graphic = new Circles(Convert.ToInt32(Console.ReadLine()));
            else if (s == "B")
                this.graphic = new Squares(Convert.ToInt32(Console.ReadLine()));
            else if (s == "C")
                this.graphic = new Rectangulars(Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine()));
            else 
                this.graphic = new Triangles(Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine()));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DrawGraphics A = new DrawGraphics();
         }

        
    }
}
