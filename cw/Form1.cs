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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReviewComboBox.DataSource = Expo.readlistoptions();
        }
    private void chartreview(String key)
    {
        ChartReview.DataSource = Expo.chartkey(key);
        ChartReview.Series["Series1"].XValueMember = "rating";
        ChartReview.Series["Series1"].YValueMembers = "count";
        ChartReview.Series["Series1"].LegendText = key;
        ChartReview.DataBind();
    }
    private void button1_Click(object sender, EventArgs e)
        {
            chartreview(ReviewComboBox.SelectedValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
            this.Hide();
        }
    }
}
