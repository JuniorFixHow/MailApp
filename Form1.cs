using System.Net.Mail;
using System.Net;
namespace MailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            emailTxt.Clear();
            subjectTxt.Clear();
            messTxt.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void sendMail()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(Credentials.email);
            message.Subject = subjectTxt.Text.Trim();
            message.To.Add(new MailAddress(emailTxt.Text.Trim()));
            message.Body = "<html> <body> <p> " + messTxt.Text + " </p> </body> </html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(Credentials.email, Credentials.password),
                EnableSsl = true
            };

            smtpClient.Send(message);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(emailTxt.Text !="" & subjectTxt.Text!="" & messTxt.Text != "")
                {
                    sendMail();
                    errorLbl.Visible = true;
                    errorLbl.Text = "Message sent";
                    errorLbl.ForeColor = Color.Green;
                    clear();
                }
                else
                {
                    errorLbl.Visible = true;
                    errorLbl.Text = "All fields are required!";
                    errorLbl.ForeColor = Color.Crimson;
                }
                
            }
            catch (Exception ex)
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Error occured sending the message.";
                errorLbl.ForeColor = Color.Crimson;
                clear();
            }
        }
    }
    
}