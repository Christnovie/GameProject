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
       
        public wnd_MenuGame()
        {
            InitializeComponent();
        }

        private void cmd_Resume_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void wnd_MenuGame_Load(object sender, EventArgs e)
        {

        }
    }
}
