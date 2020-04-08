using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat
{
    public static class SocketConnection
    {
        public static Socket ServerSocket;
        static string ServerHost = "localhost";
        static int ServerPort = 8888;
        public static string Login { get; set; }
        static CancellationTokenSource cts = new CancellationTokenSource();
        public static LoginWindow LoginWindow { get; set; }
        public static MainWindow MainWindow { get; set; }

        static SocketConnection()
        {
            Task.Run(() => Listener(cts.Token));
        }

        public static async Task Connect(CancellationToken ct)
        {
            try {
                IPHostEntry ipHost = Dns.GetHostEntry(ServerHost);
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, ServerPort);
                ct.ThrowIfCancellationRequested();
                ServerSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                ServerSocket.Connect(ipEndPoint);
                if (MainWindow != null) MainWindow.IsLostConnection = false;
                await SetName();
                LoginWindow.StateChanger_1();
                await Listener(ct);
            }
            catch (Exception exp) {
                LoginWindow.StateChanger_2();
                await Task.Delay(500);
                await Connect(ct);
            }
        }

        public static async Task Listener(CancellationToken ct)
        {
            try {
                await Task.Delay(500);
                byte[] buff = new byte[] { };
                ct.ThrowIfCancellationRequested();
                int a = ServerSocket.Receive(buff);
                await Listener(ct);
            }
            catch (Exception exp) {
                await Connect(ct);
            }
        }

        public static void Send(string data)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            int bytesSent = ServerSocket.Send(buffer);
        }

        public static bool IsLogged { get; set; } = false;
        public async static Task SetName()
        {
            if (IsLogged) {
                Send("#setname&" + Login);
                await Task.Delay(1000);
                Send("#newmsg&" + "Присоединился к чату");
            }
        }
    }
}
