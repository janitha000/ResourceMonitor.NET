using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using ResourceMonitor.Library.Enums;

namespace ResourceMonitor.Library.Services
{
    public class CPUInfoService
    {
        public string  GetCpuInfo(string code)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher( "select * from " + code);
            foreach (ManagementObject share in searcher.Get())
            {
                // Some Codes ...
                foreach (PropertyData PC in share.Properties)
                {
                    Console.WriteLine("DD");
                    return PC.Name;

                }
            }
            return searcher.ToString();
        }
    }
}
