using System.Net;
using System.Net.Mail;

namespace App.Web.Mvc
{
    public class EmailService
    {
        public void Send(string toMail, string subject, string body)
        {
            // SmtpClient: Sunucu ayarları
            var client = new SmtpClient("mt-sauron-da.guzelhosting.com", 465)
            {
                Credentials = new NetworkCredential("siliconmade@uzaktankurs.com", "vZpPRoSfyq!x5"),
                EnableSsl = true
            };

            // MailMessage: Mail ayarları
            var mail = new MailMessage()
            {
                From = new MailAddress("siliconmade@uzaktankurs.com", "Cem"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mail.To.Add(new MailAddress(toMail));
            //mail.CC.Add(new MailAddress(toMail));
            //mail.Bcc.Add("cmg.web@gmail.com");

            //client.Send(mail);
        }
    }
}
