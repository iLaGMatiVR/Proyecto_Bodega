using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


namespace AccesoDatos.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient SmtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }

        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            SmtpClient = new SmtpClient();
            SmtpClient.Credentials = new NetworkCredential(senderMail, password);
            SmtpClient.Host = host;
            SmtpClient.Port = port;
            SmtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body,List<string> recipienteMail)
        {
            var mailMessage = new MailMessage();
            try
            {

                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipienteMail)
                {
                    mailMessage.To.Add(mail);


                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                SmtpClient.Send(mailMessage);
            }
            catch (Exception ex) { }

            finally
            {
                mailMessage.Dispose();
                SmtpClient.Dispose();
            }
        }

    }
}
