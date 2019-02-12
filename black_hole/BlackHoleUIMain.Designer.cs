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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statstrp = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.tab_holemgr = new System.Windows.Forms.TabPage();
            this.pnl = new System.Windows.Forms.Panel();
            this.bh_desc = new System.Windows.Forms.Label();
            this.bh_title = new System.Windows.Forms.Label();
            this.bh_image = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statstrp.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bh_image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statstrp
            // 
            this.statstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statstrp.Location = new System.Drawing.Point(0, 408);
            this.statstrp.Name = "statstrp";
            this.statstrp.Size = new System.Drawing.Size(389, 22);
            this.statstrp.TabIndex = 1;
            this.statstrp.Text = "stat";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "0 black holes active";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_main);
            this.tabControl1.Controls.Add(this.tab_holemgr);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 384);
            this.tabControl1.TabIndex = 2;
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
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statstrp);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackHoleUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Hole";
            this.Load += new System.EventHandler(this.BlackHoleUIMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statstrp.ResumeLayout(false);
            this.statstrp.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bh_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statstrp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label bh_desc;
        private System.Windows.Forms.Label bh_title;
        private System.Windows.Forms.PictureBox bh_image;
        private System.Windows.Forms.TabPage tab_holemgr;
    }
}

