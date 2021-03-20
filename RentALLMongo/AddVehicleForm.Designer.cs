namespace RentALLMongo
{
    partial class AddVehicleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleTypesCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VehicleModelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DailyPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductionYearTextbox = new System.Windows.Forms.TextBox();
            this.VehicleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddVehicleBtn = new System.Windows.Forms.Button();
            this.backAddVehicleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose vehicle type";
            // 
            // VehicleTypesCombobox
            // 
            this.VehicleTypesCombobox.FormattingEnabled = true;
            this.VehicleTypesCombobox.Location = new System.Drawing.Point(34, 56);
            this.VehicleTypesCombobox.Name = "VehicleTypesCombobox";
            this.VehicleTypesCombobox.Size = new System.Drawing.Size(121, 24);
            this.VehicleTypesCombobox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // VehicleModelTextBox
            // 
            this.VehicleModelTextBox.Location = new System.Drawing.Point(197, 131);
            this.VehicleModelTextBox.Name = "VehicleModelTextBox";
            this.VehicleModelTextBox.Size = new System.Drawing.Size(100, 22);
            this.VehicleModelTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Daily price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Production year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // DailyPriceTextBox
            // 
            this.DailyPriceTextBox.Location = new System.Drawing.Point(197, 180);
            this.DailyPriceTextBox.Name = "DailyPriceTextBox";
            this.DailyPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.DailyPriceTextBox.TabIndex = 7;
            // 
            // ProductionYearTextbox
            // 
            this.ProductionYearTextbox.Location = new System.Drawing.Point(197, 225);
            this.ProductionYearTextbox.Name = "ProductionYearTextbox";
            this.ProductionYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.ProductionYearTextbox.TabIndex = 8;
            // 
            // VehicleDescriptionTextBox
            // 
            this.VehicleDescriptionTextBox.Location = new System.Drawing.Point(197, 273);
            this.VehicleDescriptionTextBox.Multiline = true;
            this.VehicleDescriptionTextBox.Name = "VehicleDescriptionTextBox";
            this.VehicleDescriptionTextBox.Size = new System.Drawing.Size(201, 144);
            this.VehicleDescriptionTextBox.TabIndex = 9;
            // 
            // AddVehicleBtn
            // 
            this.AddVehicleBtn.Location = new System.Drawing.Point(44, 432);
            this.AddVehicleBtn.Name = "AddVehicleBtn";
            this.AddVehicleBtn.Size = new System.Drawing.Size(111, 49);
            this.AddVehicleBtn.TabIndex = 10;
            this.AddVehicleBtn.Text = "Add";
            this.AddVehicleBtn.UseVisualStyleBackColor = true;
            this.AddVehicleBtn.Click += new System.EventHandler(this.AddVehicleBtn_Click);
            // 
            // backAddVehicleBtn
            // 
            this.backAddVehicleBtn.Location = new System.Drawing.Point(287, 432);
            this.backAddVehicleBtn.Name = "backAddVehicleBtn";
            this.backAddVehicleBtn.Size = new System.Drawing.Size(111, 49);
            this.backAddVehicleBtn.TabIndex = 11;
            this.backAddVehicleBtn.Text = "Back";
            this.backAddVehicleBtn.UseVisualStyleBackColor = true;
            this.backAddVehicleBtn.Click += new System.EventHandler(this.backAddVehicleBtn_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 493);
            this.Controls.Add(this.backAddVehicleBtn);
            this.Controls.Add(this.AddVehicleBtn);
            this.Controls.Add(this.VehicleDescriptionTextBox);
            this.Controls.Add(this.ProductionYearTextbox);
            this.Controls.Add(this.DailyPriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VehicleModelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VehicleTypesCombobox);
            this.Controls.Add(this.label1);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VehicleTypesCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VehicleModelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DailyPriceTextBox;
        private System.Windows.Forms.TextBox ProductionYearTextbox;
        private System.Windows.Forms.TextBox VehicleDescriptionTextBox;
        private System.Windows.Forms.Button AddVehicleBtn;
        private System.Windows.Forms.Button backAddVehicleBtn;
    }
}