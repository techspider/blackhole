namespace black_hole
{
    partial class BlackHoleUIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackHoleUIMain));
            this.appMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statstrp = new System.Windows.Forms.StatusStrip();
            this.holeStatLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabc = new System.Windows.Forms.TabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.tab_holemgr = new System.Windows.Forms.TabPage();
            this.pnl = new System.Windows.Forms.Panel();
            this.bh_desc = new System.Windows.Forms.Label();
            this.bh_title = new System.Windows.Forms.Label();
            this.holeActions = new System.Windows.Forms.Panel();
            this.holeView = new System.Windows.Forms.ListView();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.hdr_holePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_holeDelOps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdr_holeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bh_image = new System.Windows.Forms.PictureBox();
            this.appMenu.SuspendLayout();
            this.statstrp.SuspendLayout();
            this.tabc.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_holemgr.SuspendLayout();
            this.holeActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bh_image)).BeginInit();
            this.SuspendLayout();
            // 
            // appMenu
            // 
            this.appMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.appMenu.Location = new System.Drawing.Point(0, 0);
            this.appMenu.Name = "appMenu";
            this.appMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.appMenu.Size = new System.Drawing.Size(389, 24);
            this.appMenu.TabIndex = 0;
            this.appMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statstrp
            // 
            this.statstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holeStatLabel});
            this.statstrp.Location = new System.Drawing.Point(0, 408);
            this.statstrp.Name = "statstrp";
            this.statstrp.Size = new System.Drawing.Size(389, 22);
            this.statstrp.TabIndex = 1;
            this.statstrp.Text = "stat";
            // 
            // holeStatLabel
            // 
            this.holeStatLabel.IsLink = true;
            this.holeStatLabel.Name = "holeStatLabel";
            this.holeStatLabel.Size = new System.Drawing.Size(109, 17);
            this.holeStatLabel.Text = "0 black holes active";
            this.holeStatLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tabc
            // 
            this.tabc.Controls.Add(this.tab_main);
            this.tabc.Controls.Add(this.tab_holemgr);
            this.tabc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabc.Location = new System.Drawing.Point(0, 24);
            this.tabc.Name = "tabc";
            this.tabc.SelectedIndex = 0;
            this.tabc.Size = new System.Drawing.Size(389, 384);
            this.tabc.TabIndex = 2;
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.pnl);
            this.tab_main.Controls.Add(this.bh_desc);
            this.tab_main.Controls.Add(this.bh_title);
            this.tab_main.Controls.Add(this.bh_image);
            this.tab_main.Location = new System.Drawing.Point(4, 22);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(381, 358);
            this.tab_main.TabIndex = 0;
            this.tab_main.Text = "Welcome";
            this.tab_main.UseVisualStyleBackColor = true;
            // 
            // tab_holemgr
            // 
            this.tab_holemgr.Controls.Add(this.holeView);
            this.tab_holemgr.Controls.Add(this.holeActions);
            this.tab_holemgr.Location = new System.Drawing.Point(4, 22);
            this.tab_holemgr.Name = "tab_holemgr";
            this.tab_holemgr.Padding = new System.Windows.Forms.Padding(3);
            this.tab_holemgr.Size = new System.Drawing.Size(381, 358);
            this.tab_holemgr.TabIndex = 1;
            this.tab_holemgr.Text = "Holes";
            this.tab_holemgr.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(3, 252);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(375, 28);
            this.pnl.TabIndex = 9;
            // 
            // bh_desc
            // 
            this.bh_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bh_desc.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.bh_desc.Location = new System.Drawing.Point(3, 211);
            this.bh_desc.Name = "bh_desc";
            this.bh_desc.Size = new System.Drawing.Size(375, 41);
            this.bh_desc.TabIndex = 8;
            this.bh_desc.Text = "This tool allows you to create folders/drives with /dev/null like behavior (a bla" +
    "ck hole).";
            this.bh_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bh_title
            // 
            this.bh_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.bh_title.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bh_title.Location = new System.Drawing.Point(3, 178);
            this.bh_title.Name = "bh_title";
            this.bh_title.Size = new System.Drawing.Size(375, 33);
            this.bh_title.TabIndex = 7;
            this.bh_title.Text = "Welcome to Black Hole!";
            this.bh_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // holeActions
            // 
            this.holeActions.Controls.Add(this.btnStat);
            this.holeActions.Controls.Add(this.delBtn);
            this.holeActions.Controls.Add(this.addBtn);
            this.holeActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.holeActions.Location = new System.Drawing.Point(3, 3);
            this.holeActions.Name = "holeActions";
            this.holeActions.Size = new System.Drawing.Size(375, 27);
            this.holeActions.TabIndex = 0;
            // 
            // holeView
            // 
            this.holeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdr_holePath,
            this.hdr_holeType,
            this.hdr_holeDelOps});
            this.holeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holeView.Location = new System.Drawing.Point(3, 30);
            this.holeView.Name = "holeView";
            this.holeView.Size = new System.Drawing.Size(375, 325);
            this.holeView.TabIndex = 1;
            this.holeView.UseCompatibleStateImageBehavior = false;
            this.holeView.View = System.Windows.Forms.View.Details;
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(41, 27);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delBtn.Location = new System.Drawing.Point(41, 0);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(41, 27);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Del";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // btnStat
            // 
            this.btnStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStat.Location = new System.Drawing.Point(82, 0);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(41, 27);
            this.btnStat.TabIndex = 2;
            this.btnStat.Text = "Stat";
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // hdr_holePath
            // 
            this.hdr_holePath.Text = "Path";
            this.hdr_holePath.Width = 233;
            // 
            // hdr_holeDelOps
            // 
            this.hdr_holeDelOps.Text = "Delete Ops";
            this.hdr_holeDelOps.Width = 81;
            // 
            // hdr_holeType
            // 
            this.hdr_holeType.Text = "Type";
            this.hdr_holeType.Width = 54;
            // 
            // bh_image
            // 
            this.bh_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.bh_image.Image = global::black_hole.Properties.Resources.devnull;
            this.bh_image.Location = new System.Drawing.Point(3, 3);
            this.bh_image.Name = "bh_image";
            this.bh_image.Size = new System.Drawing.Size(375, 175);
            this.bh_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bh_image.TabIndex = 6;
            this.bh_image.TabStop = false;
            // 
            // BlackHoleUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 430);
            this.Controls.Add(this.tabc);
            this.Controls.Add(this.statstrp);
            this.Controls.Add(this.appMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.appMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "BlackHoleUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Hole";
            this.Load += new System.EventHandler(this.BlackHoleUIMain_Load);
            this.appMenu.ResumeLayout(false);
            this.appMenu.PerformLayout();
            this.statstrp.ResumeLayout(false);
            this.statstrp.PerformLayout();
            this.tabc.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_holemgr.ResumeLayout(false);
            this.holeActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bh_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip appMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statstrp;
        private System.Windows.Forms.ToolStripStatusLabel holeStatLabel;
        private System.Windows.Forms.TabControl tabc;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label bh_desc;
        private System.Windows.Forms.Label bh_title;
        private System.Windows.Forms.PictureBox bh_image;
        private System.Windows.Forms.TabPage tab_holemgr;
        private System.Windows.Forms.ListView holeView;
        private System.Windows.Forms.Panel holeActions;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.ColumnHeader hdr_holePath;
        private System.Windows.Forms.ColumnHeader hdr_holeDelOps;
        private System.Windows.Forms.ColumnHeader hdr_holeType;
    }
}

