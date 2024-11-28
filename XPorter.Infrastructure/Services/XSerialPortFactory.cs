using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using XPorter.Infrastructure.Components;
using XPorter.Infrastructure.Exceptions;
using XPorter.Infrastructure.Models;

namespace XPorter.Infrastructure.Services
{
    public static class XSerialPortFactory
    {
        private static readonly Dictionary<string,XSerialPort> SerialPortDictionary = new Dictionary<string, XSerialPort>();
        /// <summary>
        /// 获取所有可用串口名称
        /// </summary>
        public static string[] SerialPortNames { get => SerialPort.GetPortNames(); }

        public static XSerialPort CreateSerialPort(XPortConfig portConfig)
        {
            if (!SerialPortNames.Contains(portConfig.PortName))
            {
                throw new DeviceNoPortException("当前设备没有该串口！");
            }
            if (SerialPortDictionary.ContainsKey(portConfig.PortName))
            {
                throw new PortAlreadyExistExcetpion("该串口已经被创建");
            }
            try
            {
                var serialPort = new XSerialPort(portConfig);
                SerialPortDictionary.Add(portConfig.PortName, serialPort);
                return serialPort;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static void CloseSerialPort(string portName)
        {
            if (SerialPortDictionary.ContainsKey(portName))
            {
                var serialPort = SerialPortDictionary[portName];
                serialPort.Close();
                serialPort.Dispose();
                SerialPortDictionary.Remove(portName);
            }
        }

    }
}
