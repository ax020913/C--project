using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Net.Mail;

namespace MailForm
{
    class mailunit{
        public string smtp;
        public string from;
        public string pwd;
        public string to;
        public string subject;
        public string body;
        public ArrayList paths;
        public mailunit(string Psmtp, string Pfrom, string Ppwd, string Pto, string Psubject, string Pbody, ArrayList Ppaths){
            smtp = Psmtp;
            from = Pfrom;
            pwd = Ppwd;
            to = Pto;
            subject = Psubject;
            body = Pbody;
            paths = Ppaths;
        }
        /* 发邮件 点击发送button会触发 */
        public bool SendMail(){
            //创建smtpclient对象
            System.Net.Mail.SmtpClient client = new SmtpClient();
            client.Host = smtp;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, pwd);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //创建mailMessage对象 
            System.Net.Mail.MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            //正文默认格式为html
            message.Body = body;
            message.IsBodyHtml = true;
            message.BodyEncoding = System.Text.Encoding.UTF8;

            //添加附件
            if (paths.Count != 0){
                foreach (string path in paths){
                    Attachment data = new Attachment(path, System.Net.Mime.MediaTypeNames.Application.Octet);
                    message.Attachments.Add(data);
                }
            }

            try{
                client.Send(message);
                MessageBox.Show("恭喜您,发送成功！");
                return true;
            }
            catch{
                MessageBox.Show("发送失败，请检查邮箱密码，或网络连接！");
                return false;
            }
        }

        /* 发邮件2 线程中使用 */
        public bool SendMail_1(){
            //创建smtpclient对象
            System.Net.Mail.SmtpClient client = new SmtpClient();
            client.Host = smtp;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, pwd);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //创建mailMessage对象 
            System.Net.Mail.MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            //正文默认格式为html
            message.Body = body;
            message.IsBodyHtml = true;
            message.BodyEncoding = System.Text.Encoding.UTF8;

            //添加附件
            if (paths.Count != 0){
                foreach (string path in paths){
                    Attachment data = new Attachment(path, System.Net.Mime.MediaTypeNames.Application.Octet);
                    message.Attachments.Add(data);
                }
            }

            try{
                client.Send(message);
                return true;
            }
            catch{
                return false;
            }
        }
    }
}
