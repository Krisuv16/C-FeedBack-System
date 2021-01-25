namespace cw
{
    partial class AddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddData));
            this.label2 = new System.Windows.Forms.Label();
            this.added = new System.Windows.Forms.DataGridView();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.added)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 44);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add to Review Form";
            // 
            // added
            // 
            this.added.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.added.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.added.Location = new System.Drawing.Point(292, 247);
            this.added.Name = "added";
            this.added.RowHeadersWidth = 51;
            this.added.RowTemplate.Height = 24;
            this.added.Size = new System.Drawing.Size(734, 298);
            this.added.TabIndex = 26;
            this.added.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(292, 81);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(338, 38);
            this.tb1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(669, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 44);
            this.label1.TabIndex = 29;
            this.label1.Text = "Review Column List";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(299, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.panel7.TabIndex = 31;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.added);
            this.Controls.Add(this.label2);
            this.Name = "AddData";
            this.Size = new System.Drawing.Size(1052, 562);
            ((System.ComponentModel.ISupportInitialize)(this.added)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView added;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
    }
}
