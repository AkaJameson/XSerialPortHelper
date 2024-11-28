using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace XPorter.Infrastructure.Abstraction
{
    public interface IXSerialPort
    {
        /// <summary>
        /// 创建一个串口对象
        /// </summary>
        /// <returns></returns>
        SerialPort GetSerialPort();

        void Open();

        void Close();

        Task WriteAsync(byte[] data);

        Task<byte[]> ReadAsync();

        bool IsOpen();

        event EventHandler<byte[]> DataReceived;

        event EventHandler<SerialErrorReceivedEventArgs> ErrorOccurred;
    }
}
