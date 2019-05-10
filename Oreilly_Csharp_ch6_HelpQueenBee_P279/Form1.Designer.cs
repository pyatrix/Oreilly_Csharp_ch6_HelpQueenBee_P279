namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Shifts = new System.Windows.Forms.NumericUpDown();
            this.WorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.AssignButton = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.TextBox();
            this.NextShift = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Shifts);
            this.groupBox1.Controls.Add(this.WorkerBeeJob);
            this.groupBox1.Controls.Add(this.AssignButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job";
            // 
            // Shifts
            // 
            this.Shifts.Location = new System.Drawing.Point(237, 37);
            this.Shifts.Name = "Shifts";
            this.Shifts.Size = new System.Drawing.Size(65, 22);
            this.Shifts.TabIndex = 2;
            // 
            // WorkerBeeJob
            // 
            this.WorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerBeeJob.FormattingEnabled = true;
            this.WorkerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.WorkerBeeJob.Location = new System.Drawing.Point(9, 39);
            this.WorkerBeeJob.Name = "WorkerBeeJob";
            this.WorkerBeeJob.Size = new System.Drawing.Size(222, 20);
            this.WorkerBeeJob.TabIndex = 1;
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(31, 65);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(248, 29);
            this.AssignButton.TabIndex = 0;
            this.AssignButton.Text = "Assign this job to a bee";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(13, 120);
            this.Report.Multiline = true;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(527, 225);
            this.Report.TabIndex = 1;
            // 
            // NextShift
            // 
            this.NextShift.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.NextShift.Location = new System.Drawing.Point(327, 20);
            this.NextShift.Name = "NextShift";
            this.NextShift.Size = new System.Drawing.Size(213, 93);
            this.NextShift.TabIndex = 2;
            this.NextShift.Text = "Work the next shift";
            this.NextShift.UseVisualStyleBackColor = true;
            this.NextShift.Click += new System.EventHandler(this.NextShift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 357);
            this.Controls.Add(this.NextShift);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Shifts;
        private System.Windows.Forms.ComboBox WorkerBeeJob;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.TextBox Report;
        private System.Windows.Forms.Button NextShift;
    }
}

