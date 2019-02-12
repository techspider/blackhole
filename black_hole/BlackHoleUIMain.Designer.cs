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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statstrp = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bh_image = new System.Windows.Forms.PictureBox();
            this.bh_title = new System.Windows.Forms.Label();
            this.bh_desc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statstrp.SuspendLayout();
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
            // bh_image
            // 
            this.bh_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.bh_image.Image = global::black_hole.Properties.Resources.devnull;
            this.bh_image.Location = new System.Drawing.Point(0, 24);
            this.bh_image.Name = "bh_image";
            this.bh_image.Size = new System.Drawing.Size(389, 175);
            this.bh_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bh_image.TabIndex = 2;
            this.bh_image.TabStop = false;
            // 
            // bh_title
            // 
            this.bh_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.bh_title.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bh_title.Location = new System.Drawing.Point(0, 199);
            this.bh_title.Name = "bh_title";
            this.bh_title.Size = new System.Drawing.Size(389, 33);
            this.bh_title.TabIndex = 3;
            this.bh_title.Text = "Welcome to Black Hole!";
            this.bh_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bh_desc
            // 
            this.bh_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bh_desc.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.bh_desc.Location = new System.Drawing.Point(0, 232);
            this.bh_desc.Name = "bh_desc";
            this.bh_desc.Size = new System.Drawing.Size(389, 41);
            this.bh_desc.TabIndex = 4;
            this.bh_desc.Text = "This tool allows you to create folders/drives with /dev/null like behavior (a bla" +
    "ck hole).";
            this.bh_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlackHoleUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 430);
            this.Controls.Add(this.bh_desc);
            this.Controls.Add(this.bh_title);
            this.Controls.Add(this.bh_image);
            this.Controls.Add(this.statstrp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackHoleUIMain";
            this.Text = "Black Hole";
            this.Load += new System.EventHandler(this.BlackHoleUIMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statstrp.ResumeLayout(false);
            this.statstrp.PerformLayout();
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
        private System.Windows.Forms.PictureBox bh_image;
        private System.Windows.Forms.Label bh_title;
        private System.Windows.Forms.Label bh_desc;
    }
}

