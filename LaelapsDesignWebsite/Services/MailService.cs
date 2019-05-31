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
using System.Web;
using MimeKit;
using System.Web.Script.Serialization;

namespace LaelapsDesignWebsite.Services
{
    public class MailService
    {
        private static MailService uniqueInstance;
        private static readonly object locker = new object();
        private string mailInfo;
        private EmailMessage emailMessage;
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
                        string filepath = HttpContext.Current.Server.MapPath("~/Mail.json");
                        JavaScriptSerializer jss = new JavaScriptSerializer();
                        uniqueInstance.emailMessage = jss.Deserialize<EmailMessage>(GetFileJson(filepath));
                    }
                }
            }
            return uniqueInstance;
        }
        

        public static string GetFileJson(string filepath)
        {
            string json = string.Empty;
            using (FileStream fs = new FileStream(filepath, FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("gb2312")))
                {
                    json = sr.ReadToEnd().ToString();
                }
            }
            return json;
        }

        public bool SendMail(string userMessage,out string errMessage)
        {
            errMessage = "";
            try
            {
                var message = new MimeMessage();
                //message.From.Add(new MailboxAddress("firfly","qweasdz76@live.com"));               
                message.From.Add(new MailboxAddress("LaelapsDesignQA", emailMessage.From));
                //message.To.Add(new MailboxAddress("Mr.qq", "919605043@qq.com"));
                message.To.Add(new MailboxAddress("laelapsdesign", emailMessage.To));
                message.Subject = "Message";
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = userMessage;
                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("relay-hosting.secureserver.net", 25, false);
                   
                    //client.Authenticate(emailMessage.From, emailMessage.Password);
                    //client.Authenticate("qweasdz76@live.com", "qwe12345as123");
                    client.Send(message);
                    client.Disconnect(true);                    
                }
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return false;
            }
            return true;
        }
    }
}
