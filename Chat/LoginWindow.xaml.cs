using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Chat
{
    public partial class LoginWindow : Window
    {
        private delegate void StateHandler();
        StateHandler changer_1;
        StateHandler changer_2;

        public LoginWindow()
        {
            InitializeComponent();
            changer_1 = new StateHandler(StateChanger_1);
            changer_2 = new StateHandler(StateChanger_2);
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                if ((SocketConnection.ServerSocket.Connected) && (LoginText.Text != "") && (!LoginText.Text.Equals("Введите логин"))) {
                    SocketConnection.Login = LoginText.Text;
                    MainWindow main = new MainWindow();
                    SocketConnection.IsLogged = true;
                    await SocketConnection.SetName();
                    main.Show();
                    Close();
                }
                else if ((LoginText.Text == "") || (LoginText.Text.Equals("Введите логин"))) MessageBox.Show("Вы не ввели логин", "Сообщение");
                else MessageBox.Show("Сервер не доступен", "Сообщение");
            }
            catch (Exception exp) { MessageBox.Show("Сервер не доступен " + exp.Message, "Сообщение"); }
        }

        public void StateChanger_1()
        {
            if (!this.Dispatcher.CheckAccess()) {
                this.Dispatcher.Invoke(changer_1);
                return;
            }
            Status.Foreground = new SolidColorBrush(Colors.DarkGreen);
            Status.Content = "Online";
        }

        public void StateChanger_2()
        {
            if (!this.Dispatcher.CheckAccess()) {
                this.Dispatcher.Invoke(changer_2);
                return;
            }
            Status.Foreground = new SolidColorBrush(Colors.OrangeRed);
            Status.Content = "Offline";
        }

        private void Input_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LoginText.Text.Contains("Введите логин")) LoginText.Text = "";
            LoginText.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
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
            LoginText.Focus();
        }

        private void Error_Click(object sender, RoutedEventArgs e)
        {
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginText.Foreground = new SolidColorBrush(Colors.Gray);
            LoginText.Text = "Введите логин";
            SocketConnection.LoginWindow = this;
        }
    }
}
