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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.pBoxDie1 = new System.Windows.Forms.PictureBox();
            this.pBoxDie2 = new System.Windows.Forms.PictureBox();
            this.rb1time = new System.Windows.Forms.RadioButton();
            this.rb10times = new System.Windows.Forms.RadioButton();
            this.rb100times = new System.Windows.Forms.RadioButton();
            this.rb1000times = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rb10000times = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rollDiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testStrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRollDice, 2);
            this.btnRollDice.Location = new System.Drawing.Point(62, 102);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblDie1
            // 
            this.lblDie1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(43, 74);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(13, 13);
            this.lblDie1.TabIndex = 1;
            this.lblDie1.Text = "1";
            // 
            // lblDie2
            // 
            this.lblDie2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(143, 74);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(13, 13);
            this.lblDie2.TabIndex = 2;
            this.lblDie2.Text = "1";
            // 
            // pBoxDie1
            // 
            this.pBoxDie1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBoxDie1.Image = global::CrapsRoller.DieFaces.die_face_1;
            this.pBoxDie1.Location = new System.Drawing.Point(18, 3);
            this.pBoxDie1.Name = "pBoxDie1";
            this.pBoxDie1.Size = new System.Drawing.Size(64, 63);
            this.pBoxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDie1.TabIndex = 3;
            this.pBoxDie1.TabStop = false;
            // 
            // pBoxDie2
            // 
            this.pBoxDie2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBoxDie2.Image = global::CrapsRoller.DieFaces.die_face_1;
            this.pBoxDie2.Location = new System.Drawing.Point(118, 3);
            this.pBoxDie2.Name = "pBoxDie2";
            this.pBoxDie2.Size = new System.Drawing.Size(64, 63);
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
            // chart1
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 258);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Roll Result";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(490, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // rb10000times
            // 
            this.rb10000times.AutoSize = true;
            this.rb10000times.Location = new System.Drawing.Point(349, 203);
            this.rb10000times.Name = "rb10000times";
            this.rb10000times.Size = new System.Drawing.Size(86, 17);
            this.rb10000times.TabIndex = 10;
            this.rb10000times.Text = "10000 Times";
            this.rb10000times.UseVisualStyleBackColor = true;
            this.rb10000times.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.strategyToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rollDiceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Main";
            // 
            // rollDiceToolStripMenuItem
            // 
            this.rollDiceToolStripMenuItem.Name = "rollDiceToolStripMenuItem";
            this.rollDiceToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.rollDiceToolStripMenuItem.Text = "Roll Dice";
            this.rollDiceToolStripMenuItem.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // strategyToolStripMenuItem
            // 
            this.strategyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDesignerToolStripMenuItem,
            this.testStrategyToolStripMenuItem});
            this.strategyToolStripMenuItem.Name = "strategyToolStripMenuItem";
            this.strategyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.strategyToolStripMenuItem.Text = "Strategy";
            // 
            // openDesignerToolStripMenuItem
            // 
            this.openDesignerToolStripMenuItem.Name = "openDesignerToolStripMenuItem";
            this.openDesignerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openDesignerToolStripMenuItem.Text = "Strategy Designer";
            // 
            // testStrategyToolStripMenuItem
            // 
            this.testStrategyToolStripMenuItem.Name = "testStrategyToolStripMenuItem";
            this.testStrategyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.testStrategyToolStripMenuItem.Text = "Test Strategy";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDie1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBoxDie2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBoxDie1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDie2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRollDice, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(143, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 134);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(514, 580);
            this.Controls.Add(this.rb10000times);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.rb1000times);
            this.Controls.Add(this.rb100times);
            this.Controls.Add(this.rb10times);
            this.Controls.Add(this.rb1time);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Craps Roller!";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rb10000times;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rollDiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDesignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testStrategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

