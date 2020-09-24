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
            this.SuspendLayout();
            // 
            // cmd_Resume
            // 
            this.cmd_Resume.BackColor = System.Drawing.Color.Transparent;
            this.cmd_Resume.FlatAppearance.BorderSize = 0;
            this.cmd_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Resume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmd_Resume.ForeColor = System.Drawing.SystemColors.Control;
            this.cmd_Resume.Location = new System.Drawing.Point(165, 138);
            this.cmd_Resume.Name = "cmd_Resume";
            this.cmd_Resume.Size = new System.Drawing.Size(188, 64);
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
            this.lblTitre.Location = new System.Drawing.Point(198, 60);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(122, 48);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "MENU";
            // 
            // wnd_MenuGame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(516, 624);
            this.ControlBox = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Resume;
        private System.Windows.Forms.Label lblTitre;
    }
}