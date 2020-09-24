using SharpDX.Direct2D1;
using SharpDX.WIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Xna.Framework.Input;

namespace TestGame01
{
    public partial class wnd_MenuGame : Form
    {
        private string verify;
        private string modeMove;
        public string screenMode;
        private GraphicsDeviceManager windows;
        public wnd_MenuGame(string moveMode,string screenMode,GraphicsDeviceManager windows)
        {
            this.modeMove = moveMode;
            this.windows = windows;
            this.screenMode = screenMode;
            InitializeComponent();
            if (rdbMove1.Text == moveMode) rdbMove1.Checked = true;
            if (rdbMove2.Text == moveMode) rdbMove2.Checked = true;
            if (cmdWindows.Text == screenMode) cmdFullscreen.Enabled = true;
            if (cmdFullscreen.Text == screenMode) cmdWindows.Enabled = true;
            
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
            if (rdbJump.Checked) verify = "Jump";
            cmdApply.Enabled = false;
            lblMoveChoice.Visible = true;
            cmdApply.Visible = true;
            cmd_Cancels.Visible = true;
            rdbMove1.Visible = true;
            rdbMove2.Visible = true;
            lblResolution.Visible = true;
            cmdFullscreen.Visible = true;
            cmdWindows.Visible = true;
            rdbJump.Visible = true;
            cmd_Setting.Visible = false;
            cmd_Resume.Visible = false;
        }
        public string MoveMode
        {
            get { return modeMove; }
        }
        public string ScreenMode
        {
            get { return screenMode; }
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
            if (rdbJump.Text == verify) rdbJump.Checked = true;
            lblMoveChoice.Visible = false;
            cmdApply.Visible = false;
            cmd_Cancels.Visible = false;
            rdbMove1.Visible = false;
            rdbMove2.Visible = false;
            rdbJump.Visible = false;
            cmdApply.Enabled = false;
            cmd_Setting.Visible = true;
            cmd_Resume.Visible = true;
            lblResolution.Visible = false;
            cmdFullscreen.Visible = false;
            cmdWindows.Visible = false;
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            lblMoveChoice.Visible = false;
            cmdApply.Visible = false;
            cmd_Cancels.Visible = false;
            rdbMove1.Visible = false;
            rdbJump.Visible = false;
            rdbMove2.Visible = false;
            cmdApply.Enabled = false;
            cmd_Setting.Visible = true;
            cmd_Resume.Visible = true;
            lblResolution.Visible = false;
            cmdFullscreen.Visible = false;
            cmdWindows.Visible = false;
            windows.ApplyChanges();
        }

        private void cmdFullscreen_Click(object sender, EventArgs e)
        {
            cmdApply.Enabled = true;
            cmdFullscreen.Enabled = false;
            cmdWindows.Enabled = true;            
            screenMode = "Fullscreen";
            

        }
         
        private void cmdWindows_Click(object sender, EventArgs e)
        {
            cmdApply.Enabled = true;
            cmdFullscreen.Enabled = true;
            cmdWindows.Enabled = false;                       
            screenMode = "Windows";
        }
        public int[] Resolution
        {
            get 
            {
                int[] resolution = { windows.PreferredBackBufferWidth,windows.PreferredBackBufferHeight };
                return resolution; 
            }
        }
        private void wnd_MenuGame_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                Close();
            }
        }

        private void rdbJump_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJump.Checked) modeMove = rdbJump.Text;
            cmdApply.Enabled = true;
        }
    }
}
