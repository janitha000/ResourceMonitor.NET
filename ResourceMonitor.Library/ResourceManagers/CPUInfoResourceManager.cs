using ResourceMonitor.Library.Entities;
using ResourceMonitor.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMonitor.Library.ResourceManagers
{
    class CPUInfoResourceManager
    {
        private CPUInfoService service = new CPUInfoService();

        public CPUInfoData GetData(string type)
        {
            if(type == "basic")
            {
                return service.GetBasicInfo();
            }
            else if(type == "advanced")
            {
                return service.GetAdvancedInfo();
            }
            else
            {
                return null;
            }

        }
    }
}
