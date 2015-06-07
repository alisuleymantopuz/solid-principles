﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.isp.better
{
    public class SmsMessage : IMessage
    {
        public IList<string> To { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }


        public MessageSendResult Send()
        {
            //Sms send operations
            return MessageSendResult.Success;
        }
    }
}
