using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;       // No olvidar.
using System.Net.Mail;
namespace WindowsFormsApplication3
{
    public partial class EnviodeMails : Form
    {
        public EnviodeMails()
        {
            InitializeComponent();
        }

        private void EnviodeMails_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (para.Text == "" && asunto.Text == "" && emisor.Text == "" && contra.Text == "")
            {
                MessageBox.Show("Corrobore los datos antes de enviar alguno de los campos estan vacios");
            }
            else
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(para.Text);
                correo.To.Add(para.Text);
                correo.Subject = asunto.Text;
                correo.Body = mensajazo.Text;
                correo.IsBodyHtml = false;
                correo.Priority = MailPriority.Normal;

                SmtpClient smpt = new SmtpClient();
                smpt.Credentials = new NetworkCredential(emisor.Text, contra.Text);

                smpt.Host = "smtp.gmail.com";
                smpt.Port = 587;
                smpt.EnableSsl = true;
                try
                {
                    smpt.Send(correo);
                    MessageBox.Show("correo enviado");

                }
                catch
                {

                    MessageBox.Show("no e pudo enviar el correo, verifique destinatario");
                }
                correo.Dispose();

            }

        }
    }
}