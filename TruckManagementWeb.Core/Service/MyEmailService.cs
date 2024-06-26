﻿using MimeKit;
using TruckManagementWeb.Core.Contracts;

namespace TruckManagementWeb.Core.Service
{
    public class MyEmailService : IMyEmailService
    {
        public void SendMail(string Email, string body, string mailSubject)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("webtruckfounder@abv.bg"));
            email.To.Add(MailboxAddress.Parse(Email));
            email.Subject = $"{mailSubject}";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            try
            {
                using (var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    smtp.Connect("smtp.abv.bg", 465, true); 
                    smtp.Authenticate("webtruckfounder@abv.bg", "Aa@123456");
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }

    }
}
