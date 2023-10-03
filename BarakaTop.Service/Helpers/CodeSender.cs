using MimeKit;
using MailKit.Net.Smtp;

namespace BarakaTop.Service.Helpers;

public class CodeSender
{
    public string emaill;

    public async Task SendCodeAsync(string a)
    {
        try
        {
            // Sender's email address and password
            string senderEmail = "odilovmadiyor029@gmail.com";
            string senderPassword = "rzii yjyq hwvm cxyi";

            // Recipient's email address
            string recipientEmail = emaill;

            // Create a new MimeMessage
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Blue Space", senderEmail));
            message.To.Add(new MailboxAddress("Client", recipientEmail));
            message.Subject = " ";

            // Create the message body
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"{a}";
            message.Body = bodyBuilder.ToMessageBody();

            // Set up the SMTP client

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(senderEmail, senderPassword);

                // Send the email
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }


        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
        }
    }


    public async Task SendCodeAsyncWithThread(string a)
    {
        await Task.Run(() => SendCodeAsync(a));
    }
}
