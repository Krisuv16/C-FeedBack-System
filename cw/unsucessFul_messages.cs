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
    public partial class unsucessFul_messages : Form
    {
        public unsucessFul_messages()
        {
            InitializeComponent();
        }

        private void unsucessFul_messages_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_login admin_log = new admin_login();
            admin_log.Show();
            this.Hide();
        }
    }
}
