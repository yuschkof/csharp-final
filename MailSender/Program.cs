using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            // Используем регулярное выражение для проверки валидности адреса электронной почты
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            Console.WriteLine("Ваш логин Яндекс почты:");
            string youAddress = Console.ReadLine();
            if (!emailRegex.IsMatch(youAddress))
            {
                Console.WriteLine("Неверный емаил");
                return;
            }

            Console.WriteLine("Ваш пароль Яндекс почты:");
            string youPassword = Console.ReadLine();

            Console.WriteLine("Кому насрать в почту?");
            string toAddress = Console.ReadLine();
            if (!emailRegex.IsMatch(toAddress))
            {
                Console.WriteLine("Неверный емаил");
                return;
            }

            Console.WriteLine("Что насрать:");
            string message = Console.ReadLine();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(youAddress); // Адрес отправителя
            mail.To.Add(new MailAddress(toAddress)); // Адрес получателя
            mail.Body = message;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.yandex.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(youAddress, youPassword); // Ваши логин и пароль
            client.Send(mail);

            Console.WriteLine("Вас приветствует клан НАС РАНО");

            Console.ReadKey();
        }
    }
}
