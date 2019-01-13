using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using homework4_2;

namespace homewprk6
{
    public class OrderService2 : OrderService
    {
        public OrderService2(List<Order> orderlists):base(orderlists)
        {
            Orderlists = orderlists;
        }

        public void Export(String fpath)
        {
            //fpath = @"E:\\CSharpHomework\\Order.xml";
            //创建XmlDocument对象
            XmlDocument xmlDoc = new XmlDocument();
            //XML的声明<?xml version="1.0" encoding="gb2312"?> 
            XmlDeclaration xmlSM = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //追加xmldecl位置
            xmlDoc.AppendChild(xmlSM);
            //添加一个名为Orderlist的根节点
            XmlElement xml = xmlDoc.CreateElement("", "Orderlists", "");
            //追加Orderlist的根节点位置
            xmlDoc.AppendChild(xml);
            //添加另一个节点,与Gen所匹配，查找<Gen>
            XmlNode gen = xmlDoc.SelectSingleNode("Orderlists");
            for (int i = 0; i < 2; i++)
            {
                //添加一个名为<Zi>的节点   
                XmlElement zi = xmlDoc.CreateElement("Order");
                //为<Zi>节点的属性
                zi.SetAttribute("Number", Orderlists[i].Number.ToString());
                zi.SetAttribute("name", Orderlists[i].Customers);
                XmlElement x1 = xmlDoc.CreateElement("Moneyamount");
                //InnerText:获取或设置节点及其所有子节点的串连值
                x1.InnerText = "0";
                zi.AppendChild(x1);//添加到<Zi>节点中
                XmlElement x2 = xmlDoc.CreateElement("goods");
                x2.InnerText = Orderlists[i].Goods;
                zi.AppendChild(x2);
                gen.AppendChild(zi);
            }
            xmlDoc.Save(fpath);

        }
        public void Import(String fpath) {
            try
            {
                List<Order> myol = new List<Order>();
                XmlDocument myxmlDoc = new XmlDocument();
                myxmlDoc.Load(fpath);
                XmlNode Orderlists = myxmlDoc.SelectSingleNode("Orderlists");
                XmlNodeList packet = Orderlists.ChildNodes;
                int i = 0;
                foreach (XmlNode p in packet)
                {
                    XmlElement xe = (XmlElement)p;
                    //将根结点的孩子结点转换为一个XmlElement元素
                    XmlNodeList xnL = xe.ChildNodes;
                    int j = 0;
                    foreach (XmlNode x in xnL)
                    {
                        string chi = x.FirstChild.InnerText.Replace("\"", "");
                        Console.WriteLine(chi);
                        i++;j++;
                    }
                }
                    //for(int i=0;i<myxmlDoc.)
                    Console.WriteLine(myxmlDoc.InnerText);




            }
            catch (Exception ex)
            {
                Console.WriteLine("出错了" + ex.StackTrace);
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            List<Order> orderlists = new List<Order>();
            Order s1 = new Order("liiii","apple");
            Order s2 = new Order("wang", "banana");
            orderlists.Add(s1); orderlists.Add(s2);
            OrderService2 p = new OrderService2(orderlists);
            //p.Export("E:\\CSharpHomework\\homewprk6\\Order1.xml");
            p.Import("E:\\CSharpHomework\\homewprk6\\Order1.xml");            
        }
    }
}
