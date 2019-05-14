using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using LaelapsDesignWebsite.Models;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace LaelapsDesignWebsite.Services
{
    public class MailService
    {
        private static MailService uniqueInstance;
        private static readonly object locker = new object();
        private MailService()
        {
            
        }         
        public static MailService GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new MailService();
                    }
                }
            }
            return uniqueInstance;
        }

        public bool SendMail(string userMessage)
        {
            try
            {
                var message = new MimeMessage();
                //message.From.Add(new MailboxAddress("firfly","qweasdz76@live.com"));
                message.From.Add(new MailboxAddress("LaelapsDesignQA", ConfigurationManager.AppSettings["From"].ToString()));
                //message.To.Add(new MailboxAddress("Mr.qq", "919605043@qq.com"));
                message.To.Add(new MailboxAddress("laelapsdesign", ConfigurationManager.AppSettings["To"].ToString()));
                message.Subject = "Message";
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = userMessage;
                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(ConfigurationManager.AppSettings["SMTP"].ToString(), int.Parse(ConfigurationManager.AppSettings["Port"].ToString()), false);
                    client.Authenticate(ConfigurationManager.AppSettings["From"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
                    //client.Authenticate("qweasdz76@live.com", "qwe12345as123");
                    client.Send(message);
                    client.Disconnect(true);
                    
                }
            }
            catch (Exception ex)
            {
                return false;

            }
            return true;

        }

    }
}
