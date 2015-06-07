using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.isp.violations
{
    public class SmtpMessage : IMessage
    {
        public IList<string> To { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }


        public IList<string> Cc
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<string> Bcc
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public MessageSendResult Send()
        {
            //Sms send operations
            return MessageSendResult.Success;
        }


    }
}
