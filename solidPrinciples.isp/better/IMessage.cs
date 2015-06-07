using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.isp.better
{
    public interface IMessage
    {
        IList<String> To { get; set; }
        string Body { get; set; }
        string Subject { get; set; }

        MessageSendResult Send();
    }
}
