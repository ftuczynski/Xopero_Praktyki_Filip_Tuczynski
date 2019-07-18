namespace TheQuest {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.batBox = new System.Windows.Forms.PictureBox();
            this.ghostBox = new System.Windows.Forms.PictureBox();
            this.ghoulBox = new System.Windows.Forms.PictureBox();
            this.potionRedBox = new System.Windows.Forms.PictureBox();
            this.potionBlueBox = new System.Windows.Forms.PictureBox();
            this.swordBox = new System.Windows.Forms.PictureBox();
            this.bowBox = new System.Windows.Forms.PictureBox();
            this.maceBox = new System.Windows.Forms.PictureBox();
            this.swordBigBox = new System.Windows.Forms.PictureBox();
            this.bowBigBox = new System.Windows.Forms.PictureBox();
            this.maceBigBox = new System.Windows.Forms.PictureBox();
            this.potionBlueBigBox = new System.Windows.Forms.PictureBox();
            this.potionRedBigBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackLeftButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBigBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowBigBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceBigBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueBigBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedBigBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(355, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(51, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(51, 14);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(51, 28);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(51, 42);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.Location = new System.Drawing.Point(75, 51);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(30, 30);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerBox.TabIndex = 1;
            this.playerBox.TabStop = false;
            // 
            // batBox
            // 
            this.batBox.BackColor = System.Drawing.Color.Transparent;
            this.batBox.Image = ((System.Drawing.Image)(resources.GetObject("batBox.Image")));
            this.batBox.Location = new System.Drawing.Point(112, 51);
            this.batBox.Name = "batBox";
            this.batBox.Size = new System.Drawing.Size(30, 30);
            this.batBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batBox.TabIndex = 2;
            this.batBox.TabStop = false;
            this.batBox.Visible = false;
            // 
            // ghostBox
            // 
            this.ghostBox.BackColor = System.Drawing.Color.Transparent;
            this.ghostBox.Image = ((System.Drawing.Image)(resources.GetObject("ghostBox.Image")));
            this.ghostBox.Location = new System.Drawing.Point(149, 51);
            this.ghostBox.Name = "ghostBox";
            this.ghostBox.Size = new System.Drawing.Size(30, 30);
            this.ghostBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghostBox.TabIndex = 3;
            this.ghostBox.TabStop = false;
            this.ghostBox.Visible = false;
            // 
            // ghoulBox
            // 
            this.ghoulBox.BackColor = System.Drawing.Color.Transparent;
            this.ghoulBox.Image = ((System.Drawing.Image)(resources.GetObject("ghoulBox.Image")));
            this.ghoulBox.Location = new System.Drawing.Point(186, 51);
            this.ghoulBox.Name = "ghoulBox";
            this.ghoulBox.Size = new System.Drawing.Size(30, 30);
            this.ghoulBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoulBox.TabIndex = 4;
            this.ghoulBox.TabStop = false;
            this.ghoulBox.Visible = false;
            // 
            // potionRedBox
            // 
            this.potionRedBox.BackColor = System.Drawing.Color.Transparent;
            this.potionRedBox.Image = ((System.Drawing.Image)(resources.GetObject("potionRedBox.Image")));
            this.potionRedBox.Location = new System.Drawing.Point(223, 51);
            this.potionRedBox.Name = "potionRedBox";
            this.potionRedBox.Size = new System.Drawing.Size(30, 30);
            this.potionRedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potionRedBox.TabIndex = 5;
            this.potionRedBox.TabStop = false;
            this.potionRedBox.Visible = false;
            // 
            // potionBlueBox
            // 
            this.potionBlueBox.BackColor = System.Drawing.Color.Transparent;
            this.potionBlueBox.Image = ((System.Drawing.Image)(resources.GetObject("potionBlueBox.Image")));
            this.potionBlueBox.Location = new System.Drawing.Point(260, 51);
            this.potionBlueBox.Name = "potionBlueBox";
            this.potionBlueBox.Size = new System.Drawing.Size(30, 30);
            this.potionBlueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potionBlueBox.TabIndex = 6;
            this.potionBlueBox.TabStop = false;
            this.potionBlueBox.Visible = false;
            // 
            // swordBox
            // 
            this.swordBox.BackColor = System.Drawing.Color.Transparent;
            this.swordBox.Image = ((System.Drawing.Image)(resources.GetObject("swordBox.Image")));
            this.swordBox.Location = new System.Drawing.Point(297, 51);
            this.swordBox.Name = "swordBox";
            this.swordBox.Size = new System.Drawing.Size(30, 30);
            this.swordBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordBox.TabIndex = 7;
            this.swordBox.TabStop = false;
            this.swordBox.Visible = false;
            // 
            // bowBox
            // 
            this.bowBox.BackColor = System.Drawing.Color.Transparent;
            this.bowBox.Image = ((System.Drawing.Image)(resources.GetObject("bowBox.Image")));
            this.bowBox.Location = new System.Drawing.Point(334, 51);
            this.bowBox.Name = "bowBox";
            this.bowBox.Size = new System.Drawing.Size(30, 30);
            this.bowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowBox.TabIndex = 8;
            this.bowBox.TabStop = false;
            this.bowBox.Visible = false;
            // 
            // maceBox
            // 
            this.maceBox.BackColor = System.Drawing.Color.Transparent;
            this.maceBox.Image = ((System.Drawing.Image)(resources.GetObject("maceBox.Image")));
            this.maceBox.Location = new System.Drawing.Point(371, 51);
            this.maceBox.Name = "maceBox";
            this.maceBox.Size = new System.Drawing.Size(30, 30);
            this.maceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maceBox.TabIndex = 9;
            this.maceBox.TabStop = false;
            this.maceBox.Visible = false;
            // 
            // swordBigBox
            // 
            this.swordBigBox.BackColor = System.Drawing.Color.Transparent;
            this.swordBigBox.Image = ((System.Drawing.Image)(resources.GetObject("swordBigBox.Image")));
            this.swordBigBox.Location = new System.Drawing.Point(75, 285);
            this.swordBigBox.Name = "swordBigBox";
            this.swordBigBox.Size = new System.Drawing.Size(50, 50);
            this.swordBigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordBigBox.TabIndex = 10;
            this.swordBigBox.TabStop = false;
            this.swordBigBox.Click += new System.EventHandler(this.swordBigBox_Click);
            // 
            // bowBigBox
            // 
            this.bowBigBox.BackColor = System.Drawing.Color.Transparent;
            this.bowBigBox.Image = ((System.Drawing.Image)(resources.GetObject("bowBigBox.Image")));
            this.bowBigBox.Location = new System.Drawing.Point(132, 285);
            this.bowBigBox.Name = "bowBigBox";
            this.bowBigBox.Size = new System.Drawing.Size(50, 50);
            this.bowBigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowBigBox.TabIndex = 11;
            this.bowBigBox.TabStop = false;
            this.bowBigBox.Click += new System.EventHandler(this.bowBigBox_Click);
            // 
            // maceBigBox
            // 
            this.maceBigBox.BackColor = System.Drawing.Color.Transparent;
            this.maceBigBox.Image = ((System.Drawing.Image)(resources.GetObject("maceBigBox.Image")));
            this.maceBigBox.Location = new System.Drawing.Point(188, 285);
            this.maceBigBox.Name = "maceBigBox";
            this.maceBigBox.Size = new System.Drawing.Size(50, 50);
            this.maceBigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maceBigBox.TabIndex = 12;
            this.maceBigBox.TabStop = false;
            this.maceBigBox.Click += new System.EventHandler(this.maceBigBox_Click);
            // 
            // potionBlueBigBox
            // 
            this.potionBlueBigBox.BackColor = System.Drawing.Color.Transparent;
            this.potionBlueBigBox.Image = ((System.Drawing.Image)(resources.GetObject("potionBlueBigBox.Image")));
            this.potionBlueBigBox.Location = new System.Drawing.Point(245, 285);
            this.potionBlueBigBox.Name = "potionBlueBigBox";
            this.potionBlueBigBox.Size = new System.Drawing.Size(50, 50);
            this.potionBlueBigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potionBlueBigBox.TabIndex = 13;
            this.potionBlueBigBox.TabStop = false;
            this.potionBlueBigBox.Click += new System.EventHandler(this.potionBlueBigBox_Click);
            // 
            // potionRedBigBox
            // 
            this.potionRedBigBox.BackColor = System.Drawing.Color.Transparent;
            this.potionRedBigBox.Image = ((System.Drawing.Image)(resources.GetObject("potionRedBigBox.Image")));
            this.potionRedBigBox.Location = new System.Drawing.Point(302, 285);
            this.potionRedBigBox.Name = "potionRedBigBox";
            this.potionRedBigBox.Size = new System.Drawing.Size(50, 50);
            this.potionRedBigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potionRedBigBox.TabIndex = 14;
            this.potionRedBigBox.TabStop = false;
            this.potionRedBigBox.Click += new System.EventHandler(this.potionRedBigBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveDownButton);
            this.groupBox1.Controls.Add(this.moveRightButton);
            this.groupBox1.Controls.Add(this.moveLeftButton);
            this.groupBox1.Controls.Add(this.moveUpButton);
            this.groupBox1.Location = new System.Drawing.Point(358, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 67);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(35, 39);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(23, 23);
            this.moveDownButton.TabIndex = 3;
            this.moveDownButton.Text = "↓";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(64, 28);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(23, 23);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.Text = "→";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(6, 28);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(23, 23);
            this.moveLeftButton.TabIndex = 1;
            this.moveLeftButton.Text = "←";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(35, 10);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(23, 23);
            this.moveUpButton.TabIndex = 0;
            this.moveUpButton.Text = "↑";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackDownButton);
            this.groupBox2.Controls.Add(this.attackRightButton);
            this.groupBox2.Controls.Add(this.attackLeftButton);
            this.groupBox2.Controls.Add(this.attackUpButton);
            this.groupBox2.Location = new System.Drawing.Point(457, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 67);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackDownButton
            // 
            this.attackDownButton.Location = new System.Drawing.Point(35, 39);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(23, 23);
            this.attackDownButton.TabIndex = 3;
            this.attackDownButton.Text = "↓";
            this.attackDownButton.UseVisualStyleBackColor = true;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            // 
            // attackRightButton
            // 
            this.attackRightButton.Location = new System.Drawing.Point(64, 28);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(23, 23);
            this.attackRightButton.TabIndex = 2;
            this.attackRightButton.Text = "→";
            this.attackRightButton.UseVisualStyleBackColor = true;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.Location = new System.Drawing.Point(6, 28);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(23, 23);
            this.attackLeftButton.TabIndex = 1;
            this.attackLeftButton.Text = "←";
            this.attackLeftButton.UseVisualStyleBackColor = true;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            // 
            // attackUpButton
            // 
            this.attackUpButton.Location = new System.Drawing.Point(35, 10);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(23, 23);
            this.attackUpButton.TabIndex = 0;
            this.attackUpButton.Text = "↑";
            this.attackUpButton.UseVisualStyleBackColor = true;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.potionRedBigBox);
            this.Controls.Add(this.potionBlueBigBox);
            this.Controls.Add(this.maceBigBox);
            this.Controls.Add(this.bowBigBox);
            this.Controls.Add(this.swordBigBox);
            this.Controls.Add(this.potionBlueBox);
            this.Controls.Add(this.potionRedBox);
            this.Controls.Add(this.ghoulBox);
            this.Controls.Add(this.ghostBox);
            this.Controls.Add(this.batBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.swordBox);
            this.Controls.Add(this.bowBox);
            this.Controls.Add(this.maceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBigBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowBigBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceBigBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlueBigBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRedBigBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.PictureBox batBox;
        private System.Windows.Forms.PictureBox ghostBox;
        private System.Windows.Forms.PictureBox ghoulBox;
        private System.Windows.Forms.PictureBox potionRedBox;
        private System.Windows.Forms.PictureBox potionBlueBox;
        private System.Windows.Forms.PictureBox swordBox;
        private System.Windows.Forms.PictureBox bowBox;
        private System.Windows.Forms.PictureBox maceBox;
        private System.Windows.Forms.PictureBox swordBigBox;
        private System.Windows.Forms.PictureBox bowBigBox;
        private System.Windows.Forms.PictureBox maceBigBox;
        private System.Windows.Forms.PictureBox potionBlueBigBox;
        private System.Windows.Forms.PictureBox potionRedBigBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Button attackUpButton;
    }
}

