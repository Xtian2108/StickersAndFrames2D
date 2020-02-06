using System;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;



public class MonoGmail : MonoBehaviour
{

    public static MonoGmail instance;
    public ScreenshotHandler nombrefoto;

    void Awake() {
        instance = this;
    }


    public void SendMail()
    {
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("cndeveloperbot@gmail.com");
        mail.To.Add("mauricio@pixz.cl");
        mail.Subject = "Tu recuerdo";
        mail.Body = "Felicidades";
        mail.IsBodyHtml = true;

        System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment(nombrefoto.nombreDeFoto);
        mail.Attachments.Add(attachment);



        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("cndeveloperbot@gmail.com", "developerbot123") as ICredentialsByHost; ;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);
    }
}
