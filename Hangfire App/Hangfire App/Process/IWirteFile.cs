﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire_App.Process
{
    public interface IWirteFile
    {
        void Write(string msg);
    }
}
