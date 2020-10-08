using System;
using System.ServiceProcess;

namespace WindowsServices.API
{
    public enum WindowsServiceStatus {
        Started=1
    }
    public class WindowsService
    {
        public string Name { get; set; }
        public ServiceControllerStatus Status { get; set; }

    }
}
