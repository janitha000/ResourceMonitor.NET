using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ResourceMonitor.Library.Services
{
    class CPUInfo
    {
        ManagementObjectSearcher objMOS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_OperatingSystem");
    }
}
