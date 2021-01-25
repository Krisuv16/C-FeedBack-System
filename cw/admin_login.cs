using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                successfull_message_box smb = new successfull_message_box();
                smb.Show();
                this.Hide();
            }
            else
            {
                unsucessFul_messages smb = new unsucessFul_messages();
                smb.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                button1.Visible=false;
                button2.Visible = true;
                button2.Location = button1.Location;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button1.Visible = true;
                button2.Visible = false;
                button2.Location = button1.Location;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            ms.Show();
            this.Hide();
        }
    }
}
