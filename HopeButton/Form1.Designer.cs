namespace HopeButton
{
    partial class formGame
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
            this.components = new System.ComponentModel.Container();
            this.btnHope = new System.Windows.Forms.Button();
            this.progTime = new System.Windows.Forms.ProgressBar();
            this.lstbxLog = new System.Windows.Forms.ListBox();
            this.timeProg = new System.Windows.Forms.Timer(this.components);
            this.txtboxLogDescrip = new System.Windows.Forms.TextBox();
            this.txtboxLogName = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblProgTime = new System.Windows.Forms.Label();
            this.lstbxVisibleLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHope
            // 
            this.btnHope.Location = new System.Drawing.Point(12, 12);
            this.btnHope.Name = "btnHope";
            this.btnHope.Size = new System.Drawing.Size(162, 38);
            this.btnHope.TabIndex = 0;
            this.btnHope.Text = "Ready to begin your shift?";
            this.btnHope.UseVisualStyleBackColor = true;
            this.btnHope.Click += new System.EventHandler(this.btnHope_Click);
            // 
            // progTime
            // 
            this.progTime.Location = new System.Drawing.Point(12, 83);
            this.progTime.Name = "progTime";
            this.progTime.Size = new System.Drawing.Size(162, 23);
            this.progTime.TabIndex = 1;
            this.progTime.Value = 50;
            // 
            // lstbxLog
            // 
            this.lstbxLog.FormattingEnabled = true;
            this.lstbxLog.Location = new System.Drawing.Point(211, 360);
            this.lstbxLog.Name = "lstbxLog";
            this.lstbxLog.Size = new System.Drawing.Size(162, 17);
            this.lstbxLog.TabIndex = 2;
            this.lstbxLog.Visible = false;
            // 
            // timeProg
            // 
            this.timeProg.Interval = 1000;
            this.timeProg.Tick += new System.EventHandler(this.timeProg_Tick);
            // 
            // txtboxLogDescrip
            // 
            this.txtboxLogDescrip.Location = new System.Drawing.Point(211, 39);
            this.txtboxLogDescrip.Multiline = true;
            this.txtboxLogDescrip.Name = "txtboxLogDescrip";
            this.txtboxLogDescrip.Size = new System.Drawing.Size(162, 67);
            this.txtboxLogDescrip.TabIndex = 3;
            // 
            // txtboxLogName
            // 
            this.txtboxLogName.Location = new System.Drawing.Point(211, 13);
            this.txtboxLogName.Name = "txtboxLogName";
            this.txtboxLogName.Size = new System.Drawing.Size(162, 20);
            this.txtboxLogName.TabIndex = 4;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(211, 113);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(52, 13);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "Logbook:";
            // 
            // lblProgTime
            // 
            this.lblProgTime.AutoSize = true;
            this.lblProgTime.Location = new System.Drawing.Point(64, 64);
            this.lblProgTime.Name = "lblProgTime";
            this.lblProgTime.Size = new System.Drawing.Size(58, 13);
            this.lblProgTime.TabIndex = 6;
            this.lblProgTime.Text = "Production";
            // 
            // lstbxVisibleLog
            // 
            this.lstbxVisibleLog.FormattingEnabled = true;
            this.lstbxVisibleLog.Location = new System.Drawing.Point(211, 129);
            this.lstbxVisibleLog.Name = "lstbxVisibleLog";
            this.lstbxVisibleLog.Size = new System.Drawing.Size(162, 225);
            this.lstbxVisibleLog.TabIndex = 7;
            this.lstbxVisibleLog.SelectedIndexChanged += new System.EventHandler(this.lstbxVisibleLog_SelectedIndexChanged);
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 435);
            this.Controls.Add(this.lstbxVisibleLog);
            this.Controls.Add(this.lblProgTime);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtboxLogName);
            this.Controls.Add(this.txtboxLogDescrip);
            this.Controls.Add(this.lstbxLog);
            this.Controls.Add(this.progTime);
            this.Controls.Add(this.btnHope);
            this.Name = "formGame";
            this.Text = "Factory of Hope";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHope;
        private System.Windows.Forms.ProgressBar progTime;
        private System.Windows.Forms.ListBox lstbxLog;
        private System.Windows.Forms.Timer timeProg;
        private System.Windows.Forms.TextBox txtboxLogDescrip;
        private System.Windows.Forms.TextBox txtboxLogName;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblProgTime;
        private System.Windows.Forms.ListBox lstbxVisibleLog;
    }
}

