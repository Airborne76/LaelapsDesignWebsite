using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaelapsDesignWebsite.Models
{
    public class EmailMessage
    {
        public string From { get; set; }
        public string FromName { get; set; }
        public string To { get; set; }
        public string ToName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}