using System;
using System.Windows.Forms;


namespace cw
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            userControl21.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            logout ms = new logout();
            ms.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            addData1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
      
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
