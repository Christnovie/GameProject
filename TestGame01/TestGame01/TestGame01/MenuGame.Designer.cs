namespace TestGame01
{
    partial class wnd_MenuGame
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
            this.cmd_Resume = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cmd_Setting = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.cmd_Cancels = new System.Windows.Forms.Button();
            this.rdbMove1 = new System.Windows.Forms.RadioButton();
            this.rdbMove2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoveChoice = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.cmdFullscreen = new System.Windows.Forms.Button();
            this.cmdWindows = new System.Windows.Forms.Button();
            this.rdbJump = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmd_Resume
            // 
            this.cmd_Resume.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Resume.FlatAppearance.BorderSize = 0;
            this.cmd_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Resume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Resume.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Resume.Location = new System.Drawing.Point(166, 138);
            this.cmd_Resume.Name = "cmd_Resume";
            this.cmd_Resume.Size = new System.Drawing.Size(189, 63);
            this.cmd_Resume.TabIndex = 0;
            this.cmd_Resume.Text = "Resume";
            this.cmd_Resume.UseVisualStyleBackColor = false;
            this.cmd_Resume.Click += new System.EventHandler(this.cmd_Resume_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitre.Location = new System.Drawing.Point(199, 60);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(122, 48);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "MENU";
            // 
            // cmd_Setting
            // 
            this.cmd_Setting.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Setting.FlatAppearance.BorderSize = 0;
            this.cmd_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Setting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Setting.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Setting.Location = new System.Drawing.Point(166, 243);
            this.cmd_Setting.Name = "cmd_Setting";
            this.cmd_Setting.Size = new System.Drawing.Size(189, 63);
            this.cmd_Setting.TabIndex = 0;
            this.cmd_Setting.Text = "Setting";
            this.cmd_Setting.UseVisualStyleBackColor = false;
            this.cmd_Setting.Click += new System.EventHandler(this.cmd_Setting_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.BackColor = System.Drawing.Color.Transparent;
            this.cmdApply.Enabled = false;
            this.cmdApply.FlatAppearance.BorderSize = 0;
            this.cmdApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdApply.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdApply.Location = new System.Drawing.Point(9, 507);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(189, 63);
            this.cmdApply.TabIndex = 0;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = false;
            this.cmdApply.Visible = false;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // cmd_Cancels
            // 
            this.cmd_Cancels.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Cancels.FlatAppearance.BorderSize = 0;
            this.cmd_Cancels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Cancels.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Cancels.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Cancels.Location = new System.Drawing.Point(289, 515);
            this.cmd_Cancels.Name = "cmd_Cancels";
            this.cmd_Cancels.Size = new System.Drawing.Size(189, 63);
            this.cmd_Cancels.TabIndex = 0;
            this.cmd_Cancels.Text = "Back";
            this.cmd_Cancels.UseVisualStyleBackColor = false;
            this.cmd_Cancels.Visible = false;
            this.cmd_Cancels.Click += new System.EventHandler(this.cmd_Cancels_Click);
            // 
            // rdbMove1
            // 
            this.rdbMove1.AutoSize = true;
            this.rdbMove1.Checked = true;
            this.rdbMove1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMove1.ForeColor = System.Drawing.SystemColors.Info;
            this.rdbMove1.Location = new System.Drawing.Point(199, 163);
            this.rdbMove1.Name = "rdbMove1";
            this.rdbMove1.Size = new System.Drawing.Size(113, 36);
            this.rdbMove1.TabIndex = 3;
            this.rdbMove1.TabStop = true;
            this.rdbMove1.Text = "Infinity";
            this.rdbMove1.UseVisualStyleBackColor = true;
            this.rdbMove1.Visible = false;
            this.rdbMove1.CheckedChanged += new System.EventHandler(this.rdbMove1_CheckedChanged);
            // 
            // rdbMove2
            // 
            this.rdbMove2.AutoSize = true;
            this.rdbMove2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMove2.ForeColor = System.Drawing.SystemColors.Info;
            this.rdbMove2.Location = new System.Drawing.Point(349, 162);
            this.rdbMove2.Name = "rdbMove2";
            this.rdbMove2.Size = new System.Drawing.Size(97, 36);
            this.rdbMove2.TabIndex = 3;
            this.rdbMove2.Text = "Close";
            this.rdbMove2.UseVisualStyleBackColor = true;
            this.rdbMove2.Visible = false;
            this.rdbMove2.CheckedChanged += new System.EventHandler(this.rdbMove2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblMoveChoice
            // 
            this.lblMoveChoice.AutoSize = true;
            this.lblMoveChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoveChoice.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMoveChoice.Location = new System.Drawing.Point(11, 163);
            this.lblMoveChoice.Name = "lblMoveChoice";
            this.lblMoveChoice.Size = new System.Drawing.Size(170, 32);
            this.lblMoveChoice.TabIndex = 5;
            this.lblMoveChoice.Text = "Move  choice :";
            this.lblMoveChoice.Visible = false;
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResolution.ForeColor = System.Drawing.SystemColors.Info;
            this.lblResolution.Location = new System.Drawing.Point(9, 370);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(210, 32);
            this.lblResolution.TabIndex = 5;
            this.lblResolution.Text = "Screen Resolution:";
            this.lblResolution.Visible = false;
            // 
            // cmdFullscreen
            // 
            this.cmdFullscreen.BackColor = System.Drawing.Color.Transparent;
            this.cmdFullscreen.Enabled = false;
            this.cmdFullscreen.FlatAppearance.BorderSize = 0;
            this.cmdFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFullscreen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdFullscreen.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdFullscreen.Location = new System.Drawing.Point(211, 357);
            this.cmdFullscreen.Name = "cmdFullscreen";
            this.cmdFullscreen.Size = new System.Drawing.Size(119, 63);
            this.cmdFullscreen.TabIndex = 0;
            this.cmdFullscreen.Text = "Fullscreen";
            this.cmdFullscreen.UseVisualStyleBackColor = false;
            this.cmdFullscreen.Visible = false;
            this.cmdFullscreen.Click += new System.EventHandler(this.cmdFullscreen_Click);
            // 
            // cmdWindows
            // 
            this.cmdWindows.BackColor = System.Drawing.Color.Transparent;
            this.cmdWindows.Enabled = false;
            this.cmdWindows.FlatAppearance.BorderSize = 0;
            this.cmdWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdWindows.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdWindows.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdWindows.Location = new System.Drawing.Point(336, 357);
            this.cmdWindows.Name = "cmdWindows";
            this.cmdWindows.Size = new System.Drawing.Size(127, 63);
            this.cmdWindows.TabIndex = 0;
            this.cmdWindows.Text = "Windows";
            this.cmdWindows.UseVisualStyleBackColor = false;
            this.cmdWindows.Visible = false;
            this.cmdWindows.Click += new System.EventHandler(this.cmdWindows_Click);
            // 
            // rdbJump
            // 
            this.rdbJump.AutoSize = true;
            this.rdbJump.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbJump.ForeColor = System.Drawing.SystemColors.Info;
            this.rdbJump.Location = new System.Drawing.Point(199, 227);
            this.rdbJump.Name = "rdbJump";
            this.rdbJump.Size = new System.Drawing.Size(97, 36);
            this.rdbJump.TabIndex = 3;
            this.rdbJump.Text = "Jump";
            this.rdbJump.UseVisualStyleBackColor = true;
            this.rdbJump.Visible = false;
            this.rdbJump.CheckedChanged += new System.EventHandler(this.rdbJump_CheckedChanged);
            // 
            // wnd_MenuGame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(453, 557);
            this.ControlBox = false;
            this.Controls.Add(this.rdbJump);
            this.Controls.Add(this.cmdWindows);
            this.Controls.Add(this.cmdFullscreen);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblMoveChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbMove2);
            this.Controls.Add(this.rdbMove1);
            this.Controls.Add(this.cmd_Cancels);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.cmd_Setting);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cmd_Resume);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wnd_MenuGame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.wnd_MenuGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wnd_MenuGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Resume;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button cmd_Setting;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Button cmd_Cancels;
        private System.Windows.Forms.RadioButton rdbMove1;
        private System.Windows.Forms.RadioButton rdbMove2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoveChoice;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button cmdFullscreen;
        private System.Windows.Forms.Button cmdWindows;
        private System.Windows.Forms.RadioButton rdbJump;
    }
}