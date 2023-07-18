using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;



namespace Panel.Business.MailVerification
{
    public class MailSender
    {
        public void SendSignUpCodeMail(int activateCode,string userMailAddress)
        {
            
                // Gönderen mail adresi ve şifresi
                string fromMailAddress = "kendi mail adresini yaz";
                string fromMailPassword = "tek kullanımlık uygulama sifresi al";

                // Alıcı mail adresi
                string toMailAddress = userMailAddress;

                // SMTP sunucu ayarları
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;

                
                // Mail gönderme işlemi için MimeMessage oluşturma
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Gönderen Adı", fromMailAddress));
                message.To.Add(new MailboxAddress("Alıcı Adı", toMailAddress));
                message.Subject = "DV/Kullanıcı Giriş Paneli";

                // Mail içeriğini oluşturma (HTML içeriği için)
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = "<p>"+"Doğrulama kodunuz : "+activateCode.ToString()+"         Bu uygulama Deniz Varıcı tarafından geliştirilmiştir..."+"</p>";

                // Mail içeriği olarak metin de ekleyebilirsiniz
                // bodyBuilder.TextBody = "Bu mail C# ile gönderildi.";

                // Mail içeriğini ekleme
                message.Body = bodyBuilder.ToMessageBody();

                // Mail gönderme işlemi için SMTP istemci oluşturma
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect(smtpServer, smtpPort, SecureSocketOptions.StartTls);
                    smtpClient.Authenticate(fromMailAddress, fromMailPassword);

                    // Maili gönderme
                    smtpClient.Send(message);

                    smtpClient.Disconnect(true);
                }

                
            }
            
        }
    }
    

    
    
    

