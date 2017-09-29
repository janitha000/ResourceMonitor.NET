using ResourceMonitor.Library.Entities;
using ResourceMonitor.Library.Enums;
using ResourceMonitor.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ResourceMonitor.Controllers
{
    public class CPUController : ApiController
    {
        [HttpGet]
        [Route("api/CPU/cpuinfo")]
        public string GetCPUInfo()
        {

            try
            {
                CPUInfoService cpuInfo = new CPUInfoService();
                string info = cpuInfo.GetCpuInfo(CPUInfoCodes.CacheMemory);
                return info;


            }
            catch (Exception ex)
            {
                
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.InternalServerError));
            }
        }
    }
}
