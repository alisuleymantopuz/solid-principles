using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.lsp.better
{
    public class SecurePayment : PaymentBase, IVerifiablePayment
    {
        private string _tokenInformation = "";

        public override void Pay(decimal amount, object customerInfo)
        {
            SecurePaymentTokenValidate(_tokenInformation);
            //pay operations with _tokenInformation

        }

        public void PayWithToken(decimal amount, object customerInfo)
        {
            this.Verify(customerInfo);

            this.Pay(amount, customerInfo);
        }

        private void SecurePaymentTokenValidate(string tokenInformation)
        {
            if (string.IsNullOrEmpty(tokenInformation))
            {
                throw new Exception("Token can not be null or empty..");
            }
        }

        public void Verify(object customerInfo)
        {
            //first, have to get a token

            //for instance, call an external service and populate tokent with customerInformations

            this._tokenInformation = Guid.NewGuid().ToString();
        }

    }
}
