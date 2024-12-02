using System.IO.Ports;
using XPorter.Infrastructure.Models;
using XPorter.Infrastructure.Services;

namespace XPorter.Application.FormEvent
{
    public class PortFormEvent
    {
        public PortFormEvent()
        {
            
        }
        public bool PortStatus(string portName)
        {
            return XSerialPortFactory.CheckSerialStatus(portName);
        }

        public bool CreateXPort(XPortConfig xPortConfig)
        {
            if(!XSerialPortFactory.HasBeenCreate(xPortConfig.PortName))
            {
                XSerialPortFactory.CreateSerialPort(new XPortConfig()
                {
                    BaudRate = xPortConfig.BaudRate,
                    StopBits = xPortConfig.StopBits,
                    Parity = xPortConfig.Parity,
                    PortName = xPortConfig.PortName,
                    DataBits = xPortConfig.DataBits,
                });
            }
            else if(XSerialPortFactory.CheckSerialStatus(xPortConfig.PortName)== false)
            {
                XSerialPortFactory.CreateSerialPort
            }
            {
                return false;
            }
        }


    }
}
