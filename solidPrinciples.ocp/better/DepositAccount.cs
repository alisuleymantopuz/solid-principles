using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.ocp.better
{
    public class DepositAccount : Account
    {
        private decimal _activeBalance;

        public override void PayIn(decimal amount)
        {
            _activeBalance += amount;
        }
    }
}
