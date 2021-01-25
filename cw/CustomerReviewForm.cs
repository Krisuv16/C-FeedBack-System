using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw
{
    public partial class CustomerReviewForm : Form
    {
        public static List<string> listOption = new List<string>();
        List<GroupBox> boxes = new List<GroupBox>();
        List<List<RadioButton>> buttons = new List<List<RadioButton>>();
        string number = "";

        public CustomerReviewForm()
        {
            InitializeComponent();
            int x = 0;

            readlistoptions();
            
            foreach (string s in listOption)
            {
                GroupBox gb = new GroupBox();
                RadioButton bad = new RadioButton();
                RadioButton average = new RadioButton();
                RadioButton good = new RadioButton();
                RadioButton excellent = new RadioButton();
                styleRadio(excellent, "Excellent");
                styleRadio(good, "Good");
                styleRadio(average, "Average");
                styleRadio(bad, "Bad");
                List<RadioButton> button = new List<RadioButton>();
                button.Add(bad);
                button.Add(average);
                button.Add(good);
                button.Add(excellent);
                buttons.Add(button);
                boxes.Add(gb);
            }
             for (int i = 0; i < listOption.Count(); i++)
            {
                boxes[i].SuspendLayout();
                foreach (RadioButton rb in buttons[i])
                {
                    boxes[i].Controls.Add(rb);
                    radiox = 0;
                }
                boxes[i].Location = new System.Drawing.Point(x, y);
                boxes[i].Size = new System.Drawing.Size(400, 54);
                boxes[i].TabIndex = 45;
                boxes[i].TabStop = false;
                boxes[i].Text = listOption[i];
                panel9.Controls.Add(boxes[i]);
                y = y + 60;
            }

        }


        public static void readlistoptions()
        {
            listOption.Clear();
            string[] readOption = File.ReadAllLines("options.txt");
            for (int i = 0; i < readOption.Count(); i++)
            {
                listOption.Add(readOption[i]);
            }
        }
        int radiox = 5;
        int y = 0;
        public void styleRadio(RadioButton rb, string text)
        {
            rb.AutoSize = true;
            rb.Location = new System.Drawing.Point(radiox, y + 15);
            rb.Size = new System.Drawing.Size(75, 31);
            rb.TabIndex = 11;
            rb.TabStop = true;
            rb.Text = text;
            rb.UseVisualStyleBackColor = true;
            radiox = radiox + 80;
            if (radiox > 250)
            {
                radiox = 5;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        public static RadioButton SelectedRadioButton(GroupBox g)
        {
            return g.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault();
        }
        public void changeToInt(String reviews)
        {
            if (reviews == "Excellent")
            {
                this.number = "4";
            }
            else if (reviews == "Good")
            {
                this.number = "3";
            }
            else if (reviews == "Average")
            {
                this.number = "2";
            }
            else if (reviews == "Bad")
            {
                this.number = "1";
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtEmail.Text =="" && txtPhone.Text == "")
            {
                MessageBox.Show("Enter AllFields");
            }
            else
            {
                    Expo.columns.Clear();
                    Expo.columns.Add("Date & Time");
                    Expo.columns.Add("Name");
                    Expo.columns.Add("Email");
                    Expo.columns.Add("Phone");

                    foreach (string opt in listOption)
                    {
                        Expo.columns.Add(opt);
                    }
                    List<string> review = new List<string>();
                    review.Add(DateTime.Now.ToString("MM/dd/yyyy H:mm"));
                    review.Add(txtUsername.Text);
                    review.Add(txtEmail.Text);
                    review.Add(txtPhone.Text);
                    foreach (GroupBox rb in boxes)
                    {
                    if (SelectedRadioButton(rb) == null)
                    {
                        MessageBox.Show("Plz enter all the fileds");
                        return;
                    }
                    else
                    {
                        this.changeToInt(SelectedRadioButton(rb).Text);
                        review.Add(this.number);
                    }
                    }
                    Expo.SaveArrayAsCSV(review);
                    MessageBox.Show("Review added successfull");
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtPhone.Text = "";
                    foreach (List<RadioButton> rbs in buttons)
                    {
                        foreach (RadioButton rb in rbs)
                        {
                            rb.Checked = false;
                        }
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            ms.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPhone.Text = "";
            foreach (List<RadioButton> rbs in buttons)
            {
                foreach(RadioButton rb in rbs)
                {
                    rb.Checked = false;
                }
            }
        }
    }
}
