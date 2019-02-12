using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace black_hole
{
    public partial class AddHoleUI : Form
    {
        public Hole CreatedHole { get; set; }

        public AddHoleUI()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(fileFolderRadio.Checked)
            {
                fuseMpUI.Enabled = false;
                pathField.Enabled = true;
                pathBrowseBtn.Enabled = true;
            }
        }

        private void AddHoleUI_Load(object sender, EventArgs e)
        {
            
        }

        private void fuseDriveRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fuseDriveRadio.Checked)
            {
                fuseMpUI.Enabled = true;
                pathField.Enabled = false;
                pathBrowseBtn.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreatedHole = new Hole();
            if(fileFolderRadio.Checked)
            {
                if (!Directory.Exists(pathField.Text)) Directory.CreateDirectory(pathField.Text);
                CreatedHole.Target = pathField.Text;
                CreatedHole.Type = HoleType.Folder;
            }
            else
            {
                CreatedHole.Target = pathField.Text;
                CreatedHole.Type = HoleType.FUSE;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pathBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a folder";
            fbd.ShowNewFolderButton = true;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(fbd.SelectedPath)) Directory.CreateDirectory(fbd.SelectedPath);
                pathField.Text = fbd.SelectedPath;
            }
        }
    }
}
