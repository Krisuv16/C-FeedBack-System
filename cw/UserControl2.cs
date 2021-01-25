using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            review.DataSource = Expo.readCsv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = System.IO.File.ReadAllLines("review.txt");
            DataTable table = new DataTable();
            List<List<string>> reviews = new List<List<string>>();
            for (int i = 1; i < lines.Count(); i++)
            {
                List<string> review = lines[i].Split(',').ToArray().OfType<string>().ToList();
                reviews.Add(review);
            }
            int sizeOfArray = reviews.Count();
            int minimum;
            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                minimum = i;
                for (int j = i + 1; j < sizeOfArray; j++)
                {
                    if ((string.Compare(reviews[j][1], reviews[minimum][1]) < 0))
                    {
                        minimum = j;
                    }
                }
                List<string> temp = reviews[minimum];
                reviews[minimum] = reviews[i];
                reviews[i] = temp;
            }
            string[] headings = lines[0].Split(',').ToArray();
            foreach (string heading in headings)
            {
                table.Columns.Add(heading);
            }
            for (int i = 0; i < reviews.Count(); i++)
            {
                DataRow row = table.NewRow();
                int a = 0;
                foreach (string value in reviews[i])
                {
                    row[headings[a]] = value;
                    a++;
                }
                table.Rows.Add(row);
            }
            review.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
