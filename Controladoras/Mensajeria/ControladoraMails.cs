using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Mensajeria
{
    public class ControladoraMails
    {
        public void MandarMails()
        {
            

            
            using (var client = new System.Net.Mail.SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("trabajopoo123@gmail.com", "cdlp ibty kidi nyev");
                using (var message = new MailMessage(
                    from: new MailAddress("trabajopoo123@gmail.com", "TrabajoPOO"),
                    to: new MailAddress("kratos2319t@gmail.com", "Its Kratoss")
                    ))
                {

                    message.Subject = "Control de stock";
                    message.Body = $"";
                    client.Send(message);
                }
            }
        }
        public void EnviarCodigoRecuperacion(string email, string codigo)
        {
            using (var client = new SmtpClient())
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("trabajopoo123@gmail.com", "cdlp ibty kidi nyev");

                var mensaje = new MailMessage
                {
                    From = new MailAddress("trabajopoo123@gmail.com", "TrabajoPOO"),
                    Subject = "Código de Recuperación de Contraseña",
                    Body = $"Su código de recuperación es: {codigo}",
                    IsBodyHtml = false
                };

                mensaje.To.Add(new MailAddress(email));

                client.Send(mensaje);
            }
        }

    }
}
