﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tm.Model;

namespace TM.Service.Declare
{
    interface IProcessMRChange
    {
        void ProcessMrPayload(MRChangePayload mRChangePayload);
    }
}
