using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.isp.violations
{
    public interface IMessage
    {
        IList<String> To { get; set; }
        string Body { get; set; }
        string Subject { get; set; }
        IList<String> Cc { get; set; }
        IList<String> Bcc { get; set; }

        MessageSendResult Send();
    }
}
