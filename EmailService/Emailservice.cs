using System;
using System.Net;
using System.Net.Mail;

namespace EmailService
{
    public class Emailservice
    {
        public readonly string smtpServer;
        public readonly string smtpUsername;
        public readonly string smtpPassword;
       // public readonly string smtpSubject;
        public readonly int smtpPort;
        public readonly bool EnableSS1;
        public Emailservice(string smtpServer,string smtpUsername,string smtpPassword,int smtpPort,bool EnableSS1=true)
        {
            this.smtpServer = smtpServer;
            this.smtpUsername = smtpUsername;   
            this.smtpPassword = smtpPassword;
            this.smtpPort = smtpPort;
            this.EnableSS1 = EnableSS1;

        }
public void sendMail(string from,string to,string subject,string body,bool isBodyHtml =false)
        {
            try
            {
                using (var message = new MailMessage(from, to))
                {
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = isBodyHtml;

                    using (SmtpClient smtpClient = new SmtpClient(smtpServer,smtpPort)) 
                    {
                    smtpClient.Credentials=new NetworkCredential(smtpUsername,smtpPassword);
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(message);
                       
                    }
                }

            }
            catch
            (Exception ex)
            {
                throw new InvalidOperationException("error sending mail ",ex);
            }
        }

    }

}
