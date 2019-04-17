using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                message.From.Add(new MailboxAddress("LaelapsDesignQA", "LaelapsDesignQA@hotmail.com"));
                //message.To.Add(new MailboxAddress("Mr.qq", "919605043@qq.com"));
                message.To.Add(new MailboxAddress("laelapsdesign", "admission@laelapsdesign.com"));
                message.Subject = "Message";
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = userMessage;
                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("smtp.office365.com", 587, false);
                    client.Authenticate("LaelapsDesignQA@hotmail.com", "lliallia666");
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
