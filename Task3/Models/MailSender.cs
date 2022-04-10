using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Task3.Utilies;

namespace Task3.Models
{
    static class MailSender
    {
        public static void SendMail(string recipient, string title, string message)
        {
            IsValidEmail(recipient);
            if (title == null || title.Length > 100) throw new MailTitleNotValidException("Mail title is not valid");
            if (message == null) throw new MailMessageNotValidException("Mail message is not valid");
            using (MailMessage messageInfo = new MailMessage())
            {
                messageInfo.From = new MailAddress("asdfgfsasfvrwqg12345@gmail.com");
                messageInfo.To.Add(recipient);
                messageInfo.Subject = title;
                messageInfo.Body = message;
                messageInfo.IsBodyHtml = false;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587) { Credentials = new NetworkCredential("asdfgfsasfvrwqg12345@gmail.com",
                    "Test_Test123"),
                    EnableSsl = true
                })
                {
                    smtp.Send(messageInfo);
                }
            }
        }
        static void IsValidEmail(string email)
        {
            try
            {
                new MailAddress(email);
            }
            catch (Exception)
            {
                throw new MailFormatNotValidException("Mail format is not valid");
            }
        }
    }
}
