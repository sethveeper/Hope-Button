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
            this.SuspendLayout();
            // 
            // btnHope
            // 
            this.btnHope.Location = new System.Drawing.Point(12, 12);
            this.btnHope.Name = "btnHope";
            this.btnHope.Size = new System.Drawing.Size(162, 38);
            this.btnHope.TabIndex = 0;
            this.btnHope.Text = "Click to produce HOPE";
            this.btnHope.UseVisualStyleBackColor = true;
            this.btnHope.Click += new System.EventHandler(this.btnHope_Click);
            // 
            // progTime
            // 
            this.progTime.Location = new System.Drawing.Point(12, 56);
            this.progTime.Name = "progTime";
            this.progTime.Size = new System.Drawing.Size(162, 23);
            this.progTime.TabIndex = 1;
            this.progTime.Value = 50;
            // 
            // lstbxLog
            // 
            this.lstbxLog.FormattingEnabled = true;
            this.lstbxLog.Location = new System.Drawing.Point(180, 13);
            this.lstbxLog.Name = "lstbxLog";
            this.lstbxLog.Size = new System.Drawing.Size(162, 225);
            this.lstbxLog.TabIndex = 2;
            // 
            // timeProg
            // 
            this.timeProg.Enabled = true;
            this.timeProg.Interval = 1000;
            this.timeProg.Tick += new System.EventHandler(this.timeProg_Tick);
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 255);
            this.Controls.Add(this.lstbxLog);
            this.Controls.Add(this.progTime);
            this.Controls.Add(this.btnHope);
            this.Name = "formGame";
            this.Text = "Factory of Hope";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHope;
        private System.Windows.Forms.ProgressBar progTime;
        private System.Windows.Forms.ListBox lstbxLog;
        private System.Windows.Forms.Timer timeProg;
    }
}

