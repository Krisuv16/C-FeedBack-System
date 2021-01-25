using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cw
{
    public partial class AddData : UserControl
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            added.DataSource = Expo.readOptionsCsv();
        }

        StringBuilder builder = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                MessageBox.Show("Empty Form");
            }
            else
            {
                builder.AppendLine(string.Join(",", tb1.Text));
                File.AppendAllText("options.txt", builder.ToString());
                MessageBox.Show("Added Sucessfully!");
                tb1.Text = "";
            }
            added.DataSource = Expo.readOptionsCsv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            added.DataSource = Expo.readOptionsCsv();
        }
    }
}
