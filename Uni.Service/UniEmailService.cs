using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Uni.Service
{
    public class UniEmailService
    {

        public static void SendEmail(string to, string subject, string body)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("kobulakobula.13@gmail.com", "pwxn rfku wkib mzrv");
        
        
        MailMessage message = new MailMessage();

        message.From = new MailAddress("kobulakobula.13@gmail.com");
        message.To.Add("kobulakobula.13@gmail.com");
        message.Subject = subject;
        message.Body = body;
        smtp.Send(message);

        
        
        }










    }
}
