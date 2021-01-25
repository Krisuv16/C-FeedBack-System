namespace cw
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ReviewComboBox = new System.Windows.Forms.ComboBox();
            this.ChartReview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Controls.Add(this.button3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 562);
            this.panel7.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(706, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReviewComboBox
            // 
            this.ReviewComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewComboBox.FormattingEnabled = true;
            this.ReviewComboBox.Location = new System.Drawing.Point(290, 445);
            this.ReviewComboBox.Name = "ReviewComboBox";
            this.ReviewComboBox.Size = new System.Drawing.Size(390, 44);
            this.ReviewComboBox.TabIndex = 32;
            // 
            // ChartReview
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartReview.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartReview.Legends.Add(legend1);
            this.ChartReview.Location = new System.Drawing.Point(293, 77);
            this.ChartReview.Name = "ChartReview";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartReview.Series.Add(series1);
            this.ChartReview.Size = new System.Drawing.Size(727, 300);
            this.ChartReview.TabIndex = 31;
            this.ChartReview.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Review Chart ";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 47);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReviewComboBox);
            this.Controls.Add(this.ChartReview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ReviewComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}