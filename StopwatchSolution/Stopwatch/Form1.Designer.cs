namespace Stopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbStopwatch = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbStopwatchRest = new System.Windows.Forms.Label();
            this.btnResetRest = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStopwatch
            // 
            this.lbStopwatch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbStopwatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStopwatch.Location = new System.Drawing.Point(22, 19);
            this.lbStopwatch.Name = "lbStopwatch";
            this.lbStopwatch.Size = new System.Drawing.Size(216, 57);
            this.lbStopwatch.TabIndex = 0;
            this.lbStopwatch.Text = "00:00:00";
            this.lbStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Location = new System.Drawing.Point(247, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(54, 54);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(307, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 54);
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Location = new System.Drawing.Point(368, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(54, 54);
            this.btnReset.TabIndex = 3;
            this.btnReset.TabStop = false;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbStopwatchRest
            // 
            this.lbStopwatchRest.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbStopwatchRest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStopwatchRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStopwatchRest.Location = new System.Drawing.Point(101, 97);
            this.lbStopwatchRest.Name = "lbStopwatchRest";
            this.lbStopwatchRest.Size = new System.Drawing.Size(178, 36);
            this.lbStopwatchRest.TabIndex = 4;
            this.lbStopwatchRest.Text = "00:00:00";
            this.lbStopwatchRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetRest
            // 
            this.btnResetRest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetRest.BackgroundImage")));
            this.btnResetRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetRest.Location = new System.Drawing.Point(285, 101);
            this.btnResetRest.Name = "btnResetRest";
            this.btnResetRest.Size = new System.Drawing.Size(27, 27);
            this.btnResetRest.TabIndex = 5;
            this.btnResetRest.TabStop = false;
            this.btnResetRest.UseVisualStyleBackColor = true;
            this.btnResetRest.Click += new System.EventHandler(this.btnResetRest_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGitHub.BackgroundImage")));
            this.btnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGitHub.Location = new System.Drawing.Point(318, 101);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(27, 27);
            this.btnGitHub.TabIndex = 6;
            this.btnGitHub.TabStop = false;
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(444, 142);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.btnResetRest);
            this.Controls.Add(this.lbStopwatchRest);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbStopwatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStopwatch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbStopwatchRest;
        private System.Windows.Forms.Button btnResetRest;
        private System.Windows.Forms.Button btnGitHub;
    }
}

