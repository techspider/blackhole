namespace black_hole
{
    partial class AddHoleUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHoleUI));
            this.window_title = new System.Windows.Forms.Label();
            this.holeTypeUI = new System.Windows.Forms.GroupBox();
            this.fileFolderRadio = new System.Windows.Forms.RadioButton();
            this.fuseDriveRadio = new System.Windows.Forms.RadioButton();
            this.fuseMpUI = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderPathUILbl = new System.Windows.Forms.Label();
            this.pathField = new System.Windows.Forms.TextBox();
            this.pathBrowseBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.holeTypeUI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // window_title
            // 
            this.window_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.window_title.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_title.Location = new System.Drawing.Point(15, 15);
            this.window_title.Name = "window_title";
            this.window_title.Size = new System.Drawing.Size(359, 51);
            this.window_title.TabIndex = 8;
            this.window_title.Text = "Create New Hole";
            // 
            // holeTypeUI
            // 
            this.holeTypeUI.Controls.Add(this.fuseMpUI);
            this.holeTypeUI.Controls.Add(this.fuseDriveRadio);
            this.holeTypeUI.Controls.Add(this.fileFolderRadio);
            this.holeTypeUI.Dock = System.Windows.Forms.DockStyle.Top;
            this.holeTypeUI.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holeTypeUI.ForeColor = System.Drawing.Color.Black;
            this.holeTypeUI.Location = new System.Drawing.Point(15, 66);
            this.holeTypeUI.Name = "holeTypeUI";
            this.holeTypeUI.Size = new System.Drawing.Size(359, 83);
            this.holeTypeUI.TabIndex = 9;
            this.holeTypeUI.TabStop = false;
            this.holeTypeUI.Text = "Type";
            // 
            // fileFolderRadio
            // 
            this.fileFolderRadio.AutoSize = true;
            this.fileFolderRadio.Checked = true;
            this.fileFolderRadio.Location = new System.Drawing.Point(15, 25);
            this.fileFolderRadio.Name = "fileFolderRadio";
            this.fileFolderRadio.Size = new System.Drawing.Size(81, 18);
            this.fileFolderRadio.TabIndex = 0;
            this.fileFolderRadio.TabStop = true;
            this.fileFolderRadio.Text = "File Folder";
            this.fileFolderRadio.UseVisualStyleBackColor = true;
            this.fileFolderRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fuseDriveRadio
            // 
            this.fuseDriveRadio.AutoSize = true;
            this.fuseDriveRadio.Location = new System.Drawing.Point(15, 49);
            this.fuseDriveRadio.Name = "fuseDriveRadio";
            this.fuseDriveRadio.Size = new System.Drawing.Size(244, 18);
            this.fuseDriveRadio.TabIndex = 1;
            this.fuseDriveRadio.Text = "FUSE Drive with mount point/drive letter";
            this.fuseDriveRadio.UseVisualStyleBackColor = true;
            this.fuseDriveRadio.CheckedChanged += new System.EventHandler(this.fuseDriveRadio_CheckedChanged);
            // 
            // fuseMpUI
            // 
            this.fuseMpUI.Enabled = false;
            this.fuseMpUI.FormattingEnabled = true;
            this.fuseMpUI.Location = new System.Drawing.Point(265, 48);
            this.fuseMpUI.Name = "fuseMpUI";
            this.fuseMpUI.Size = new System.Drawing.Size(58, 22);
            this.fuseMpUI.TabIndex = 2;
            this.fuseMpUI.Text = "Z:\\";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pathBrowseBtn);
            this.groupBox1.Controls.Add(this.pathField);
            this.groupBox1.Controls.Add(this.folderPathUILbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // folderPathUILbl
            // 
            this.folderPathUILbl.AutoSize = true;
            this.folderPathUILbl.Location = new System.Drawing.Point(9, 20);
            this.folderPathUILbl.Name = "folderPathUILbl";
            this.folderPathUILbl.Size = new System.Drawing.Size(70, 14);
            this.folderPathUILbl.TabIndex = 0;
            this.folderPathUILbl.Text = "Folder Path:";
            // 
            // pathField
            // 
            this.pathField.Location = new System.Drawing.Point(85, 17);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(235, 20);
            this.pathField.TabIndex = 1;
            // 
            // pathBrowseBtn
            // 
            this.pathBrowseBtn.Location = new System.Drawing.Point(324, 17);
            this.pathBrowseBtn.Name = "pathBrowseBtn";
            this.pathBrowseBtn.Size = new System.Drawing.Size(24, 21);
            this.pathBrowseBtn.TabIndex = 2;
            this.pathBrowseBtn.Text = "...";
            this.pathBrowseBtn.UseVisualStyleBackColor = true;
            this.pathBrowseBtn.Click += new System.EventHandler(this.pathBrowseBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(296, 389);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(215, 389);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddHoleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 430);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.holeTypeUI);
            this.Controls.Add(this.window_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddHoleUI";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Hole";
            this.Load += new System.EventHandler(this.AddHoleUI_Load);
            this.holeTypeUI.ResumeLayout(false);
            this.holeTypeUI.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label window_title;
        private System.Windows.Forms.GroupBox holeTypeUI;
        private System.Windows.Forms.RadioButton fileFolderRadio;
        private System.Windows.Forms.RadioButton fuseDriveRadio;
        private System.Windows.Forms.ComboBox fuseMpUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pathBrowseBtn;
        private System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.Label folderPathUILbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}