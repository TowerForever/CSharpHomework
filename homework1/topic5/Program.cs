using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//编写一个Windows应用程序，从两个文本框中接收两个数字，然后计算这两个数字的积
namespace topic5
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
