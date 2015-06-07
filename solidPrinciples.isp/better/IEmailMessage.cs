using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.isp.better
{
    public interface IEmailMessage : IMessage
    {
        IList<String> Cc { get; set; }
        IList<String> Bcc { get; set; }
    }
}
