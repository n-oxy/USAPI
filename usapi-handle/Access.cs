using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.IO;
using usapi_handle.Classes;
using System.Windows.Forms;

namespace usapi_handle
{
    class Access
    {
        internal static SmtpClient Client = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            EnableSsl = true,
        };
        internal static string fromEm;
    }
    public class MailClient
    {
        public void Authorize(string email, string pass)
        {
            Access.fromEm = email;
            Access.Client.Credentials = new NetworkCredential(email, pass);
        }
        public void Send(Mail ml)
        {
            try
            {
                var msg = new MailMessage();
                for (int i = 0; i < ml.to.Count(); i++)
                    msg.To.Add(ml.to[i]);
                msg.Subject = ml.subject;
                msg.From = new MailAddress(ml.from);
                msg.Body = ml.content;
                Access.Client.Send(msg);
                MessageBox.Show("sent");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
