namespace RentALLMongo
{
    partial class UserForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.updateTownButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.showRequestsButton = new System.Windows.Forms.Button();
            this.acceptRequestButton = new System.Windows.Forms.Button();
            this.DeclineRequestButton = new System.Windows.Forms.Button();
            this.renterUsernameListbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.myRequestsListbox = new System.Windows.Forms.ListBox();
            this.myRequestsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter new password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter new town";
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(180, 35);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(87, 42);
            this.updatePasswordButton.TabIndex = 4;
            this.updatePasswordButton.Text = "Update password";
            this.updatePasswordButton.UseVisualStyleBackColor = true;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // updateTownButton
            // 
            this.updateTownButton.Location = new System.Drawing.Point(180, 98);
            this.updateTownButton.Name = "updateTownButton";
            this.updateTownButton.Size = new System.Drawing.Size(87, 42);
            this.updateTownButton.TabIndex = 5;
            this.updateTownButton.Text = "Update town";
            this.updateTownButton.UseVisualStyleBackColor = true;
            this.updateTownButton.Click += new System.EventHandler(this.updateTownButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(41, 438);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(199, 54);
            this.deleteAccountButton.TabIndex = 6;
            this.deleteAccountButton.Text = "Delete account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click button below \r\nto delete account permanently!";
            // 
            // requestsListBox
            // 
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 16;
            this.requestsListBox.Location = new System.Drawing.Point(368, 35);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(201, 132);
            this.requestsListBox.TabIndex = 8;
            // 
            // showRequestsButton
            // 
            this.showRequestsButton.Location = new System.Drawing.Point(368, 186);
            this.showRequestsButton.Name = "showRequestsButton";
            this.showRequestsButton.Size = new System.Drawing.Size(100, 42);
            this.showRequestsButton.TabIndex = 9;
            this.showRequestsButton.Text = "Show requests";
            this.showRequestsButton.UseVisualStyleBackColor = true;
            this.showRequestsButton.Click += new System.EventHandler(this.showRequestsButton_Click);
            // 
            // acceptRequestButton
            // 
            this.acceptRequestButton.Location = new System.Drawing.Point(514, 186);
            this.acceptRequestButton.Name = "acceptRequestButton";
            this.acceptRequestButton.Size = new System.Drawing.Size(105, 45);
            this.acceptRequestButton.TabIndex = 10;
            this.acceptRequestButton.Text = "Accept request";
            this.acceptRequestButton.UseVisualStyleBackColor = true;
            this.acceptRequestButton.Click += new System.EventHandler(this.acceptRequestButton_Click);
            // 
            // DeclineRequestButton
            // 
            this.DeclineRequestButton.Location = new System.Drawing.Point(659, 186);
            this.DeclineRequestButton.Name = "DeclineRequestButton";
            this.DeclineRequestButton.Size = new System.Drawing.Size(102, 42);
            this.DeclineRequestButton.TabIndex = 11;
            this.DeclineRequestButton.Text = "Decline request";
            this.DeclineRequestButton.UseVisualStyleBackColor = true;
            this.DeclineRequestButton.Click += new System.EventHandler(this.DeclineRequestButton_Click);
            // 
            // renterUsernameListbox
            // 
            this.renterUsernameListbox.FormattingEnabled = true;
            this.renterUsernameListbox.ItemHeight = 16;
            this.renterUsernameListbox.Location = new System.Drawing.Point(580, 35);
            this.renterUsernameListbox.Name = "renterUsernameListbox";
            this.renterUsernameListbox.Size = new System.Drawing.Size(181, 132);
            this.renterUsernameListbox.TabIndex = 12;
            this.renterUsernameListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.renterUsernameListbox_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Double click for more info!";
            // 
            // myRequestsListbox
            // 
            this.myRequestsListbox.FormattingEnabled = true;
            this.myRequestsListbox.ItemHeight = 16;
            this.myRequestsListbox.Location = new System.Drawing.Point(368, 272);
            this.myRequestsListbox.Name = "myRequestsListbox";
            this.myRequestsListbox.Size = new System.Drawing.Size(724, 148);
            this.myRequestsListbox.TabIndex = 14;
            // 
            // myRequestsButton
            // 
            this.myRequestsButton.Location = new System.Drawing.Point(368, 448);
            this.myRequestsButton.Name = "myRequestsButton";
            this.myRequestsButton.Size = new System.Drawing.Size(100, 44);
            this.myRequestsButton.TabIndex = 15;
            this.myRequestsButton.Text = "Show my requests";
            this.myRequestsButton.UseVisualStyleBackColor = true;
            this.myRequestsButton.Click += new System.EventHandler(this.myRequestsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Request list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "My request list";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.myRequestsButton);
            this.Controls.Add(this.myRequestsListbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.renterUsernameListbox);
            this.Controls.Add(this.DeclineRequestButton);
            this.Controls.Add(this.acceptRequestButton);
            this.Controls.Add(this.showRequestsButton);
            this.Controls.Add(this.requestsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.updateTownButton);
            this.Controls.Add(this.updatePasswordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatePasswordButton;
        private System.Windows.Forms.Button updateTownButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.Button showRequestsButton;
        private System.Windows.Forms.Button acceptRequestButton;
        private System.Windows.Forms.Button DeclineRequestButton;
        private System.Windows.Forms.ListBox renterUsernameListbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox myRequestsListbox;
        private System.Windows.Forms.Button myRequestsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}