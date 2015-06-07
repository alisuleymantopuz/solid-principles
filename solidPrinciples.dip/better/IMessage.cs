using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solidPrinciples.dip.better
{
    public interface IMessage
    {
        string To { get; set; }
        string Subject { get; set; }
        string Content { get; set; }
    }
}
