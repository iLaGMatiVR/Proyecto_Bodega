using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.MailServices
{
    public class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "BodegaAguilaCurda@gmail.com";
            password = "Bodega123";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();

        }
    }
}
