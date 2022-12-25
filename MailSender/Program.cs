using System;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MailSender;

public class MailSender
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ваш логин Яндекс почты:");
        string youAddress = getEmail();

        Console.WriteLine("Ваш пароль Яндекс почты:");
        string youPassword = getPassword();

        Console.WriteLine("Кому насрать в почту?");
        string toAddress = getEmail();

        Console.WriteLine("Что насрать:");
        string message = Console.ReadLine();

        MailMessage mail = CreateMailMessage(youAddress, toAddress, message);
        SmtpClient client = CreateSmtpClient(youAddress, youPassword);
        SendEmail(client, mail);
        Console.ReadKey();
    }

    static MailMessage CreateMailMessage(string youAddress, string toAddress, string message)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(youAddress);
        mail.To.Add(new MailAddress(toAddress));
        mail.Body = message;
        return mail;
    }

    static SmtpClient CreateSmtpClient(string youAddress, string youPassword)
    {
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.yandex.ru";
        client.Port = 587;
        client.EnableSsl = true;
        client.Credentials = new NetworkCredential(youAddress, youPassword);
        return client;
    }

    static void SendEmail(SmtpClient client, MailMessage mail)
    {
        try
        {
            client.Send(mail);
            Console.WriteLine("Вас приветствует клан НАС РАНО");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    public static bool checkEmail(string email)
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        return emailRegex.IsMatch(email);
            
    }

    public static string getEmail()
    {
        string email = Console.ReadLine();
        if (checkEmail(email))
        {
            return email;
        }
        else
        {
            Console.WriteLine("Неверный емаил");
            return getEmail();
        }
    }

    public static string getPassword()
    {
        return Console.ReadLine();
    }

        
}