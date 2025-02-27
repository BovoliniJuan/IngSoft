using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Controladoras.Administrador;

namespace Controladoras.Mensajeria
{
    public class ControladoraMails
    {        
        private readonly string smtpHost = "smtp.gmail.com";
        private readonly int smtpPort = 587;
        private readonly string emailFrom = "trabajopoo123@gmail.com";
        private readonly string emailPassword = "cdlp ibty kidi nyev";
        private readonly string displayName = "TrabajoPOO";

        private static ControladoraMails instancia;

        public static ControladoraMails Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraMails();
                }
                return instancia;
            }
        }

        private ControladoraMails() { }
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

        public void EnviarCodigoRecuperacion(string email, string codigo)
        {
            string asunto = "Código de Recuperación de Contraseña";
            string cuerpo = $@"
            <div style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #2e7d32;'>Recuperación de Contraseña</h2>
                <p>Hola,</p>
                <p>Tu código de recuperación es:</p>
                <p style='font-size: 24px; font-weight: bold; color: #2e7d32;'>{codigo}</p>
                <p>Por favor, usa este código para restablecer tu contraseña.</p>
                <p style='color: #555;'>Gracias,</p>
                <p style='color: #2e7d32;'>Equipo AgroGestion</p>
            </div>";

            EnviarCorreo(email, asunto, cuerpo, true);
        }

        public void NotificarAsignacionGrupo(string email, string nombreUsuario, string nombreGrupo)
        {
            string asunto = "Notificación de Asignación de Grupo";
            string cuerpo = $@"
            <div style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #2e7d32;'>Asignación de Grupo</h2>
                <p>Hola <b>{nombreUsuario}</b>,</p>
                <p>Tu cuenta ha sido activada y se te ha asignado al grupo:</p>
                <p style='font-size: 18px; font-weight: bold; color: #2e7d32;'>{nombreGrupo}</p>
                <p style='color: #555;'>Gracias por formar parte de nuestra plataforma.</p>
                <p style='color: #2e7d32;'>Equipo AgroGestion</p>
            </div>";

            EnviarCorreo(email, asunto, cuerpo, true);
        }

        public void NotificarRegistroExitoso(string email, string nombreUsuario)
        {
            string asunto = "Registro Exitoso";
            string cuerpo = $@"
            <div style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #2e7d32;'>Registro Exitoso</h2>
                <p>Hola <b>{nombreUsuario}</b>,</p>
                <p>Tu registro en nuestra plataforma ha sido exitoso.</p>
                <p>Un administrador revisará tu solicitud y te asignará un grupo en breve.</p>
                <p style='color: #555;'>Gracias por registrarte.</p>
                <p style='color: #2e7d32;'>Equipo AgroGestion</p>
            </div>";

            EnviarCorreo(email, asunto, cuerpo, true);
        }
       
    }
}
