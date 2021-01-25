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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 7;
            if(panel3.Width >= 1182)
            {
                timer1.Stop();
                MainScreen ms = new MainScreen();
                ms.Show();
                this.Hide();
            }
        }
    }
}
