using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ClassroomWork_23_09
{
    public class ATM
    {
        private BankAccount bankAccount;
        public ATM(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }
        public void WithdrawMoney(double money)
        {
            try
            {
                bankAccount.Withdraw(money);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DepositMoney(double money)
        {
            try
            {
                bankAccount.Deposit(money);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
