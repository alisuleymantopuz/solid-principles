using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.srp.better
{
    public class OrderProcessor
    {
        public Result Process(Product product, OrderSpecifications orderSpecifications)
        {
            //checking business rules
            orderSpecifications.Validate(product);

            //order process

            return Result.Success;
        }
    }
}
