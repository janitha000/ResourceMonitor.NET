using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResourceMonitor.Library.Entities;
using ResourceMonitor.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMonitor.Library.Services.Tests
{
    [TestClass()]
    public class CPUInfoServiceTests
    {
        [TestMethod()]
        public void GetBasicInfoTest()
        {
            CPUInfoService service = new CPUInfoService();
            CPUInfoData info = service.GetBasicInfo();

            Assert.AreNotEqual(null, info, "CPUInfo is should not be null");
        }

        [TestMethod()]
        public void GetAdvancedInfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDataTest()
        {
            Assert.Fail();
        }
    }
}