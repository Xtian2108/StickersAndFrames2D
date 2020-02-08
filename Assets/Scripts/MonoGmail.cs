using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;



public class MonoGmail : MonoBehaviour
{

    public static MonoGmail instance;
    public ScreenshotHandler nombrefoto;
    public TMP_InputField email;
    public Button inicio;
    public PantallasControl pc;
    public bool listo;

    void Awake() {
        instance = this;
    }

    VirtualKeyboard vk = new VirtualKeyboard();

    public void OpenKeyboard()
    {
        {
            vk.ShowTouchKeyboard();
        }
    }

    public void CloseKeyboard()
    {
        {
            vk.HideTouchKeyboard();
        }
    }

    public void SendEmailR(){
        string usertoken = "personalizalove2020@gmail.com";
        MailMessage mail = new MailMessage();


        mail.From = new MailAddress("personalizalove2020@gmail.com");
        mail.To.Add(email.text);
        mail.Subject = "Personalizalove con estilo";
        mail.Body = "";


        System.Net.Mail.Attachment attachment;
        attachment = new System.Net.Mail.Attachment(nombrefoto.nombreDeFoto);
        mail.Attachments.Add(attachment);



        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com",587);
        // smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("personalizalove2020@gmail.com", "personaliza123") as ICredentialsByHost;
        //smtpServer.Credentials = CredentialCache.DefaultNetworkCredentials as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        { return true; };
        smtpServer.SendAsync (mail, usertoken);
        smtpServer.SendCompleted += SmtpServer_SendCompleted;
        Debug.Log("Request Sent");
        pc.MoverPantalla5();
    }
 
    void SmtpServer_SendCompleted (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
        SendEmailC ();
    }
 
    public void SendEmailC(){
        //string usertoken = "personalizalove2020@gmail.com";
        //MailMessage mail = new MailMessage();
 
 
        //mail.From = new MailAddress("personalizalove2020@gmail.com");
        //mail.To.Add(email.text);
        //mail.Subject = "Personalizalove con estilo";
        //mail.Body = "";


        //System.Net.Mail.Attachment attachment;
        //attachment = new System.Net.Mail.Attachment(nombrefoto.nombreDeFoto);
        //mail.Attachments.Add(attachment);

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com",587);
        // smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("personalizalove2020@gmail.com", "personaliza123") as ICredentialsByHost;
        //smtpServer.Credentials = CredentialCache.DefaultNetworkCredentials as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        { return true; };
        //smtpServer.SendAsync (mail, usertoken);
        inicio.interactable = true;
        Debug.Log("Confirmation Sent");
    }
}
