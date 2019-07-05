namespace BeeHiveManagementSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.nextShiftButton = new System.Windows.Forms.Button();
            this.assignJobButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignJobButton);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenace",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 41);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(234, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(246, 42);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 20);
            this.shifts.TabIndex = 1;
            // 
            // nextShiftButton
            // 
            this.nextShiftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextShiftButton.Location = new System.Drawing.Point(391, 12);
            this.nextShiftButton.Name = "nextShiftButton";
            this.nextShiftButton.Size = new System.Drawing.Size(171, 107);
            this.nextShiftButton.TabIndex = 1;
            this.nextShiftButton.Text = "Work the next shift!";
            this.nextShiftButton.UseVisualStyleBackColor = true;
            // 
            // assignJobButton
            // 
            this.assignJobButton.Location = new System.Drawing.Point(7, 69);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(359, 21);
            this.assignJobButton.TabIndex = 2;
            this.assignJobButton.Text = "button2";
            this.assignJobButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 373);
            this.Controls.Add(this.nextShiftButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assignJobButton;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button nextShiftButton;
    }
}

