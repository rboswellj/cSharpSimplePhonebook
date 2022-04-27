
namespace PersonalInfoGui
{
    partial class PersonalInfoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.firstInLabel = new System.Windows.Forms.Label();
            this.firstInBox = new System.Windows.Forms.TextBox();
            this.middleInBox = new System.Windows.Forms.TextBox();
            this.middleInLabel = new System.Windows.Forms.Label();
            this.lastInBox = new System.Windows.Forms.TextBox();
            this.lastInLabel = new System.Windows.Forms.Label();
            this.phoneInBox = new System.Windows.Forms.TextBox();
            this.phoneInLabel = new System.Windows.Forms.Label();
            this.emailInBox = new System.Windows.Forms.TextBox();
            this.emailInLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directoryListBox
            // 
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.ItemHeight = 32;
            this.directoryListBox.Location = new System.Drawing.Point(33, 143);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(578, 356);
            this.directoryListBox.TabIndex = 2;
            this.directoryListBox.SelectedIndexChanged += new System.EventHandler(this.DirectoryListBox_SelectedIndexChanged);
            // 
            // firstInLabel
            // 
            this.firstInLabel.AutoSize = true;
            this.firstInLabel.Location = new System.Drawing.Point(23, 514);
            this.firstInLabel.Name = "firstInLabel";
            this.firstInLabel.Size = new System.Drawing.Size(134, 32);
            this.firstInLabel.TabIndex = 3;
            this.firstInLabel.Text = "First Name:";
            // 
            // firstInBox
            // 
            this.firstInBox.Location = new System.Drawing.Point(28, 549);
            this.firstInBox.Name = "firstInBox";
            this.firstInBox.Size = new System.Drawing.Size(266, 39);
            this.firstInBox.TabIndex = 4;
            // 
            // middleInBox
            // 
            this.middleInBox.Location = new System.Drawing.Point(28, 638);
            this.middleInBox.Name = "middleInBox";
            this.middleInBox.Size = new System.Drawing.Size(266, 39);
            this.middleInBox.TabIndex = 6;
            // 
            // middleInLabel
            // 
            this.middleInLabel.AutoSize = true;
            this.middleInLabel.Location = new System.Drawing.Point(23, 603);
            this.middleInLabel.Name = "middleInLabel";
            this.middleInLabel.Size = new System.Drawing.Size(285, 32);
            this.middleInLabel.TabIndex = 5;
            this.middleInLabel.Text = "Middle Name (Optional): ";
            // 
            // lastInBox
            // 
            this.lastInBox.Location = new System.Drawing.Point(28, 728);
            this.lastInBox.Name = "lastInBox";
            this.lastInBox.Size = new System.Drawing.Size(266, 39);
            this.lastInBox.TabIndex = 8;
            // 
            // lastInLabel
            // 
            this.lastInLabel.AutoSize = true;
            this.lastInLabel.Location = new System.Drawing.Point(28, 693);
            this.lastInLabel.Name = "lastInLabel";
            this.lastInLabel.Size = new System.Drawing.Size(131, 32);
            this.lastInLabel.TabIndex = 7;
            this.lastInLabel.Text = "Last Name:";
            // 
            // phoneInBox
            // 
            this.phoneInBox.Location = new System.Drawing.Point(345, 550);
            this.phoneInBox.Name = "phoneInBox";
            this.phoneInBox.Size = new System.Drawing.Size(266, 39);
            this.phoneInBox.TabIndex = 10;
            // 
            // phoneInLabel
            // 
            this.phoneInLabel.AutoSize = true;
            this.phoneInLabel.Location = new System.Drawing.Point(345, 515);
            this.phoneInLabel.Name = "phoneInLabel";
            this.phoneInLabel.Size = new System.Drawing.Size(182, 32);
            this.phoneInLabel.TabIndex = 9;
            this.phoneInLabel.Text = "Phone Number:";
            // 
            // emailInBox
            // 
            this.emailInBox.Location = new System.Drawing.Point(345, 639);
            this.emailInBox.Name = "emailInBox";
            this.emailInBox.Size = new System.Drawing.Size(266, 39);
            this.emailInBox.TabIndex = 12;
            // 
            // emailInLabel
            // 
            this.emailInLabel.AutoSize = true;
            this.emailInLabel.Location = new System.Drawing.Point(345, 603);
            this.emailInLabel.Name = "emailInLabel";
            this.emailInLabel.Size = new System.Drawing.Size(76, 32);
            this.emailInLabel.TabIndex = 11;
            this.emailInLabel.Text = "Email:";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(345, 721);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(266, 48);
            this.addUserButton.TabIndex = 13;
            this.addUserButton.Text = "Add / Update";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(345, 799);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(266, 48);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete Entry";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(28, 799);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(266, 48);
            this.clearSelectionButton.TabIndex = 16;
            this.clearSelectionButton.Text = "Clear Selection";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.ClearSelectionButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(289, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 42);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 44);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.ItemHeight = 36;
            this.cmbSearch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Phone Number",
            "Email"});
            this.cmbSearch.Location = new System.Drawing.Point(33, 35);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(250, 44);
            this.cmbSearch.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 44);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear Search";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // PersonalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 891);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.emailInBox);
            this.Controls.Add(this.emailInLabel);
            this.Controls.Add(this.phoneInBox);
            this.Controls.Add(this.phoneInLabel);
            this.Controls.Add(this.lastInBox);
            this.Controls.Add(this.lastInLabel);
            this.Controls.Add(this.middleInBox);
            this.Controls.Add(this.middleInLabel);
            this.Controls.Add(this.firstInBox);
            this.Controls.Add(this.firstInLabel);
            this.Controls.Add(this.directoryListBox);
            this.Name = "PersonalInfoForm";
            this.Text = "Personal Info Collector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.Label firstInLabel;
        private System.Windows.Forms.TextBox firstInBox;
        private System.Windows.Forms.TextBox middleInBox;
        private System.Windows.Forms.Label middleInLabel;
        private System.Windows.Forms.TextBox lastInBox;
        private System.Windows.Forms.Label lastInLabel;
        private System.Windows.Forms.TextBox phoneInBox;
        private System.Windows.Forms.Label phoneInLabel;
        private System.Windows.Forms.TextBox emailInBox;
        private System.Windows.Forms.Label emailInLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnClear;
    }
}

