namespace HydrateForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.lstToDrink = new System.Windows.Forms.ListBox();
            this.lblStarted = new System.Windows.Forms.Label();
            this.bttnStart = new System.Windows.Forms.Button();
            this.bttnStop = new System.Windows.Forms.Button();
            this.bttnFreqency = new System.Windows.Forms.Button();
            this.bttnChangeDaily = new System.Windows.Forms.Button();
            this.prgNextDrink = new System.Windows.Forms.ProgressBar();
            this.bttnDaily = new System.Windows.Forms.Button();
            this.bttnEnergy = new System.Windows.Forms.Button();
            this.bttnDefaults = new System.Windows.Forms.Button();
            this.bttnSound = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnRefill = new System.Windows.Forms.Button();
            this.bttnCoffee = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(12, 415);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(776, 23);
            this.prgProgress.TabIndex = 0;
            this.prgProgress.Click += new System.EventHandler(this.prgProgress_Click);
            // 
            // lstToDrink
            // 
            this.lstToDrink.FormattingEnabled = true;
            this.lstToDrink.ItemHeight = 15;
            this.lstToDrink.Location = new System.Drawing.Point(46, 45);
            this.lstToDrink.Name = "lstToDrink";
            this.lstToDrink.Size = new System.Drawing.Size(318, 364);
            this.lstToDrink.TabIndex = 1;
            this.lstToDrink.SelectedIndexChanged += new System.EventHandler(this.lstToDrink_SelectedIndexChanged);
            // 
            // lblStarted
            // 
            this.lblStarted.AutoSize = true;
            this.lblStarted.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStarted.Location = new System.Drawing.Point(512, 9);
            this.lblStarted.Name = "lblStarted";
            this.lblStarted.Size = new System.Drawing.Size(171, 19);
            this.lblStarted.TabIndex = 2;
            this.lblStarted.Text = "Drink timer started at: ";
            // 
            // bttnStart
            // 
            this.bttnStart.BackColor = System.Drawing.Color.Lime;
            this.bttnStart.Location = new System.Drawing.Point(370, 44);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(133, 178);
            this.bttnStart.TabIndex = 3;
            this.bttnStart.Text = "Start Timer";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // bttnStop
            // 
            this.bttnStop.BackColor = System.Drawing.Color.Red;
            this.bttnStop.Location = new System.Drawing.Point(370, 231);
            this.bttnStop.Name = "bttnStop";
            this.bttnStop.Size = new System.Drawing.Size(133, 178);
            this.bttnStop.TabIndex = 3;
            this.bttnStop.Text = "Stop Timer";
            this.bttnStop.UseVisualStyleBackColor = false;
            this.bttnStop.Click += new System.EventHandler(this.bttnStop_Click);
            // 
            // bttnFreqency
            // 
            this.bttnFreqency.Location = new System.Drawing.Point(3, 185);
            this.bttnFreqency.Name = "bttnFreqency";
            this.bttnFreqency.Size = new System.Drawing.Size(133, 80);
            this.bttnFreqency.TabIndex = 3;
            this.bttnFreqency.Text = "Change Timer Frequency";
            this.bttnFreqency.UseVisualStyleBackColor = true;
            this.bttnFreqency.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnChangeDaily
            // 
            this.bttnChangeDaily.Location = new System.Drawing.Point(142, 94);
            this.bttnChangeDaily.Name = "bttnChangeDaily";
            this.bttnChangeDaily.Size = new System.Drawing.Size(133, 80);
            this.bttnChangeDaily.TabIndex = 3;
            this.bttnChangeDaily.Text = "Change Daily Recommended";
            this.bttnChangeDaily.UseVisualStyleBackColor = true;
            this.bttnChangeDaily.Click += new System.EventHandler(this.bttnChangeDaily_Click);
            // 
            // prgNextDrink
            // 
            this.prgNextDrink.Location = new System.Drawing.Point(12, 44);
            this.prgNextDrink.Name = "prgNextDrink";
            this.prgNextDrink.Size = new System.Drawing.Size(28, 365);
            this.prgNextDrink.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgNextDrink.TabIndex = 0;
            this.prgNextDrink.Click += new System.EventHandler(this.prgNextDrink_Click);
            // 
            // bttnDaily
            // 
            this.bttnDaily.Location = new System.Drawing.Point(3, 94);
            this.bttnDaily.Name = "bttnDaily";
            this.bttnDaily.Size = new System.Drawing.Size(133, 80);
            this.bttnDaily.TabIndex = 3;
            this.bttnDaily.Text = "Reached Daily Recommended";
            this.bttnDaily.UseVisualStyleBackColor = true;
            this.bttnDaily.Click += new System.EventHandler(this.bttnDaily_Click);
            // 
            // bttnEnergy
            // 
            this.bttnEnergy.Location = new System.Drawing.Point(142, 3);
            this.bttnEnergy.Name = "bttnEnergy";
            this.bttnEnergy.Size = new System.Drawing.Size(134, 80);
            this.bttnEnergy.TabIndex = 3;
            this.bttnEnergy.Text = "Add Energy Drink";
            this.bttnEnergy.UseVisualStyleBackColor = true;
            this.bttnEnergy.Click += new System.EventHandler(this.bttnEnergy_Click);
            // 
            // bttnDefaults
            // 
            this.bttnDefaults.Location = new System.Drawing.Point(142, 276);
            this.bttnDefaults.Name = "bttnDefaults";
            this.bttnDefaults.Size = new System.Drawing.Size(134, 80);
            this.bttnDefaults.TabIndex = 3;
            this.bttnDefaults.Text = "Restore Defaults";
            this.bttnDefaults.UseVisualStyleBackColor = true;
            this.bttnDefaults.Click += new System.EventHandler(this.bttnDefaults_Click);
            // 
            // bttnSound
            // 
            this.bttnSound.Location = new System.Drawing.Point(142, 185);
            this.bttnSound.Name = "bttnSound";
            this.bttnSound.Size = new System.Drawing.Size(134, 80);
            this.bttnSound.TabIndex = 3;
            this.bttnSound.Text = "Change Timer Sound";
            this.bttnSound.UseVisualStyleBackColor = true;
            this.bttnSound.Click += new System.EventHandler(this.bttnSound_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bttnRefill, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnCoffee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnEnergy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnDefaults, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnFreqency, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnDaily, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnChangeDaily, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnSound, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(509, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 365);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // bttnRefill
            // 
            this.bttnRefill.Location = new System.Drawing.Point(3, 276);
            this.bttnRefill.Name = "bttnRefill";
            this.bttnRefill.Size = new System.Drawing.Size(133, 80);
            this.bttnRefill.TabIndex = 3;
            this.bttnRefill.Text = "Refilled Water";
            this.bttnRefill.UseVisualStyleBackColor = true;
            this.bttnRefill.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnCoffee
            // 
            this.bttnCoffee.Location = new System.Drawing.Point(3, 3);
            this.bttnCoffee.Name = "bttnCoffee";
            this.bttnCoffee.Size = new System.Drawing.Size(133, 80);
            this.bttnCoffee.TabIndex = 3;
            this.bttnCoffee.Text = "Add Coffee";
            this.bttnCoffee.UseVisualStyleBackColor = true;
            this.bttnCoffee.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Hydrate.io";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.prgNextDrink);
            this.Controls.Add(this.lblStarted);
            this.Controls.Add(this.lstToDrink);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.bttnStop);
            this.Name = "Form1";
            this.Text = "Hydrate.io";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.ListBox lstToDrink;
        private System.Windows.Forms.Label lblStarted;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Button bttnStop;
        private System.Windows.Forms.Button bttnFreqency;
        private System.Windows.Forms.Button bttnChangeDaily;
        private System.Windows.Forms.ProgressBar prgNextDrink;
        private System.Windows.Forms.Button bttnDaily;
        private System.Windows.Forms.Button bttnEnergy;
        private System.Windows.Forms.Button bttnDefaults;
        private System.Windows.Forms.Button bttnSound;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnRefill;
        private System.Windows.Forms.Button bttnCoffee;
        private System.Windows.Forms.Label lblTitle;
    }
}

