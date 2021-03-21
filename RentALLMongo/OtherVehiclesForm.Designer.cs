
namespace RentALLMongo
{
    partial class OtherVehiclesForm
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.commentsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VehicleslistBox = new System.Windows.Forms.ListBox();
            this.DescriptionlistBox = new System.Windows.Forms.ListBox();
            this.MyBookmarkBtn = new System.Windows.Forms.Button();
            this.bookmarkBtn = new System.Windows.Forms.Button();
            this.requestBtn = new System.Windows.Forms.Button();
            this.myBookmarksBox = new System.Windows.Forms.ListBox();
            this.removeBookmarkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.Location = new System.Drawing.Point(510, 29);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(153, 24);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.Location = new System.Drawing.Point(510, 76);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(153, 24);
            this.modelComboBox.TabIndex = 0;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // userComboBox
            // 
            this.userComboBox.Location = new System.Drawing.Point(510, 123);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(153, 24);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userCcomboBox_SelectedIndexChanged);
            // 
            // commentsBtn
            // 
            this.commentsBtn.Location = new System.Drawing.Point(535, 162);
            this.commentsBtn.Name = "commentsBtn";
            this.commentsBtn.Size = new System.Drawing.Size(95, 49);
            this.commentsBtn.TabIndex = 1;
            this.commentsBtn.Text = "Show comments";
            this.commentsBtn.UseVisualStyleBackColor = true;
            this.commentsBtn.Click += new System.EventHandler(this.commentsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choose vehicle type first:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Choose vehicle model second:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose owner third:";
            // 
            // VehicleslistBox
            // 
            this.VehicleslistBox.FormattingEnabled = true;
            this.VehicleslistBox.ItemHeight = 16;
            this.VehicleslistBox.Location = new System.Drawing.Point(21, 25);
            this.VehicleslistBox.Name = "VehicleslistBox";
            this.VehicleslistBox.Size = new System.Drawing.Size(445, 84);
            this.VehicleslistBox.TabIndex = 5;
            this.VehicleslistBox.SelectedIndexChanged += new System.EventHandler(this.VehicleslistBox_SelectedIndexChanged);
            // 
            // DescriptionlistBox
            // 
            this.DescriptionlistBox.FormattingEnabled = true;
            this.DescriptionlistBox.ItemHeight = 16;
            this.DescriptionlistBox.Location = new System.Drawing.Point(21, 139);
            this.DescriptionlistBox.Name = "DescriptionlistBox";
            this.DescriptionlistBox.Size = new System.Drawing.Size(445, 84);
            this.DescriptionlistBox.TabIndex = 7;
            this.DescriptionlistBox.SelectedIndexChanged += new System.EventHandler(this.DescriptionlistBox_SelectedIndexChanged);
            // 
            // MyBookmarkBtn
            // 
            this.MyBookmarkBtn.Location = new System.Drawing.Point(269, 363);
            this.MyBookmarkBtn.Name = "MyBookmarkBtn";
            this.MyBookmarkBtn.Size = new System.Drawing.Size(136, 38);
            this.MyBookmarkBtn.TabIndex = 8;
            this.MyBookmarkBtn.Text = "My bookmarks";
            this.MyBookmarkBtn.UseVisualStyleBackColor = true;
            this.MyBookmarkBtn.Click += new System.EventHandler(this.MyBookmarkBtn_Click);
            // 
            // bookmarkBtn
            // 
            this.bookmarkBtn.Location = new System.Drawing.Point(21, 254);
            this.bookmarkBtn.Name = "bookmarkBtn";
            this.bookmarkBtn.Size = new System.Drawing.Size(97, 52);
            this.bookmarkBtn.TabIndex = 9;
            this.bookmarkBtn.Text = "Bookmark";
            this.bookmarkBtn.UseVisualStyleBackColor = true;
            this.bookmarkBtn.Click += new System.EventHandler(this.bookmarkBtn_Click);
            // 
            // requestBtn
            // 
            this.requestBtn.Location = new System.Drawing.Point(22, 336);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(96, 52);
            this.requestBtn.TabIndex = 10;
            this.requestBtn.Text = "Send rent request";
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // myBookmarksBox
            // 
            this.myBookmarksBox.FormattingEnabled = true;
            this.myBookmarksBox.ItemHeight = 16;
            this.myBookmarksBox.Location = new System.Drawing.Point(222, 260);
            this.myBookmarksBox.Name = "myBookmarksBox";
            this.myBookmarksBox.Size = new System.Drawing.Size(451, 84);
            this.myBookmarksBox.TabIndex = 11;
            this.myBookmarksBox.SelectedIndexChanged += new System.EventHandler(this.myBookmarksBox_SelectedIndexChanged);
            // 
            // removeBookmarkBtn
            // 
            this.removeBookmarkBtn.Location = new System.Drawing.Point(485, 363);
            this.removeBookmarkBtn.Name = "removeBookmarkBtn";
            this.removeBookmarkBtn.Size = new System.Drawing.Size(136, 38);
            this.removeBookmarkBtn.TabIndex = 12;
            this.removeBookmarkBtn.Text = "Remove bookmark";
            this.removeBookmarkBtn.UseVisualStyleBackColor = true;
            this.removeBookmarkBtn.Click += new System.EventHandler(this.removeBookmarkBtn_Click);
            // 
            // OtherVehiclesForm
            // 
            this.ClientSize = new System.Drawing.Size(707, 413);
            this.Controls.Add(this.removeBookmarkBtn);
            this.Controls.Add(this.myBookmarksBox);
            this.Controls.Add(this.requestBtn);
            this.Controls.Add(this.bookmarkBtn);
            this.Controls.Add(this.MyBookmarkBtn);
            this.Controls.Add(this.DescriptionlistBox);
            this.Controls.Add(this.VehicleslistBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commentsBtn);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Name = "OtherVehiclesForm";
            this.Load += new System.EventHandler(this.OtherVehiclesForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Button commentsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox VehicleslistBox;
        private System.Windows.Forms.ListBox DescriptionlistBox;
        private System.Windows.Forms.Button MyBookmarkBtn;
        private System.Windows.Forms.Button bookmarkBtn;
        private System.Windows.Forms.Button requestBtn;
        private System.Windows.Forms.ListBox myBookmarksBox;
        private System.Windows.Forms.Button removeBookmarkBtn;
    }
}