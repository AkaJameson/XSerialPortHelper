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
        /// <summary>
        /// 创建串口
        /// </summary>
        /// <param name="portConfig"></param>
        /// <returns></returns>
        /// <exception cref="DeviceNoPortException"></exception>
        /// <exception cref="PortAlreadyExistExcetpion"></exception>
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
        public static bool OpenXSerialPort(string xportName)
        {
            if (!SerialPortDictionary.ContainsKey(xportName))
            {
                throw new System.Exception("该串口未创建");
            }
            if (CheckSerialStatus(xportName))
            {
                return true;
            }
            if(!SerialPortDictionary.TryGetValue(xportName, out var result))
            {
                throw new System.Exception("出现未知错误");
            }
            result.Open();

        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="portName"></param>
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
        /// <summary>
        /// 检查串口状态
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public static bool CheckSerialStatus(string portName)
        {
            if(!SerialPortDictionary.ContainsKey(portName))
            {
                return false;
            }
            else
            {
                SerialPortDictionary.TryGetValue(portName, out var result);
                return result.IsOpen();
            }
        }
        /// <summary>
        /// 获取串口
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>

        public static XSerialPort GetXSerialPort(string portName)
        {
            SerialPortDictionary.TryGetValue(portName, out var result);
            return result;
        }

        public static bool HasBeenCreate(string portName)
        {
            return SerialPortDictionary.ContainsKey(portName);
        }
    }
}
