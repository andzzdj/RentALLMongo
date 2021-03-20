namespace RentALLMongo
{
    partial class VehicleForm
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
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.myVehiclesButton = new System.Windows.Forms.Button();
            this.Vehicles = new System.Windows.Forms.ListBox();
            this.Description = new System.Windows.Forms.ListBox();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateTextBox = new System.Windows.Forms.RichTextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteVehicleButton = new System.Windows.Forms.Button();
            this.otherVehiclesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(205, 322);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(114, 47);
            this.AddVehicleButton.TabIndex = 0;
            this.AddVehicleButton.Text = "Add vehicle";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // myVehiclesButton
            // 
            this.myVehiclesButton.Location = new System.Drawing.Point(31, 322);
            this.myVehiclesButton.Name = "myVehiclesButton";
            this.myVehiclesButton.Size = new System.Drawing.Size(114, 47);
            this.myVehiclesButton.TabIndex = 10;
            this.myVehiclesButton.Text = "My vehicles";
            this.myVehiclesButton.UseVisualStyleBackColor = true;
            this.myVehiclesButton.Click += new System.EventHandler(this.myVehiclesButton_Click);
            // 
            // Vehicles
            // 
            this.Vehicles.FormattingEnabled = true;
            this.Vehicles.ItemHeight = 16;
            this.Vehicles.Location = new System.Drawing.Point(31, 22);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(461, 116);
            this.Vehicles.TabIndex = 11;
            this.Vehicles.SelectedIndexChanged += new System.EventHandler(this.Vehicles_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.FormattingEnabled = true;
            this.Description.ItemHeight = 16;
            this.Description.Location = new System.Drawing.Point(31, 162);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(461, 100);
            this.Description.TabIndex = 12;
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Items.AddRange(new object[] {
            "Daily price",
            "Description"});
            this.updateComboBox.Location = new System.Drawing.Point(554, 74);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(179, 24);
            this.updateComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Choose what you want to update:";
            // 
            // updateTextBox
            // 
            this.updateTextBox.Location = new System.Drawing.Point(554, 125);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(179, 65);
            this.updateTextBox.TabIndex = 15;
            this.updateTextBox.Text = "";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(596, 217);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(91, 45);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteVehicleButton
            // 
            this.deleteVehicleButton.Location = new System.Drawing.Point(378, 322);
            this.deleteVehicleButton.Name = "deleteVehicleButton";
            this.deleteVehicleButton.Size = new System.Drawing.Size(114, 47);
            this.deleteVehicleButton.TabIndex = 17;
            this.deleteVehicleButton.Text = "Delete vehicle";
            this.deleteVehicleButton.UseVisualStyleBackColor = true;
            this.deleteVehicleButton.Click += new System.EventHandler(this.deleteVehicleButton_Click);
            // 
            // otherVehiclesButton
            // 
            this.otherVehiclesButton.Location = new System.Drawing.Point(573, 322);
            this.otherVehiclesButton.Name = "otherVehiclesButton";
            this.otherVehiclesButton.Size = new System.Drawing.Size(114, 47);
            this.otherVehiclesButton.TabIndex = 18;
            this.otherVehiclesButton.Text = "Other vehicles";
            this.otherVehiclesButton.UseVisualStyleBackColor = true;
            this.otherVehiclesButton.Click += new System.EventHandler(this.otherVehiclesButton_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otherVehiclesButton);
            this.Controls.Add(this.deleteVehicleButton);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.updateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateComboBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Vehicles);
            this.Controls.Add(this.myVehiclesButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button myVehiclesButton;
        private System.Windows.Forms.ListBox Vehicles;
        private System.Windows.Forms.ListBox Description;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox updateTextBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteVehicleButton;
        private System.Windows.Forms.Button otherVehiclesButton;
    }
}