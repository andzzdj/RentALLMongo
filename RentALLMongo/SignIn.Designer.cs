
namespace RentALL
{
    partial class SignIn
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
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Location = new System.Drawing.Point(260, 106);
            this.usernameTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(178, 22);
            this.usernameTextBox1.TabIndex = 0;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(260, 178);
            this.passwordTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(178, 22);
            this.passwordTextBox1.TabIndex = 1;
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(303, 244);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(94, 43);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.usernameTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}