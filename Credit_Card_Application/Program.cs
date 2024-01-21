using System;

namespace Credit_Card_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clients c1 = new Clients(605, 21000, 560, 4, 5, 21000 / 12);
            Clients c2 = new Clients(610, 18000, 500, 10, 14, 18000 / 12);
            Clients c3 = new Clients(614, 35000, 750, 2, 10, 35000 / 12);
            Clients c4 = new Clients(656, 11000, 280, 20, 19, 11000 / 12);
            Clients c5 = new Clients(678, 15500, 400, 6, 2, 15500 / 12);
            Clients c6 = new Clients(692, 8000, 200, 10, 11, 8000 / 12);
            Clients c7 = new Clients(694, 32000, 850, 3, 3, 32000 / 12);
            Clients c8 = new Clients(697, 12500, 375, 4, 6, 12500 / 12);
            Clients c9 = new Clients(698, 40000, 950, 15, 8, 40000 / 12);
            Clients c10 = new Clients(700, 20000, 395, 5, 5, 20000 / 12);
            c1.IsEligibleForCreditCard();
            c2.IsEligibleForCreditCard();
            c3.IsEligibleForCreditCard();
            c4.IsEligibleForCreditCard();
            c5.IsEligibleForCreditCard();
            c6.IsEligibleForCreditCard();
            c7.IsEligibleForCreditCard();
            c8.IsEligibleForCreditCard();
            c9.IsEligibleForCreditCard();
            c10.IsEligibleForCreditCard();
        }
    }
}
