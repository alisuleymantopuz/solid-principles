using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.dip.better
{
    public class MessageService : IMessageService
    {
        public ISender Sender { get; private set; }
        public MessageService(ISender sender)
        {
            Sender = sender;
        }

        public void SendMail(IMessage message)
        {
            this.Sender.Send(message);
        }
    }
}
