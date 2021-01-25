namespace cw
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.review)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 562);
            this.panel7.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Review Table";
            // 
            // review
            // 
            this.review.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.review.Location = new System.Drawing.Point(300, 88);
            this.review.Name = "review";
            this.review.RowHeadersWidth = 51;
            this.review.RowTemplate.Height = 24;
            this.review.Size = new System.Drawing.Size(702, 376);
            this.review.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(300, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 26;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(457, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 27;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.review);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1020, 562);
            ((System.ComponentModel.ISupportInitialize)(this.review)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView review;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
