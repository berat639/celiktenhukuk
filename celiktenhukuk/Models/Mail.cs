using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace celiktenhukuk.Models
{
    public class Mail
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("celiktenhukuk1@gmail.com", "Çelikten Hukuk");
            var toAddress = new MailAddress("info@celiktenhukuk.com");
            const string subject = "iletişim bildirimi";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "12ve23kez")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }

        }
    }
}