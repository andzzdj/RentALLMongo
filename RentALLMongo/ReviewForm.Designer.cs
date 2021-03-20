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
            this.AllCommentsListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteCommentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateCommentButton = new System.Windows.Forms.Button();
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
            // AllCommentsListbox
            // 
            this.AllCommentsListbox.FormattingEnabled = true;
            this.AllCommentsListbox.ItemHeight = 16;
            this.AllCommentsListbox.Location = new System.Drawing.Point(52, 45);
            this.AllCommentsListbox.Name = "AllCommentsListbox";
            this.AllCommentsListbox.Size = new System.Drawing.Size(248, 180);
            this.AllCommentsListbox.TabIndex = 2;
            this.AllCommentsListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllCommentsListbox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double click item in list below to see full comment\r\n";
            // 
            // DeleteCommentButton
            // 
            this.DeleteCommentButton.Location = new System.Drawing.Point(52, 276);
            this.DeleteCommentButton.Name = "DeleteCommentButton";
            this.DeleteCommentButton.Size = new System.Drawing.Size(120, 41);
            this.DeleteCommentButton.TabIndex = 5;
            this.DeleteCommentButton.Text = "Delete comment";
            this.DeleteCommentButton.UseVisualStyleBackColor = true;
            this.DeleteCommentButton.Click += new System.EventHandler(this.DeleteCommentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose comment from list above \r\nthen cick button below to delete it";
            // 
            // updateCommentButton
            // 
            this.updateCommentButton.Location = new System.Drawing.Point(569, 316);
            this.updateCommentButton.Name = "updateCommentButton";
            this.updateCommentButton.Size = new System.Drawing.Size(102, 49);
            this.updateCommentButton.TabIndex = 7;
            this.updateCommentButton.Text = "Update comment";
            this.updateCommentButton.UseVisualStyleBackColor = true;
            this.updateCommentButton.Click += new System.EventHandler(this.updateCommentButton_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.updateCommentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteCommentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllCommentsListbox);
            this.Controls.Add(this.AddCommentButton);
            this.Controls.Add(this.MyCommentTextBox);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MyCommentTextBox;
        private System.Windows.Forms.Button AddCommentButton;
        private System.Windows.Forms.ListBox AllCommentsListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteCommentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateCommentButton;
    }
}