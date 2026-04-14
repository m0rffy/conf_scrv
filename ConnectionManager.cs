using NModbus;
using System.Net;
using System.Net.Sockets;

namespace Uetm_2_0
{
    public class ConnectionManager
    {
        private static Tuple<TcpClient, IModbusMaster>? _connection;

        public static Tuple<TcpClient, IModbusMaster> OpenConnection(string ipAddress, int modBusPort)
        {
            if (_connection != null)
                throw new InvalidOperationException("Соединение уже открыто.");

            if (!IPAddress.TryParse(ipAddress, out _))
                throw new ArgumentException("Некорректный IP-адрес.");

            if (modBusPort < 0 || modBusPort > 65000)
                throw new ArgumentOutOfRangeException(nameof(modBusPort), "Порт должен быть в диапазоне от 0 до 65500.");

            TcpClient tcpClient = new TcpClient();
            try
            {
                IAsyncResult result = tcpClient.BeginConnect(ipAddress, modBusPort, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(5000); // 5 секунд
                if (!success)
                {
                    tcpClient.Close();
                    throw new TimeoutException("Не удалось подключиться к устройству.");
                }
                tcpClient.EndConnect(result);

                var factory = new ModbusFactory();
                IModbusMaster modbusMaster = factory.CreateMaster(tcpClient);
                _connection = new Tuple<TcpClient, IModbusMaster>(tcpClient, modbusMaster);
                return _connection;
            }
            catch (Exception)
            {
                tcpClient.Close();
                throw;
            }
        }

        public static void CloseConnection()
        {
            if (_connection != null)
            {
                try
                {
                    _connection.Item1.Client.Shutdown(SocketShutdown.Both);
                }
                catch { }
                _connection.Item1.Close();
                _connection = null;
            }
        }

    }
}
