using System;
using System.Net;
using System.Net.Mail;
using EmailService;

namespace ConsoleApp16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Create an instance of the email service
                var emailService = new Emailservice(
                    smtpServer: "smtp.gmail.com",
                    smtpPort: 587,
                    smtpUsername: "example@gmail.com", // Replace with your Gmail
                    smtpPassword: "mpyh abcd wkpm vnax",
                    EnableSS1: true// Use an App-specific password
                     // Enable SSL for secure connection
                );

                // Send an email
                emailService.sendMail(
                    from: "example@gmail.com",      // Replace with your Gmail
                    to: "poonampande@gmail.com",   // Replace with recipient's email
                    subject: "Test Email Subject",
                    body: "This is a test email body."
                );

                Console.WriteLine("Mail sent successfully.");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("SMTP Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
            }
        }
    }
}
