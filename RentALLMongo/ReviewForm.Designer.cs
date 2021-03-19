namespace RentALLMongo
{
    partial class ReviewForm
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
            this.MyCommentTextBox = new System.Windows.Forms.TextBox();
            this.AddCommentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyCommentTextBox
            // 
            this.MyCommentTextBox.Location = new System.Drawing.Point(569, 27);
            this.MyCommentTextBox.Multiline = true;
            this.MyCommentTextBox.Name = "MyCommentTextBox";
            this.MyCommentTextBox.Size = new System.Drawing.Size(202, 204);
            this.MyCommentTextBox.TabIndex = 0;
            // 
            // AddCommentButton
            // 
            this.AddCommentButton.Location = new System.Drawing.Point(569, 248);
            this.AddCommentButton.Name = "AddCommentButton";
            this.AddCommentButton.Size = new System.Drawing.Size(102, 38);
            this.AddCommentButton.TabIndex = 1;
            this.AddCommentButton.Text = "Add comment";
            this.AddCommentButton.UseVisualStyleBackColor = true;
            this.AddCommentButton.Click += new System.EventHandler(this.AddCommentButton_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.AddCommentButton);
            this.Controls.Add(this.MyCommentTextBox);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MyCommentTextBox;
        private System.Windows.Forms.Button AddCommentButton;
    }
}