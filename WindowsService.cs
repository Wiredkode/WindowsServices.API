using System;

namespace WindowsServices.API
{
    public enum WindowsServiceStatus {
        Started=1
    }
    public class WindowsService
    {
        public string Name { get; set; }
        public WindowsServiceStatus Status { get; set; }

    }
}
