using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace black_hole
{
    public partial class BlackHoleUIMain : Form
    {
        public BlackHoleUIMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlackHoleUIMain_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddHoleUI ahui = new AddHoleUI();
            if(ahui.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
