using System;
using System.Net.Mail;
using System.Windows;
using System.Windows.Input;

namespace Chat
{
    public partial class ErrorMessage : Window
    {
        public ErrorMessage()
        {
            InitializeComponent();
        }

        private async void Send_Click(object sender, RoutedEventArgs e)
        {
            SendButton.IsEnabled = false;
            try {
                SmtpClient smtpClient = new SmtpClient("smtp.mail.ru");
                MailMessage message = new MailMessage("konstgel@mail.ru", "markwald.denis@yandex.ru");
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("konstgel@mail.ru", "dy53x4qgvo");
                smtpClient.EnableSsl = true;
                message.Subject = "Chat";
                message.IsBodyHtml = false;
                message.Body = $"{ErrorText.Text}\n{VK.Text}";
                await smtpClient.SendMailAsync(message);
                smtpClient.Dispose();
                MessageBox.Show("Сообщение успешно отправлено!", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception exp) {
                MessageBox.Show($"Произошла какая-то ошибка! Message:{exp.Message}\n StackTrace:{exp.StackTrace}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            SendButton.IsEnabled = true;
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
