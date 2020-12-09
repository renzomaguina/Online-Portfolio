namespace DisplayAuthors
{
    partial class AuthorsTable
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
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();                                          
            this.findButton = new System.Windows.Forms.Button();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.browseAllButton = new System.Windows.Forms.Button();
            this.findGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.findGroupBox.Controls.Add(this.findButton);
            this.findGroupBox.Controls.Add(this.findTextBox);
            this.findGroupBox.Location = new System.Drawing.Point(12, 177);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(248, 61);
            this.findGroupBox.TabIndex = 12;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Find an entry by last name";
            // 
            // browseAllButton
            // 
            this.browseAllButton.Location = new System.Drawing.Point(91, 255);
            this.browseAllButton.Name = "browseAllButton";
            this.browseAllButton.Size = new System.Drawing.Size(116, 23);
            this.browseAllButton.TabIndex = 13;
            this.browseAllButton.Text = "Browse All Entries";
            this.browseAllButton.UseVisualStyleBackColor = true;
            this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
            // 
            // AuthorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.browseAllButton);
            this.Controls.Add(this.findGroupBox);
            this.Name = "AuthorsTable";
            this.Text = "Form1";
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.Button browseAllButton;
    }
}

