namespace WindowsFormsPage332 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(398, 206);
            this.description.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(13, 232);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(75, 23);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Go here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(94, 234);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(316, 21);
            this.exits.TabIndex = 2;
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(13, 261);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(397, 27);
            this.goThroughTheDoor.TabIndex = 3;
            this.goThroughTheDoor.Text = "Go through the door";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(13, 295);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(397, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "check__";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(13, 325);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(397, 23);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "Hide!";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 359);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button hideButton;
    }
}

