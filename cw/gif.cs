using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace cw
{
    public partial class gif : UserControl
    {
        public gif()
        {
            InitializeComponent();
            comboBox1.DataSource = Expo.readOptionsCsv();
        }
        private void chartreview(String key)
        {
            chart1.DataSource = Expo.chartkey(key);
            chart1.Series["Series1"].XValueMember = "rating";
            chart1.Series["Series1"].YValueMembers = "count";
            chart1.Series["Series1"].LegendText = key;
            chart1.DataBind();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chartreview(comboBox1.SelectedValue.ToString());
        }
    }
}
