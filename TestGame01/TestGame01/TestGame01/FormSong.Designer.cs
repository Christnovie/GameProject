namespace TestGame01
{
    partial class FormSong
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.lsb_Song = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // cmdFinish
            // 
            this.cmdFinish.BackColor = System.Drawing.Color.ForestGreen;
            this.cmdFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFinish.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdFinish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdFinish.Location = new System.Drawing.Point(58, 266);
            this.cmdFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(130, 33);
            this.cmdFinish.TabIndex = 0;
            this.cmdFinish.Text = "CONFIRM";
            this.cmdFinish.UseVisualStyleBackColor = false;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // lsb_Song
            // 
            this.lsb_Song.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lsb_Song.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsb_Song.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsb_Song.ForeColor = System.Drawing.SystemColors.Window;
            this.lsb_Song.FormattingEnabled = true;
            this.lsb_Song.ItemHeight = 19;
            this.lsb_Song.Location = new System.Drawing.Point(12, 12);
            this.lsb_Song.Name = "lsb_Song";
            this.lsb_Song.Size = new System.Drawing.Size(226, 249);
            this.lsb_Song.TabIndex = 1;
            this.lsb_Song.SelectedIndexChanged += new System.EventHandler(this.lsb_Song_SelectedIndexChanged);
            // 
            // FormSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(253, 324);
            this.ControlBox = false;
            this.Controls.Add(this.lsb_Song);
            this.Controls.Add(this.cmdFinish);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cmdFinish;
        private System.Windows.Forms.ListBox lsb_Song;
    }
}