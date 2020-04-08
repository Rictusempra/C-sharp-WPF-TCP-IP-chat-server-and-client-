using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Threading;

namespace Chat
{

    public partial class MainWindow : Window
    {
        private delegate void printer(string data);
        private delegate void cleaner();
        printer Printer;
        cleaner Cleaner;
        private Thread ClientThread;

        public MainWindow()
        {
            InitializeComponent();
            Printer = new printer(print);
            Cleaner = new cleaner(clearChat);
            ClientThread = new Thread(listener);
            ClientThread.IsBackground = true;
            ClientThread.Start();
            Nickname.Content = "Ваш никнейм: " + SocketConnection.Login; 
        }

        public bool IsLostConnection = false;
        private void listener()
        {
            while (true) {
                try {
                    byte[] buffer = new byte[8196];
                    int bytesRec = SocketConnection.ServerSocket.Receive(buffer);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRec);
                    IsLostConnection = false;
                    if (data.Contains("#updatechat")) {
                        UpdateChat(data);
                        continue;
                    }
                }
                catch (Exception exp) {
                    if (!IsLostConnection) {
                        print("Связь с сервером прервалась...");
                        IsLostConnection = true;
                    }
                }
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                string data = MessageText.Text;
                if (string.IsNullOrEmpty(data)) return;
                MessageText.Clear();
                SocketConnection.Send("#newmsg&" + data);
            }
            catch { print("Невозможно отправить сообщение"); }
        }

        private void UpdateChat(string data)
        {
            clearChat();
            string[] messages = data.Split('&')[1].Split('|');
            int countMessages = messages.Length;
            if (countMessages <= 0) return;
            for (int i = 0; i < countMessages; i++) {
                try {
                    if (string.IsNullOrEmpty(messages[i])) continue;
                    print($"[{messages[i].Split('~')[0]}]: {messages[i].Split('~')[1]}");
                }
                catch { continue; }
            }
        }

        private void clearChat()
        {
            if (!this.Dispatcher.CheckAccess()) {
                this.Dispatcher.Invoke(Cleaner);
                return;
            }
            ChatText.Clear();
        }

        public void print(string msg)
        {
            if (!this.Dispatcher.CheckAccess()) {
                this.Dispatcher.Invoke(Printer, msg);
                return;
            }
            if (ChatText.Text.Length == 0)
                ChatText.AppendText(msg);
            else
                ChatText.AppendText(Environment.NewLine + msg);
            Scroll.ScrollToEnd();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            try {
                SocketConnection.Send("#newmsg&" + "Вышел из чата");
                Close();
            }
            catch { Close(); }
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageText.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SocketConnection.MainWindow = this;
        }
    }
}
