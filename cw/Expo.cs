using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cw
{
    class Expo
    {
        public static List<string> columns = new List<string>();

        public static void SaveArrayAsCSV(List<string> options)
        {
            using (StreamWriter file = new StreamWriter("review.txt", true))
            {
                file.WriteLine(string.Join(",", options));
            }
            var lines = System.IO.File.ReadAllLines("review.txt");
            lines[0] = string.Join(",", columns);
            System.IO.File.WriteAllLines("review.txt", lines);
        }
        public static DataTable readCsv()
        {
            var lines = System.IO.File.ReadAllLines("review.txt");
            if(lines == null)
            {
                MessageBox.Show("Error");
            }
            DataTable table = new DataTable();
            string[] headings = lines[0].Split(',').ToArray();
            foreach (string heading in headings)
            {
                table.Columns.Add(heading);
            }
            for (int i = 1; i < lines.Count(); i++)
            {
                DataRow row = table.NewRow();
                string[] values = lines[i].Split(',').ToArray();
                int a = 0;
                foreach (string value in values)
                {
                    row[headings[a]] = value;
                    a++;
                }

                table.Rows.Add(row);
            }
            return table;
        }
        public static List<String> readlistoptions()
        {
            List<String> listOption = new List<string>();
            string[] readOption = File.ReadAllLines("options.txt");
            for (int i = 0; i < readOption.Count(); i++)
            {
                listOption.Add(readOption[i]);
            }
            return listOption;
        }
        public static DataTable readOptionsCsv()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Criteria");
            foreach (string s in readlistoptions())
            {
                DataRow row = dt.NewRow();
                row[0] = s;
                dt.Rows.Add(row);
            }
            return dt;
        }
        public static DataTable chartkey(String heading)
        {
            var lines = System.IO.File.ReadAllLines("review.txt");
            DataTable table = new DataTable();
            string[] headings = lines[0].Split(',').ToArray();
            List<string> listx = new List<string>();
            foreach (string head in headings)
            {
                listx.Add(head);
            }
            int index = listx.IndexOf(heading);
            List<int> listxvalues = new List<int>();
            for (int i = 1; i < lines.Count(); i++)
            {
                string[] listvalues = lines[i].Split(',').ToArray();
                listxvalues.Add(Int32.Parse(listvalues[index]));
            }
            var counts = listxvalues.GroupBy(a => a).Select(x => new { key = x.Key, val = x.Count() });
            DataTable datatable = new DataTable();
            datatable.Columns.Add("rating");
            datatable.Columns.Add("count");
            foreach (var item in counts)
            {
                DataRow row = datatable.NewRow();
                row[0] = item.key;
                row[1] = item.val;
                datatable.Rows.Add(row);
            }
            return datatable;
        }
    }
}
