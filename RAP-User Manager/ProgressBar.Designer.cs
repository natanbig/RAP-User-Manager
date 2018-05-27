namespace RAP_User_Manager
{
    partial class ProgressBar
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
            this.processStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // processStatus
            // 
            this.processStatus.AutoSize = true;
            this.processStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processStatus.Location = new System.Drawing.Point(317, 37);
            this.processStatus.Name = "processStatus";
            this.processStatus.Size = new System.Drawing.Size(168, 25);
            this.processStatus.TabIndex = 0;
            this.processStatus.Text = "Processing...0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 82);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(808, 46);
            this.progressBar1.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 238);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.processStatus);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}