﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Prft.Talent.Logger
{
    public interface IPrftLogger
    {
        void Log(Exception ex, string message);
    }
}
