namespace AddressBook
{
    partial class Contacts
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
            System.Windows.Forms.Label addressIDLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.addressIDTextBox = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.browseAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.areaCodeTextBox = new System.Windows.Forms.TextBox();
            this.findAreaButton = new System.Windows.Forms.Button();
            this.areaCodeLabel = new System.Windows.Forms.Label();
            addressIDLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.findGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressIDLabel
            // 
            addressIDLabel.AutoSize = true;
            addressIDLabel.Location = new System.Drawing.Point(18, 37);
            addressIDLabel.Name = "addressIDLabel";
            addressIDLabel.Size = new System.Drawing.Size(62, 13);
            addressIDLabel.TabIndex = 0;
            addressIDLabel.Text = "Address ID:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(18, 63);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(18, 89);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(18, 115);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(18, 141);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 8;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addressIDTextBox
            // 
            this.addressIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "AddressID", true));
            this.addressIDTextBox.Location = new System.Drawing.Point(120, 34);
            this.addressIDTextBox.Name = "addressIDTextBox";
            this.addressIDTextBox.ReadOnly = true;
            this.addressIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.addressIDTextBox.TabIndex = 0;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(AddressExample.Address);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 60);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(140, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(120, 86);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(120, 112);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(120, 138);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(140, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(6, 24);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(61, 13);
            this.findLabel.TabIndex = 9;
            this.findLabel.Text = "Last Name:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(69, 21);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(92, 20);
            this.findTextBox.TabIndex = 10;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(167, 19);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 11;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findGroupBox
            // 
            this.findGroupBox.Controls.Add(this.findLabel);
            this.findGroupBox.Controls.Add(this.browseAllButton);
            this.findGroupBox.Controls.Add(this.findButton);
            this.findGroupBox.Controls.Add(this.findTextBox);
            this.findGroupBox.Location = new System.Drawing.Point(12, 177);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(248, 101);
            this.findGroupBox.TabIndex = 12;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Find an entry by last name";
            // 
            // browseAllButton
            // 
            this.browseAllButton.Location = new System.Drawing.Point(69, 61);
            this.browseAllButton.Name = "browseAllButton";
            this.browseAllButton.Size = new System.Drawing.Size(116, 23);
            this.browseAllButton.TabIndex = 13;
            this.browseAllButton.Text = "Browse All Entries";
            this.browseAllButton.UseVisualStyleBackColor = true;
            this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.areaCodeTextBox);
            this.groupBox1.Controls.Add(this.findAreaButton);
            this.groupBox1.Controls.Add(this.areaCodeLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find entries by area code";
            // 
            // areaCodeTextBox
            // 
            this.areaCodeTextBox.Location = new System.Drawing.Point(99, 39);
            this.areaCodeTextBox.Name = "areaCodeTextBox";
            this.areaCodeTextBox.Size = new System.Drawing.Size(118, 20);
            this.areaCodeTextBox.TabIndex = 2;
            // 
            // findAreaButton
            // 
            this.findAreaButton.Location = new System.Drawing.Point(12, 65);
            this.findAreaButton.Name = "findAreaButton";
            this.findAreaButton.Size = new System.Drawing.Size(75, 23);
            this.findAreaButton.TabIndex = 1;
            this.findAreaButton.Text = "Find";
            this.findAreaButton.UseVisualStyleBackColor = true;
            this.findAreaButton.Click += new System.EventHandler(this.findAreaButton_Click);
            // 
            // areaCodeLabel
            // 
            this.areaCodeLabel.AutoSize = true;
            this.areaCodeLabel.Location = new System.Drawing.Point(19, 42);
            this.areaCodeLabel.Name = "areaCodeLabel";
            this.areaCodeLabel.Size = new System.Drawing.Size(60, 13);
            this.areaCodeLabel.TabIndex = 0;
            this.areaCodeLabel.Text = "Area Code:";
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.findGroupBox);
            this.Controls.Add(addressIDLabel);
            this.Controls.Add(this.addressIDTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Name = "Contacts";
            this.Text = "Address Book";
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.TextBox addressIDTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.Button browseAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox areaCodeTextBox;
        private System.Windows.Forms.Button findAreaButton;
        private System.Windows.Forms.Label areaCodeLabel;
    }
}

