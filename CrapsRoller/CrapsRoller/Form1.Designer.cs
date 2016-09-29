namespace CrapsRoller
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.pBoxDie1 = new System.Windows.Forms.PictureBox();
            this.pBoxDie2 = new System.Windows.Forms.PictureBox();
            this.rb1time = new System.Windows.Forms.RadioButton();
            this.rb10times = new System.Windows.Forms.RadioButton();
            this.rb100times = new System.Windows.Forms.RadioButton();
            this.rb1000times = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(143, 165);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(89, 128);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(0, 13);
            this.lblDie1.TabIndex = 1;
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(241, 128);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(0, 13);
            this.lblDie2.TabIndex = 2;
            // 
            // pBoxDie1
            // 
            this.pBoxDie1.Location = new System.Drawing.Point(72, 51);
            this.pBoxDie1.Name = "pBoxDie1";
            this.pBoxDie1.Size = new System.Drawing.Size(64, 64);
            this.pBoxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDie1.TabIndex = 3;
            this.pBoxDie1.TabStop = false;
            // 
            // pBoxDie2
            // 
            this.pBoxDie2.Location = new System.Drawing.Point(223, 51);
            this.pBoxDie2.Name = "pBoxDie2";
            this.pBoxDie2.Size = new System.Drawing.Size(64, 64);
            this.pBoxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDie2.TabIndex = 4;
            this.pBoxDie2.TabStop = false;
            // 
            // rb1time
            // 
            this.rb1time.AutoSize = true;
            this.rb1time.Checked = true;
            this.rb1time.Location = new System.Drawing.Point(51, 203);
            this.rb1time.Name = "rb1time";
            this.rb1time.Size = new System.Drawing.Size(51, 17);
            this.rb1time.TabIndex = 5;
            this.rb1time.TabStop = true;
            this.rb1time.Text = "Once";
            this.rb1time.UseVisualStyleBackColor = true;
            this.rb1time.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb10times
            // 
            this.rb10times.AutoSize = true;
            this.rb10times.Location = new System.Drawing.Point(108, 203);
            this.rb10times.Name = "rb10times";
            this.rb10times.Size = new System.Drawing.Size(68, 17);
            this.rb10times.TabIndex = 6;
            this.rb10times.Text = "10 Times";
            this.rb10times.UseVisualStyleBackColor = true;
            this.rb10times.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb100times
            // 
            this.rb100times.AutoSize = true;
            this.rb100times.Location = new System.Drawing.Point(182, 203);
            this.rb100times.Name = "rb100times";
            this.rb100times.Size = new System.Drawing.Size(74, 17);
            this.rb100times.TabIndex = 7;
            this.rb100times.Text = "100 Times";
            this.rb100times.UseVisualStyleBackColor = true;
            this.rb100times.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb1000times
            // 
            this.rb1000times.AutoSize = true;
            this.rb1000times.Location = new System.Drawing.Point(263, 203);
            this.rb1000times.Name = "rb1000times";
            this.rb1000times.Size = new System.Drawing.Size(80, 17);
            this.rb1000times.TabIndex = 8;
            this.rb1000times.Text = "1000 Times";
            this.rb1000times.UseVisualStyleBackColor = true;
            this.rb1000times.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(381, 342);
            this.Controls.Add(this.rb1000times);
            this.Controls.Add(this.rb100times);
            this.Controls.Add(this.rb10times);
            this.Controls.Add(this.rb1time);
            this.Controls.Add(this.pBoxDie2);
            this.Controls.Add(this.pBoxDie1);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Form1";
            this.Text = "Craps Roller!";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.PictureBox pBoxDie1;
        private System.Windows.Forms.PictureBox pBoxDie2;
        private System.Windows.Forms.RadioButton rb1time;
        private System.Windows.Forms.RadioButton rb10times;
        private System.Windows.Forms.RadioButton rb100times;
        private System.Windows.Forms.RadioButton rb1000times;
    }
}

