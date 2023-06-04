using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    internal class Person
    {
        public string Name;
        public int Money;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }

        public void borrow(Person lender,int money)
        {
            lender.Money -= money;
            this.Money += money;
        }

        public void repay(Person lender, int money)
        {
            this.Money -= money;
            lender.Money += money;
        }

    }
}
