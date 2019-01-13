using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using homework4_2;

namespace homework5_1
{
    public class OrderDetails2 : OrderService
    {
        public OrderDetails2(List<Order> orderlists) : base(orderlists)
        {
        }

        public Order SearchOrder1(int number)
        {
            var target =
                from Orderlist in Orderlists
                where (Orderlist.Number) == number
                select Orderlist;
            return (Order)target;

        }
        public Order SearchOrder2(string customers)
        {
            var target =
            from Orderlist in Orderlists
            where (Orderlist.Customers) == customers
            select Orderlist;
            return (Order)target;


        }
        public Order SearchOrder3()
        {
            var target =
                from Orderlist in Orderlists
                where (Orderlist.Moneyamount) > 10000
                select Orderlist;
            return (Order)target;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
