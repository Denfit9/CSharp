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
        public Delegate(int money)
        {
            Payment = money;
        }
        public void Have(int money)
        {
            Payment = money;

        }
        public void Payed(int money)
        {
            if (Payment > money)
            {
                Payment= Payment - money;
                notify.Invoke("You just paid " + money + " for fun");
            }
            else
            { notify.Invoke("Not enough money"); }
        }
        public void Added(int money)
        {
            notify1.Invoke("You added " + money + " $");
            Payment = Payment + money;
        }
    }
}
