using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ClassroomWork_23_09
{
    public class BankAccount
    {
        private double _funds;//кошти

        public BankAccount() //конструктор
        {
            _funds = 0;
        }
        public void Deposit(double cash) //поповнення
        {
            if (cash < 0)
            {
                throw new ArgumentException("Неможливо внести відємну суму!");
            }
            _funds += cash;
        }
        public void Withdraw(double cash) //списання
        {
            if (cash < 0)
            {
                throw new ArgumentException("Неможливо зняти відємну суму!");
            }
            else if (cash > _funds)
            {
                throw new InsufficientFundsException("Недостатньо коштів на рахунку!");
            }
            _funds -= cash;
        }
    }
}
