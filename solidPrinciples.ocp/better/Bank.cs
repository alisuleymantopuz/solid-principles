using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.ocp.better
{
    public class Bank
    {
        public void GetMoney(Account account, decimal amount)
        {
            account.PayIn(amount);
        }
    }
}
