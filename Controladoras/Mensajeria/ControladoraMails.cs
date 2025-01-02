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
        private readonly string smtpHost = "smtp.gmail.com";
        private readonly int smtpPort = 587;
        private readonly string emailFrom = "trabajopoo123@gmail.com";
        private readonly string emailPassword = "cdlp ibty kidi nyev";
        private readonly string displayName = "TrabajoPOO";

        // Servicio genérico de envío de correos
        public void EnviarCorreo(string destinatario, string asunto, string cuerpo, bool esHtml = false)
        {
            using (var client = new SmtpClient())
            {
                client.Host = smtpHost;
                client.Port = smtpPort;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(emailFrom, emailPassword);

                var mensaje = new MailMessage
                {
                    From = new MailAddress(emailFrom, displayName),
                    Subject = asunto,
                    Body = cuerpo,
                    IsBodyHtml = esHtml
                };

                mensaje.To.Add(new MailAddress(destinatario));

                client.Send(mensaje);
            }
        }

        // Método para enviar un mensaje predefinido
        public void MandarMails()
        {
            string destinatario = "kratos2319t@gmail.com";
            string asunto = "Control de stock";
            string cuerpo = "Este es un mensaje de prueba para el control de stock.";

            EnviarCorreo(destinatario, asunto, cuerpo);
        }

        // Método para enviar un código de recuperación de contraseña
        public void EnviarCodigoRecuperacion(string email, string codigo)
        {
            string asunto = "Código de Recuperación de Contraseña";
            string cuerpo = $"Su código de recuperación es: {codigo}";

            EnviarCorreo(email, asunto, cuerpo);
        }

        // Método para enviar notificación de asignación de grupo
        public void NotificarAsignacionGrupo(string email, string nombreUsuario, string nombreGrupo)
        {
            string asunto = "Notificación de Asignación de Grupo";
            string cuerpo = $@"Hola {nombreUsuario},

                Tu cuenta ha sido activada y se te ha asignado al grupo: {nombreGrupo}.

                Gracias por formar parte de nuestra plataforma.";

            EnviarCorreo(email, asunto, cuerpo);
        }

        // Método para enviar notificación de registro exitoso
        public void NotificarRegistroExitoso(string email, string nombreUsuario)
        {
            string asunto = "Registro Exitoso";
            string cuerpo = $@"Hola {nombreUsuario},

                Tu registro en nuestra plataforma ha sido exitoso. Un administrador revisará tu solicitud y te asignará un grupo en breve.";

            EnviarCorreo(email, asunto, cuerpo);
        }


        /* public void MandarMails()
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
       */
    }
}
