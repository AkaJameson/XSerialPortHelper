using System;
using System.IO.Ports;
using System.Threading.Tasks;
using XPorter.Infrastructure.Abstraction;
using XPorter.Infrastructure.Models;

namespace XPorter.Infrastructure.Components
{
    public class XSerialPort : IXSerialPort, IDisposable
    {
        private SerialPort _serialPort;

        public event EventHandler<byte[]> DataReceived;
        public event EventHandler<SerialErrorReceivedEventArgs> ErrorOccurred;
        public XSerialPort(XPortConfig xPortConfig)
        {
            _serialPort = new SerialPort(xPortConfig.PortName, xPortConfig.BaudRate, xPortConfig.Parity, xPortConfig.DataBits, xPortConfig.StopBits);
        }

        public SerialPort GetSerialPort()
        {
            return _serialPort;
        }
        public void Open()
        {
            if (_serialPort != null && !_serialPort.IsOpen)
            {
                _serialPort.Open();
                _serialPort.DataReceived += OnDataReceived;
                _serialPort.ErrorReceived += OnErrorReceived;
            }
        }

        public void Close()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.DataReceived -= OnDataReceived;
                _serialPort.ErrorReceived -= OnErrorReceived;
                _serialPort.Close();
            }
        }

        public async Task WriteAsync(byte[] data)
        {
            if (_serialPort?.IsOpen == true)
            {
                await Task.Run(() => _serialPort.Write(data, 0, data.Length));
            }
        }

        public async Task<byte[]> ReadAsync()
        {
            if (_serialPort?.IsOpen == true)
            {
                return await Task.Run(() =>
                {
                    byte[] buffer = new byte[_serialPort.BytesToRead];
                    _serialPort.Read(buffer, 0, buffer.Length);
                    return buffer;
                });
            }
            return Array.Empty<byte>();
        }

        public bool IsOpen()
        {
            return _serialPort?.IsOpen == true;
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_serialPort != null && _serialPort.BytesToRead > 0)
            {
                byte[] buffer = new byte[_serialPort.BytesToRead];
                _serialPort.Read(buffer, 0, buffer.Length);
                DataReceived?.Invoke(this, buffer);
            }
        }

        private void OnErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            ErrorOccurred?.Invoke(this, e);
        }

        public void Dispose()
        {
            _serialPort.Dispose();
            _serialPort = null;
        }
    }
}
