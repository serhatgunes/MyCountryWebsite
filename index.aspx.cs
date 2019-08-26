using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;


public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblInfo.Visible = false;
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        MailMessage mesaj = new MailMessage();
        mesaj.To.Add(new MailAddress("serhat.gunes.92@gmail.com")); //To whom e-mail will be sent
        mesaj.From = new MailAddress(txtEmail.Text, "New Message", System.Text.Encoding.UTF8);
        //Who will send the e-mail.
        mesaj.Subject = "New Message";//Mail subject.
        mesaj.Body = "Who :  " + txtName.Text.ToString() + " " + "\n" + "\n" + "E-Mail : " + txtEmail.Text.ToString() + "\n" + "\n" + "Message : " + txtMessage.Text.ToString() + "\n"; //Mail içeriği.
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.gmail.com";//The address that Gmail uses.
        client.Port = 587;
        client.Credentials = new NetworkCredential("serhat.gunes.92@gmail.com", "saliagabey1907");
        client.EnableSsl = true;
        try
        {
            lblInfo.Visible = true;
            client.Send(mesaj);//I send the mail I created above.
            lblInfo.ForeColor = Color.Green;
            lblInfo.Text = "Message sent.";
        }
        catch
        {
            lblInfo.Visible = true;
            lblInfo.ForeColor = Color.Red;
            lblInfo.Text = "Error.";
        }
    }
}