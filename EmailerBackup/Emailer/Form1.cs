using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Sending Message");
            try
            {
                if (!textBox2.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("You need to proide an email from @gmail.com");
                    return;
                }
                button1.Enabled = false;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBox2.Text);
                message.Subject = textBox1.Text;
                message.Body = richTextBox2.Text;
                foreach (string s in richTextBox1.Text.Split(';'))
                    message.To.Add(s);
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(textBox2.Text, textBox3.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
                MessageBox.Show("I think it was sent");

            }
            catch
            {
                MessageBox.Show("Error, type in credentials correctly", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                button1.Enabled = true;
            }
        }
    }
}