using System;

namespace XPorter.Infrastructure.Exceptions
{
    public class DeviceNoPortException:Exception
    {
        public DeviceNoPortException()
        {
            
        }
        public DeviceNoPortException(string message):base(message)
        {
            
        }
        public DeviceNoPortException(string message, Exception inner)
           : base(message, inner)
        {
        }

    }
}
