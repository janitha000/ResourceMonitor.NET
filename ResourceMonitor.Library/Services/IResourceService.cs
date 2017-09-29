﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMonitor.Library.Services
{
    interface IResourceService<TUsageData>
    {
        TUsageData GetData();
    }
}
