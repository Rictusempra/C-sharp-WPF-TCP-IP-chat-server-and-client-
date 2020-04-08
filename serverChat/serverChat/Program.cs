using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace serverChat
{
    class Program
    {

        private const string _serverHost = "localhost";
        private const int _serverPort = 8888;
        private static Thread _serverThread;

        static void Main(string[] args)
        {
            _serverThread = new Thread(startServer);
            _serverThread.IsBackground = true;
            _serverThread.Start();
            while (true) Console.ReadLine();
        }


        private static void startServer()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(_serverHost);
            IPAddress ipAddress = ipHost.AddressList[0];
           // IPAddress ipAddress = IPAddress.Parse(_serverHost);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, _serverPort);
            Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipEndPoint);
            socket.Listen(1000);
            Console.WriteLine("Сервер запущен по IP: {0}.", ipEndPoint);
            while (true) {
                try {
                    Socket user = socket.Accept();
                    Server.NewClient(user);
                }
                catch (Exception exp) { Console.WriteLine("Ошибка: {0}", exp.Message); }
            }
        }
    }
}
