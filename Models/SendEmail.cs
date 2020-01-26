using WebsitePortfolio.Models;
using MailKit;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace WebsitePortfolio.Controllers
{
    internal static class SendEmail
    {
        public static void Send(ContactFormModel cnt, int mode)
        {
            //1 = Send to Myself
            //2 = Send to Respondent
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.openxchange.eu", 587, SecureSocketOptions.StartTls);
            client.Authenticate("ben@benking.co.nz", "FAKEPASSWORD123");
            MimeMessage msg = new MimeMessage();
            msg.From.Add(new MailboxAddress("Benjamin King", "ben@benking.co.nz"));
            msg.Subject = "New Website Enquiry " + System.DateTime.Now;

            msg.To.Add(new MailboxAddress("Ben King", "benjaminkingnz@gmail.com"));
            msg.Body = new TextPart("plain")
            {
                Text = string.Format("New Website Enquiry from '{0}' \nPhone No: {2} \nEmail Address: {1} \nMessage: \n{3}", cnt.Name, cnt.Email, cnt.PhoneNumber, cnt.Message)
            };
            client.Send(msg);
            msg.To.Clear();

            msg.Subject = "Automated Response - New Enquiry";
            msg.To.Add(new MailboxAddress(cnt.Name, cnt.Email));
            msg.Body = new TextPart("plain")
            {
                Text = string.Format("Thank you for your Enquiry on my Website. Enclosed Below is a Copy of your Message \nName: {0} \nPhone No: {1} \nEmail Address: {2} \nMessage: {3} \n \n \n --- \nKind Regards \nBenjamin King \n \n", cnt.Name, cnt.PhoneNumber, cnt.Email, cnt.Message)
            };
            client.Send(msg);
            
            client.Disconnect(true);
        }
    }

}