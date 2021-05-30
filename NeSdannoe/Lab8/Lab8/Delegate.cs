using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Delegate
    {
        public delegate void Message(string mess);
        public event Message notify;
        public event Message notify1;
        public int Payment { get; private set; }
     //   public int Oplata1 { get; private set; }
        public Delegate(int m)
        {
            Payment = m;

        }
        public void Have(int m)
        {
            Payment = m;

        }
        public void Payed(int m)
        {
            if (Payment > m)
            {
                Payment= Payment- m;
                notify.Invoke("You just paid " + m + " for fun");
            }
            else
            { notify.Invoke("Not enough money"); }
        }
        public void Added(int m)
        {
            notify1.Invoke("You added " + m + " $");
            Payment = Payment + m;
        }
    }
}
