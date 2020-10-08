using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WindowsServices.API;
using System.ServiceProcess;


namespace WindowsServices.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WindowsServiceController : ControllerBase
    {
        private readonly ILogger<WindowsServiceController> _logger;

        public WindowsServiceController(ILogger<WindowsServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public WindowsService Get(string serviceName, string username, string password, int operation)
        {
            try
            {
                ServiceController[] services = ServiceController.GetServices();
                ServiceController service = services.First<ServiceController>(x => x.ServiceName == serviceName);
                service.Stop();
                //service.Stop();

                var ret = new WindowsServices.API.WindowsService { Name = serviceName, Status = ServiceControllerStatus.Running };
                return ret;
            }
            catch (Exception e)
            {
                var ret = new WindowsServices.API.WindowsService { Name = e.Message, Status = ServiceControllerStatus.Running };
                Console.WriteLine(e.StackTrace);
                return ret;
            }
        }
    }
}