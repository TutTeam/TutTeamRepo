using MVCpgs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace MVCpgs.Services
{
    public class GmailEmailService
    {
        public async Task Send(UserContact userContact)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p><p>LikeBeer</p><p>{3}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("pestka5443@gmail.com"));  // mail odbiorcy
            message.From = new MailAddress("markeiwcz.lukasz@ssss.com"); // mail serwera (nadawcy)
            message.Subject = "Your email subject";
            message.Body = string.Format(body, userContact.Name, userContact.Email, userContact.MsgToUs, userContact.LikeBeer);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "pestka5443@gmail.com",  // replace with valid value
                    Password = "Pestka@5443"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                await smtp.SendMailAsync(message);
            }
        }
    }
}