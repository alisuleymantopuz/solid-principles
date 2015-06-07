﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPrinciples.ocp.better
{
    public abstract class Account
    {
        public abstract void PayIn(decimal amount);
    }
}
