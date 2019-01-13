using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework4_2
{
    public class Order
    {
        static int i = 1;
        public int Number;
        public int Moneyamount;
        public string Goods;//尝试用枚举类型
        public string Customers;

        public Order(string customers, string goods)
        {
            this.Number = i; i++;
            this.Goods = goods;
            this.Customers = customers;
            this.Moneyamount = 0;
        }

    }

    public class OrderService {
        public List<Order> Orderlists = new List<Order>();

        public OrderService(List<Order> orderlists)
        {
            Orderlists = orderlists;
        }

        public void AddOrder(string customers, string goods)
        {
            Order another = new Order(customers,goods);
            Orderlists.Add(another);
        }
        public void DeleteOrder1(int number)
        {
            try
            {
                for (int i = 0; i < Orderlists.Count; i++)
                {
                    if (Orderlists[i].Number == number)
                        Orderlists.Remove(Orderlists[i]);
                }
            }
            catch { Console.WriteLine("无效的删除"); }
        }
        public void DeleteOrder2(string customers)
        {
            try
            {
                for (int i = 0; i < Orderlists.Count; i++)
                {
                    if (Orderlists[i].Customers == customers)
                        Orderlists.Remove(Orderlists[i]);
                }
            }
            catch { Console.WriteLine("无效的删除"); }

        }
    }
    public class OrderDetails :OrderService{
        public OrderDetails(List<Order> orderlists) : base(orderlists)
        {
        }

        public Order SearchOrder1(int number)
        {
            int i;
            for (i = 0; i < Orderlists.Count; i++)
            {
                if (Orderlists[i].Number == number)
                    break;
            }
            return Orderlists[i];
        }
        public Order SearchOrder2(string customers)
        { int i;
            for ( i = 0; i < Orderlists.Count; i++)

                if (Orderlists[i].Customers == customers) break;
                    return Orderlists[i];
            
        }
        public void AmendOrder(string customer, string goods)
        {
            try
            {
                for (int i = 0; i < Orderlists.Count; i++)
                {
                    if (Orderlists[i].Customers == customer) Orderlists[i].Goods = goods;
                }
            }
            catch { Console.WriteLine("无效的修改"); }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orderlists = new List<Order>();
            Order s1 = new Order("liiii", "apple");
            Order s2 = new Order("wang", "banana");
            orderlists.Add(s1); orderlists.Add(s2);

            OrderService lll = new OrderService(orderlists);
        }
    }
}
