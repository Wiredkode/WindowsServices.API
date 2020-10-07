using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WindowsServices.API;

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
        public WindowsService Get()
        {
            var ret=new WindowsServices.API.WindowsService{Name="teste",Status=WindowsServiceStatus.Started};
            return ret;
        }
    }
}
