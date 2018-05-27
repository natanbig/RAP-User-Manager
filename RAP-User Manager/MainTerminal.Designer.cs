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
            this.selectedLeft = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rAPUserTable = new System.Windows.Forms.DataGridView();
            this.selectedRigh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addAllUsersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dbIP = new System.Windows.Forms.TextBox();
            this.dbUser = new System.Windows.Forms.TextBox();
            this.dbPass = new System.Windows.Forms.TextBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumOfNotRapusers = new System.Windows.Forms.TextBox();
            this.sumOfRpUsers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSelectedusersToRap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notRAPUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPUserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notRAPUserTable
            // 
            this.notRAPUserTable.AllowUserToAddRows = false;
            this.notRAPUserTable.AllowUserToDeleteRows = false;
            this.notRAPUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notRAPUserTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.notRAPUserTable.BackgroundColor = System.Drawing.Color.Lime;
            this.notRAPUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notRAPUserTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedLeft});
            this.notRAPUserTable.Location = new System.Drawing.Point(13, 13);
            this.notRAPUserTable.Name = "notRAPUserTable";
            this.notRAPUserTable.RowTemplate.Height = 24;
            this.notRAPUserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notRAPUserTable.Size = new System.Drawing.Size(364, 535);
            this.notRAPUserTable.TabIndex = 1;
            // 
            // selectedLeft
            // 
            this.selectedLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selectedLeft.HeaderText = "Selected";
            this.selectedLeft.Name = "selectedLeft";
            this.selectedLeft.Width = 69;
            // 
            // rAPUserTable
            // 
            this.rAPUserTable.AllowUserToAddRows = false;
            this.rAPUserTable.AllowUserToDeleteRows = false;
            this.rAPUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rAPUserTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rAPUserTable.BackgroundColor = System.Drawing.Color.Lime;
            this.rAPUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rAPUserTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedRigh});
            this.rAPUserTable.Location = new System.Drawing.Point(618, 15);
            this.rAPUserTable.Name = "rAPUserTable";
            this.rAPUserTable.RowTemplate.Height = 24;
            this.rAPUserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rAPUserTable.Size = new System.Drawing.Size(356, 535);
            this.rAPUserTable.TabIndex = 5;
            // 
            // selectedRigh
            // 
            this.selectedRigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selectedRigh.HeaderText = "Selected";
            this.selectedRigh.Name = "selectedRigh";
            this.selectedRigh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectedRigh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.selectedRigh.Width = 92;
            // 
            // addAllUsersButton
            // 
            this.addAllUsersButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addAllUsersButton.Location = new System.Drawing.Point(455, 179);
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
            this.button1.Location = new System.Drawing.Point(455, 224);
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
            this.dbIP.Location = new System.Drawing.Point(455, 15);
            this.dbIP.Name = "dbIP";
            this.dbIP.Size = new System.Drawing.Size(107, 22);
            this.dbIP.TabIndex = 9;
            // 
            // dbUser
            // 
            this.dbUser.Location = new System.Drawing.Point(455, 54);
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(107, 22);
            this.dbUser.TabIndex = 10;
            // 
            // dbPass
            // 
            this.dbPass.Location = new System.Drawing.Point(455, 94);
            this.dbPass.Name = "dbPass";
            this.dbPass.Size = new System.Drawing.Size(107, 22);
            this.dbPass.TabIndex = 11;
            // 
            // connectionButton
            // 
            this.connectionButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.connectionButton.Location = new System.Drawing.Point(455, 131);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(107, 32);
            this.connectionButton.TabIndex = 12;
            this.connectionButton.Text = "Connect";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click_1);
            // 
            // sumOfNotRapusers
            // 
            this.sumOfNotRapusers.Location = new System.Drawing.Point(272, 556);
            this.sumOfNotRapusers.Name = "sumOfNotRapusers";
            this.sumOfNotRapusers.Size = new System.Drawing.Size(105, 22);
            this.sumOfNotRapusers.TabIndex = 13;
            // 
            // sumOfRpUsers
            // 
            this.sumOfRpUsers.Location = new System.Drawing.Point(861, 559);
            this.sumOfRpUsers.Name = "sumOfRpUsers";
            this.sumOfRpUsers.Size = new System.Drawing.Size(113, 22);
            this.sumOfRpUsers.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of not RAP Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number of RAP Users";
            // 
            // addSelectedusersToRap
            // 
            this.addSelectedusersToRap.Cursor = System.Windows.Forms.Cursors.Default;
            this.addSelectedusersToRap.Location = new System.Drawing.Point(418, 382);
            this.addSelectedusersToRap.Name = "addSelectedusersToRap";
            this.addSelectedusersToRap.Size = new System.Drawing.Size(171, 39);
            this.addSelectedusersToRap.TabIndex = 17;
            this.addSelectedusersToRap.Text = "Add Selected users ->";
            this.addSelectedusersToRap.UseVisualStyleBackColor = true;
            this.addSelectedusersToRap.Click += new System.EventHandler(this.addSelectedusersToRap_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "<- Remove Selected users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 590);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addSelectedusersToRap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumOfRpUsers);
            this.Controls.Add(this.sumOfNotRapusers);
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
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView rAPUserTable;
        private System.Windows.Forms.Button addAllUsersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox dbIP;
        private System.Windows.Forms.TextBox dbUser;
        private System.Windows.Forms.TextBox dbPass;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox sumOfNotRapusers;
        private System.Windows.Forms.TextBox sumOfRpUsers;
        protected System.Windows.Forms.DataGridView notRAPUserTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSelectedusersToRap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedLeft;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedRigh;
    }
}

