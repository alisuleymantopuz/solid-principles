using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.ocp.violations
{
    public class DepositAccount
    {
        private decimal _activeBalance;

        public void PayInProcess(decimal amount)
        {
            _activeBalance -= amount;
        }
    }

}
