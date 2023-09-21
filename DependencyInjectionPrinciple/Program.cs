using System;
namespace DependencyInjectionPrinciple;
public interface IMailServer
{
    void Send(string to,string body);
}
public class MailService 
{
   public void SendMail(IMailServer mailServer,string to,string body)
    {
        mailServer.Send(to,body);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        MailService mailService = new();
        mailService.SendMail(new Gmail(), "ali", "gmail.com");
        mailService.SendMail(new Hotmail(), "ali", "hotmail.com");
        mailService.SendMail(new Yandex(), "ali", "yandex.com");
    }
    public class Gmail : IMailServer

    {
        public void Send(string to, string body)
        {

        }
    }

    public class Hotmail : IMailServer
    {
        public void Send(string to, string body)
        {

        }
    }
    public class Yandex : IMailServer
    {
        public void Send(string to, string body)
        {
        }
    }
}
