using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.dip.violations
{
    public class MessageService
    {
        public MessageSender MessageSender { get; private set; }

        public MessageService(MessageSender messageSender)
        {
            this.MessageSender = messageSender;
        }

        public void SendMail(string message, object customerInfo)
        {
            this.MessageSender.SendMessage(message, customerInfo);
        }
    }
}
