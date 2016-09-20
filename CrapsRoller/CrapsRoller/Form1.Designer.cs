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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(148, 208);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Press to Roll";
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
            this.pBoxDie1.Size = new System.Drawing.Size(64, 50);
            this.pBoxDie1.TabIndex = 3;
            this.pBoxDie1.TabStop = false;
            // 
            // pBoxDie2
            // 
            this.pBoxDie2.Location = new System.Drawing.Point(223, 51);
            this.pBoxDie2.Name = "pBoxDie2";
            this.pBoxDie2.Size = new System.Drawing.Size(64, 50);
            this.pBoxDie2.TabIndex = 4;
            this.pBoxDie2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 342);
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
    }
}

