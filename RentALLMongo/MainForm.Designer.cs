﻿namespace RentALLMongo
{
    partial class MainForm
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
            this.UsersButton = new System.Windows.Forms.Button();
            this.VehiclesButton = new System.Windows.Forms.Button();
            this.ReviewsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(65, 70);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(109, 37);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // VehiclesButton
            // 
            this.VehiclesButton.Location = new System.Drawing.Point(65, 141);
            this.VehiclesButton.Name = "VehiclesButton";
            this.VehiclesButton.Size = new System.Drawing.Size(109, 36);
            this.VehiclesButton.TabIndex = 1;
            this.VehiclesButton.Text = "Vehicles";
            this.VehiclesButton.UseVisualStyleBackColor = true;
            this.VehiclesButton.Click += new System.EventHandler(this.VehiclesButton_Click);
            // 
            // ReviewsButton
            // 
            this.ReviewsButton.Location = new System.Drawing.Point(65, 214);
            this.ReviewsButton.Name = "ReviewsButton";
            this.ReviewsButton.Size = new System.Drawing.Size(109, 41);
            this.ReviewsButton.TabIndex = 2;
            this.ReviewsButton.Text = "Reviews";
            this.ReviewsButton.UseVisualStyleBackColor = true;
            this.ReviewsButton.Click += new System.EventHandler(this.ReviewsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 379);
            this.Controls.Add(this.ReviewsButton);
            this.Controls.Add(this.VehiclesButton);
            this.Controls.Add(this.UsersButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button VehiclesButton;
        private System.Windows.Forms.Button ReviewsButton;
    }
}