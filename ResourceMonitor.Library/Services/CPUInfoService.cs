using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using ResourceMonitor.Library.Enums;
using ResourceMonitor.Library.Entities;

namespace ResourceMonitor.Library.Services
{
    public class CPUInfoService : IResourceService<CPUInfoData>
    {


        public CPUInfoData GetBasicInfo()
        {
            CPUInfoData info = new CPUInfoData();
            info.Proccessor = GetCpuInfo(CPUInfoCodes.Processor);
            info.Memory = GetCpuInfo(CPUInfoCodes.Memory);
            info.User = GetCpuInfo(CPUInfoCodes.User);
            info.TimeZone = GetCpuInfo(CPUInfoCodes.TimeZone);

            return info;
        }

        public CPUInfoData GetAdvancedInfo()
        {
            CPUInfoData info = new CPUInfoData();
            info.Proccessor = GetCpuInfo(CPUInfoCodes.Processor);
            info.Memory = GetCpuInfo(CPUInfoCodes.Memory);
            info.User = GetCpuInfo(CPUInfoCodes.User);
            info.Keyboard = GetCpuInfo(CPUInfoCodes.Keyboard);
            info.Sound = GetCpuInfo(CPUInfoCodes.Sound);
            info.Video = GetCpuInfo(CPUInfoCodes.Video);
            info.BIOS = GetCpuInfo(CPUInfoCodes.Bios);
            info.Cache = GetCpuInfo(CPUInfoCodes.CacheMemory);

            return info;
        }

        public CPUInfoData GetData()
        {
            return GetBasicInfo();
        }

        private string GetCpuInfo(string code)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + code);
            foreach (ManagementObject share in searcher.Get())
            {
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
