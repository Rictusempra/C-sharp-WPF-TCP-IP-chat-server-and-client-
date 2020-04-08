using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace serverChat
{
    public class Client
    {
        private string _userName;
        private Socket _handler;
        private Thread _userThread;

        public Client(Socket socket)
        {
            _handler = socket;
            _userThread = new Thread(listener);
            _userThread.IsBackground = true;
            _userThread.Start();
        }
        public string UserName { get { return _userName; } }

        private void listener()
        {
            while (true) {
                try {
                    byte[] buffer = new byte[1024];
                    int bytesRec = _handler.Receive(buffer);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRec);
                    handleCommand(data);
                }
                catch { Server.EndClient(this); return; }
            }
        }

        public void End()
        {
            try {
                _handler.Close();
                try {
                    _userThread.Abort();
                }
                catch { } 
            }
            catch { }
        }

        private void handleCommand(string data)
        {
            if (data.Contains("#setname")) {
                _userName = data.Split('&')[1];
                UpdateChat();
                return;
            }
            if (data.Contains("#newmsg")) {
                string message = data.Split('&')[1];
                ChatController.AddMessage(_userName, message);
                return;
            }
        }

        public void UpdateChat()
        {
            Send(ChatController.GetChat());
        }

        public void Send(string command)
        {
            try {
                int bytesSent = _handler.Send(Encoding.UTF8.GetBytes(command));
            }
            catch (Exception exp) { Console.WriteLine("Error with send command: {0}.", exp.Message); Server.EndClient(this); }
        }
    }
}
