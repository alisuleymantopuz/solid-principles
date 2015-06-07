using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.ocp.violations
{
    public class Bank
    {
        public void GetMoney(object account, decimal amount)
        {
            if (account.GetType() == typeof(CheckingAccount))
            {
                CheckingAccount checkingAccount = (CheckingAccount)account;
                checkingAccount.PayInProcess(amount);
            }
            else if (account.GetType() == typeof(DepositAccount))
            {
                DepositAccount mortgageAccount = (DepositAccount)account;
                mortgageAccount.PayInProcess(amount);
            }
        }
    }
}
