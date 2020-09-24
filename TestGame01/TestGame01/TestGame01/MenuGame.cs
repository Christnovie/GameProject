using SharpDX.Direct2D1;
using SharpDX.WIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace TestGame01
{
    public partial class wnd_MenuGame : Form
    {
        private string verify;
        private string modeMove;
        public wnd_MenuGame(string moveMode)
        {
            InitializeComponent();
            if (rdbMove1.Text == moveMode) rdbMove1.Checked = true;
            if (rdbMove2.Text == moveMode) rdbMove2.Checked = true;
            
        }

        private void cmd_Resume_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void wnd_MenuGame_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Setting_Click(object sender, EventArgs e)
        {
            if (rdbMove1.Checked) verify = "Infinity";
            if (rdbMove2.Checked) verify = "Close";
            cmdApply.Enabled = false;
            lblMoveChoice.Visible = true;
            cmdApply.Visible = true;
            cmd_Cancels.Visible = true;
            rdbMove1.Visible = true;
            rdbMove2.Visible = true;
            cmd_Setting.Visible = false;
            cmd_Resume.Visible = false;
        }
        public string MoveMode
        {
            get { return modeMove; }
        }

        private void rdbMove1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMove1.Checked) modeMove = rdbMove1.Text;
            cmdApply.Enabled = true;
        }

        private void rdbMove2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMove2.Checked) modeMove = rdbMove2.Text;
            cmdApply.Enabled = true;
        }

        private void cmd_Cancels_Click(object sender, EventArgs e)
        {
            if (rdbMove1.Text == verify) rdbMove1.Checked = true;
            if (rdbMove2.Text == verify) rdbMove2.Checked = true;
            lblMoveChoice.Visible = false;
            cmdApply.Visible = false;
            cmd_Cancels.Visible = false;
            rdbMove1.Visible = false;
            rdbMove2.Visible = false;
            cmdApply.Enabled = false;
            cmd_Setting.Visible = true;
            cmd_Resume.Visible = true;
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            lblMoveChoice.Visible = false;
            cmdApply.Visible = false;
            cmd_Cancels.Visible = false;
            rdbMove1.Visible = false;
            rdbMove2.Visible = false;
            cmdApply.Enabled = false;
            cmd_Setting.Visible = true;
            cmd_Resume.Visible = true;
        }
    }
}
