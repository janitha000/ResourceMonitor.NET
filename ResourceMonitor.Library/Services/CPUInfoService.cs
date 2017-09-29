using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ResourceMonitor.Library.Services
{
    public class CPUInfoService
    {
        public string  GetCpuInfo()
        {
            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_OperatingSystem");
            return objMOS.ToString();
        }
    }
}
