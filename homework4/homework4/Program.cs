using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework4
{
    class Alarm
    {
        public string Tips;
        
        private DateTime dt;
        DateTime now = DateTime.Now;
        public delegate void Beep(string ddtt);
        public event Beep beepevent;
        public Alarm(int hour, int minute, string tips)
        {
            dt = new DateTime(2018, 10, 8, hour, minute, 0);
            Tips = tips;
        }
        public void BBBBB()
        {
            while (true)
            {
                now = DateTime.Now;

                if ((now.Hour == dt.Hour) && (now.Minute == dt.Minute))
                    if (beepevent != null)
                    {
                        beepevent(Tips);break;
                    }
            }
          
        }

    }
    
    public class BEEP
    {
        int i = 1;
        
        public void Beepbeep(string ddtt)
        {

            Console.WriteLine(ddtt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alarm Getup = new Alarm(12, 05, "起床啦！");

            BEEP ppp = new BEEP();
            Getup.beepevent += ppp.Beepbeep;
            Getup.BBBBB();
        }
    }
}
