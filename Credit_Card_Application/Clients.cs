using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Application
{
    internal class Clients
    {
        public int applicationNumber;
        public int salary;
        public int rent;
        public int yearsEmployed;
        public int yearsResiding;
        public int monthSalary;
        public Clients(int applicationNumber, int salary, int rent, int yearsEmployed, int yearsResiding, int monthSalary)
        {
            this.applicationNumber = applicationNumber;
            this.salary = salary;
            this.rent = rent;
            this.yearsEmployed = yearsEmployed;
            this.yearsResiding = yearsResiding;
            this.monthSalary = monthSalary;
        }
        public void IsEligibleForCreditCard()
        {
            if (salary > 25000 ||
                (salary > 20000 && rent < monthSalary / 4) ||
                (salary > 15000 && yearsResiding > 5) ||
                (salary > 10000 && yearsEmployed > 3 && yearsResiding > 5))
            {
                Console.WriteLine("Client {0} is eligible.", applicationNumber);
            }
        }
    }
}
