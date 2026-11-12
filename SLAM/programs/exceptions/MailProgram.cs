using SLAM.utils;
using System.Net;
using System.Net.Mail;

namespace SLAM.programs.exceptions
{
    public class MailProgram : IProgram
    {
        private static readonly int SMTP_PORT = 587;

        private static readonly string
            SMTP_ADRESSE = "smtp.gmail.com",
            LOG_PATH = "last.log";
        
        public void Execute()
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                Utils.PrintError(ex.Message);
                WriteLog(ex);
            }

            string senderMail = Utils.ReadString("Entrer votre mail.");
            string senderPswd = Utils.ReadString("Entrer le mot de passe de l'email.");
            string targetMail = Utils.ReadString("Entrer le mail du destinataire.");

            Console.Clear();

            try
            {
                using (MailMessage message = new MailMessage(senderMail, targetMail))
                {
                    message.Subject = $"[Alerte Exception] Erreur - {DateTime.Now:dd/MM/yyyy HH:mm}";
                    message.Body = "Bonjour,\n\nUne exception a été levée pendant l'exécution du programme.\n" +
                                   "Veuillez trouver le fichier de log ci-joint avec la trace détaillée de l'erreur.\n\n" +
                                   "Message généré automatiquement.";

                    if (File.Exists(LOG_PATH))
                        message.Attachments.Add(new Attachment(LOG_PATH));

                    using (SmtpClient clientSmtp = new SmtpClient(SMTP_ADRESSE, SMTP_PORT))
                    {
                        clientSmtp.EnableSsl = true;
                        clientSmtp.Credentials = new NetworkCredential(senderMail, senderPswd);

                        Utils.Print("Envoi du mail en cours...");
                        clientSmtp.Send(message);
                        Utils.PrintSuccess("E-mail envoyé avec succès !");
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.PrintError(ex.Message);
                WriteLog(ex);
            }
        }

        private void WriteLog(Exception ex)
        {
            string rapport = $"========================================\n" +
                             $"Date/Heure : {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                             $"Type d'exception : {ex.GetType().FullName}\n" +
                             $"Message : {ex.Message}\n" +
                             $"Trace de la pile (StackTrace) :\n{ex.StackTrace}\n" +
                             $"========================================\n";

            File.WriteAllText(LOG_PATH, rapport);
            Utils.PrintError($"Fichier log généré: {Path.GetFullPath(LOG_PATH)}");
        }
    }
}
