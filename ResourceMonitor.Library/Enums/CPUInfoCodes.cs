﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMonitor.Library.Enums
{
    public class CPUInfoCodes
    {
        //https://www.codeproject.com/Articles/17973/How-To-Get-Hardware-Information-CPU-ID-MainBoard-I
        public const string BaseBoard = "Win32_BaseBoard";
        public const string Battery = "Win32_Battery";
        public const string Bios = "Win32_BIOS";
        public const string CacheMemory = "Win32_CacheMemory";
        public const string CDROM = "Win32_CDROMDrive";
        public const string Disk = "Win32_DiskDrive";
        public const string Keyboard = "Win32_Keyboard";
        public const string Memory = "Win32_MemoryDevice";
        public const string Processor = "Win32_Processor";
        public const string Sound = "Win32_SoundDevice";
        public const string SystemBIOS = "Win32_SystemBIOS";
        public const string TimeZone = "Win32_TimeZone";
        public const string User = "Win32_UserAccount";
        public const string Video = "Win32_VideoController";

    }
}
