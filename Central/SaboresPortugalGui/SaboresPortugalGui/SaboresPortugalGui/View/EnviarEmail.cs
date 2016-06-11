using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaboresPortugalGui.View
{
    public partial class EnviarEmail : Form
    {
        public EnviarEmail()
        {
            InitializeComponent();
        }

        private void EnviarEmail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(textBox1.Text);
                mail.To.Add(textBox2.Text);
                mail.Subject = textBox3.Text;
                mail.Body = richTextBox1.Text;

                //            System.Net.Mail.Attachment attachment;
                //              attachment = new System.Net.Mail.Attachment("your attachment file");
                //                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox4.Text);

                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email enviado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Inicial mp = new Inicial();
            mp.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
