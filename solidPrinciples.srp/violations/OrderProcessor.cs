using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.srp.violations
{
    public class OrderProcessor
    {
        public Result Process(Product product)
        {
            if (product.UnitsInStock > 0)
            {
                return Result.Success;
            }

            return Result.Failure;
        }
    }
}
