namespace NationalismTraining
{
    partial class Practice
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
            this.PracticeTest = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PracticeTest
            // 
            this.PracticeTest.Location = new System.Drawing.Point(13, 13);
            this.PracticeTest.Name = "PracticeTest";
            this.PracticeTest.Size = new System.Drawing.Size(950, 100);
            this.PracticeTest.TabIndex = 0;
            this.PracticeTest.Text = "";
            this.PracticeTest.TextChanged += new System.EventHandler(this.PracticeTest_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Europe",
            "Africa",
            "Asia",
            "North-America",
            "South-America",
            "Everything"});
            this.listBox1.Location = new System.Drawing.Point(13, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bedazzle me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PracticeTest);
            this.Name = "Practice";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Practice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox PracticeTest;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}