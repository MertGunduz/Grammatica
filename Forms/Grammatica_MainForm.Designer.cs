
namespace Grammatica.Forms
{
    partial class Grammatica_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grammatica_MainForm));
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Statistics_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Main_Panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.Main_Panel.Controls.Add(this.Left_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1000, 600);
            this.Main_Panel.TabIndex = 0;
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
            this.Left_Panel.Controls.Add(this.Settings_Button);
            this.Left_Panel.Controls.Add(this.Statistics_Button);
            this.Left_Panel.Controls.Add(this.Home_Button);
            this.Left_Panel.Controls.Add(this.Header_Panel);
            this.Left_Panel.Controls.Add(this.Logo_Panel);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(200, 600);
            this.Left_Panel.TabIndex = 0;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.pictureBox1);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 125);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(200, 35);
            this.Header_Panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Grammatica.Grammatica_Resources.Grammatica_LittleLogoHeaderIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.Controls.Add(this.Logo_PictureBox);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(200, 125);
            this.Logo_Panel.TabIndex = 0;
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_PictureBox.Image = global::Grammatica.Grammatica_Resources.Grammatica_LogoIcon;
            this.Logo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(200, 125);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Home_Button
            // 
            this.Home_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.Home_Button.Image = global::Grammatica.Grammatica_Resources.Grammatica_HomeIcon;
            this.Home_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_Button.Location = new System.Drawing.Point(0, 160);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Home_Button.Size = new System.Drawing.Size(200, 45);
            this.Home_Button.TabIndex = 2;
            this.Home_Button.Text = "Home";
            this.Home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_Button.UseVisualStyleBackColor = true;
            // 
            // Statistics_Button
            // 
            this.Statistics_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_Button.FlatAppearance.BorderSize = 0;
            this.Statistics_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Statistics_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.Statistics_Button.Image = global::Grammatica.Grammatica_Resources.Grammatica_StatisticsIcon;
            this.Statistics_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Statistics_Button.Location = new System.Drawing.Point(0, 205);
            this.Statistics_Button.Name = "Statistics_Button";
            this.Statistics_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Statistics_Button.Size = new System.Drawing.Size(200, 45);
            this.Statistics_Button.TabIndex = 3;
            this.Statistics_Button.Text = "Statistics";
            this.Statistics_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics_Button.UseVisualStyleBackColor = true;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Settings_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.Settings_Button.Image = global::Grammatica.Grammatica_Resources.Grammatica_SettingsIcon;
            this.Settings_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.Location = new System.Drawing.Point(0, 555);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Settings_Button.Size = new System.Drawing.Size(200, 45);
            this.Settings_Button.TabIndex = 4;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_Button.UseVisualStyleBackColor = true;
            // 
            // Grammatica_MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grammatica_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grammatica";
            this.Main_Panel.ResumeLayout(false);
            this.Left_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel Left_Panel;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button Statistics_Button;
    }
}