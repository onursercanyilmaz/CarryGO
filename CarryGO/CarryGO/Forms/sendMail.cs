using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarryGO.Forms
{
    public partial class sendMail : Form
    {
        string get_mail;
        string get_name;
        string get_enquiryid;
        string get_price;

        public sendMail(string mail, string name, string enquiry, string price)
        {
            InitializeComponent();
            get_mail = mail;
            get_name = name;
            get_enquiryid = enquiry;
            get_price = price;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "!";
                string emailTo = ToBox.Text.Trim();
                string subject = SubjectBox.Text.Trim();
                string body = richTextBox1.Text;

                if (string.IsNullOrEmpty(emailTo))
                    errorLabel.Text = "Please enter a mail!";
                if (string.IsNullOrEmpty(subject))
                    errorLabel.Text = "Please enter a subject!";

                string smtpAddress = "smtp.gmail.com";
                int portNo = 587;
                string email = "carrygocargo@gmail.com";
                string password = "carrygo123456789";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(email);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient(smtpAddress, portNo);
                    smtp.Credentials = new NetworkCredential(email, password);

                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    errorLabel.Text = "✔️ Email sent successfully!";
                }
            }
            catch (Exception)
            {

                errorLabel.Text = "❌ Email couldn't send!";
            }
        }

        private void sendMail_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                ToBox.Text = get_mail;
                SubjectBox.Text = "Cargo Details";
                richTextBox1.AppendText("\nHello " + get_name);
                richTextBox1.AppendText("\n\nYour Enquiry ID : " + get_enquiryid);
                richTextBox1.AppendText("\nYou paid : $" + get_price);
                richTextBox1.AppendText("\nHave a nice day!" );
                richTextBox1.AppendText("\n\n\nCarryGO Inc. \nAll Rights Reserved 2021");

            }
            catch (Exception)
            {
                errorLabel.Text = "Mail couldn't load!";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
