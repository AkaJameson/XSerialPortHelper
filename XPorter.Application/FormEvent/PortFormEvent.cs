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
                XSerialPortFactory.CreateSerialPort(xPortConfig);
                return true;
            }
            else if(XSerialPortFactory.CheckSerialStatus(xPortConfig.PortName)== false)
            {
                XSerialPortFactory.CreateSerialPort(xPortConfig);
                OpenPort(xPortConfig.PortName);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OpenPort(string portName)
        {
            if (XSerialPortFactory.HasBeenCreate(portName))
            {
                XSerialPortFactory.OpenXSerialPort(portName);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ClosePort(string portName)
        {
            if (XSerialPortFactory.HasBeenCreate(portName))
            {
                XSerialPortFactory.CloseSerialPort(portName);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CloseAllPort()
        {
            XSerialPortFactory.CloseAllPort();
            return true;
        }

    }
}
