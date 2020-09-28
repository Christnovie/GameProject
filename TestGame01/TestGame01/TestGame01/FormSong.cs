using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestGame01
{
    public partial class FormSong : Form
    {
        public FormSong()
        {
            InitializeComponent();
            StartPosition = new Form().StartPosition;
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
