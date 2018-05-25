namespace RAP_User_Manager
{
    partial class MainTerminal
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
            this.notRAPUserTable = new System.Windows.Forms.DataGridView();
            this.rAPUserTable = new System.Windows.Forms.DataGridView();
            this.addAllUsersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbIP = new System.Windows.Forms.TextBox();
            this.dbUser = new System.Windows.Forms.TextBox();
            this.dbPass = new System.Windows.Forms.TextBox();
            this.connectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notRAPUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notRAPUserTable
            // 
            this.notRAPUserTable.AllowUserToOrderColumns = true;
            this.notRAPUserTable.BackgroundColor = System.Drawing.Color.Lime;
            this.notRAPUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notRAPUserTable.Location = new System.Drawing.Point(13, 13);
            this.notRAPUserTable.Name = "notRAPUserTable";
            this.notRAPUserTable.RowTemplate.Height = 24;
            this.notRAPUserTable.Size = new System.Drawing.Size(196, 535);
            this.notRAPUserTable.TabIndex = 1;
            // 
            // rAPUserTable
            // 
            this.rAPUserTable.AllowUserToOrderColumns = true;
            this.rAPUserTable.BackgroundColor = System.Drawing.Color.Lime;
            this.rAPUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rAPUserTable.Location = new System.Drawing.Point(416, 13);
            this.rAPUserTable.Name = "rAPUserTable";
            this.rAPUserTable.RowTemplate.Height = 24;
            this.rAPUserTable.Size = new System.Drawing.Size(196, 535);
            this.rAPUserTable.TabIndex = 5;
            // 
            // addAllUsersButton
            // 
            this.addAllUsersButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addAllUsersButton.Location = new System.Drawing.Point(253, 177);
            this.addAllUsersButton.Name = "addAllUsersButton";
            this.addAllUsersButton.Size = new System.Drawing.Size(107, 29);
            this.addAllUsersButton.TabIndex = 6;
            this.addAllUsersButton.Text = "Add All >>";
            this.addAllUsersButton.UseVisualStyleBackColor = true;
            this.addAllUsersButton.Click += new System.EventHandler(this.addAllUsersButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(253, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "<< Remove All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refreshButton.Location = new System.Drawing.Point(1194, 13);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 39);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dbIP
            // 
            this.dbIP.Location = new System.Drawing.Point(253, 13);
            this.dbIP.Name = "dbIP";
            this.dbIP.Size = new System.Drawing.Size(107, 22);
            this.dbIP.TabIndex = 9;
            // 
            // dbUser
            // 
            this.dbUser.Location = new System.Drawing.Point(253, 52);
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(107, 22);
            this.dbUser.TabIndex = 10;
            // 
            // dbPass
            // 
            this.dbPass.Location = new System.Drawing.Point(253, 92);
            this.dbPass.Name = "dbPass";
            this.dbPass.Size = new System.Drawing.Size(107, 22);
            this.dbPass.TabIndex = 11;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(253, 129);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(107, 32);
            this.connectionButton.TabIndex = 12;
            this.connectionButton.Text = "Connect";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click_1);
            // 
            // MainTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 560);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.dbPass);
            this.Controls.Add(this.dbUser);
            this.Controls.Add(this.dbIP);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addAllUsersButton);
            this.Controls.Add(this.rAPUserTable);
            this.Controls.Add(this.notRAPUserTable);
            this.Name = "MainTerminal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.notRAPUserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPUserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView notRAPUserTable;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView rAPUserTable;
        private System.Windows.Forms.Button addAllUsersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox dbIP;
        private System.Windows.Forms.TextBox dbUser;
        private System.Windows.Forms.TextBox dbPass;
        private System.Windows.Forms.Button connectionButton;
    }
}

