namespace DisplayTable
{
    partial class DisplayBaseballTable
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
            this.baseballDataSet = new System.Windows.Forms.BindingSource(this.components);
            this.baseballDataGridView = new System.Windows.Forms.DataGridView();
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.browseAllButton = new System.Windows.Forms.Button();
            this.DisplayPlayersTable = new System.Windows.Forms.GroupBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battingAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataGridView)).BeginInit();
            this.findGroupBox.SuspendLayout();
            this.DisplayPlayersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baseballDataSet
            // 
            this.baseballDataSet.DataSource = typeof(DisplayTable.BaseballDataSet);
            this.baseballDataSet.Position = 0;
            // 
            // baseballDataGridView
            // 
            this.baseballDataGridView.AllowUserToOrderColumns = true;
            this.baseballDataGridView.AutoGenerateColumns = false;
            this.baseballDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseballDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.battingAverageDataGridViewTextBoxColumn});
            this.baseballDataGridView.DataSource = this.playersBindingSource;
            this.baseballDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseballDataGridView.Location = new System.Drawing.Point(0, 0);
            this.baseballDataGridView.Name = "baseballDataGridView";
            this.baseballDataGridView.Size = new System.Drawing.Size(463, 329);
            this.baseballDataGridView.TabIndex = 1;
            this.baseballDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.baseballDataGridView_CellContentClick);
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(6, 33);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(61, 13);
            this.findLabel.TabIndex = 2;
            this.findLabel.Text = "Last Name:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(73, 30);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(109, 20);
            this.findTextBox.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(188, 30);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findGroupBox
            // 
            this.findGroupBox.Controls.Add(this.findLabel);
            this.findGroupBox.Controls.Add(this.findButton);
            this.findGroupBox.Controls.Add(this.findTextBox);
            this.findGroupBox.Location = new System.Drawing.Point(91, 19);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(274, 65);
            this.findGroupBox.TabIndex = 5;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Find a player by last name";
            // 
            // browseAllButton
            // 
            this.browseAllButton.Location = new System.Drawing.Point(171, 106);
            this.browseAllButton.Name = "browseAllButton";
            this.browseAllButton.Size = new System.Drawing.Size(119, 23);
            this.browseAllButton.TabIndex = 6;
            this.browseAllButton.Text = "Browse All Entries";
            this.browseAllButton.UseVisualStyleBackColor = true;
            this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
            // 
            // DisplayPlayersTable
            // 
            this.DisplayPlayersTable.Controls.Add(this.findGroupBox);
            this.DisplayPlayersTable.Controls.Add(this.browseAllButton);
            this.DisplayPlayersTable.Location = new System.Drawing.Point(0, 194);
            this.DisplayPlayersTable.Name = "DisplayPlayersTable";
            this.DisplayPlayersTable.Size = new System.Drawing.Size(463, 135);
            this.DisplayPlayersTable.TabIndex = 7;
            this.DisplayPlayersTable.TabStop = false;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.baseballDataSet;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            this.playerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // battingAverageDataGridViewTextBoxColumn
            // 
            this.battingAverageDataGridViewTextBoxColumn.DataPropertyName = "BattingAverage";
            this.battingAverageDataGridViewTextBoxColumn.HeaderText = "BattingAverage";
            this.battingAverageDataGridViewTextBoxColumn.Name = "battingAverageDataGridViewTextBoxColumn";
            // 
            // DisplayBaseballTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 329);
            this.Controls.Add(this.DisplayPlayersTable);
            this.Controls.Add(this.baseballDataGridView);
            this.Name = "DisplayBaseballTable";
            this.Text = "Baseball Players";
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataGridView)).EndInit();
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.DisplayPlayersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource baseballDataSet;
        private System.Windows.Forms.DataGridView baseballDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.Button browseAllButton;
        private System.Windows.Forms.GroupBox DisplayPlayersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn battingAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playersBindingSource;
    }
}

