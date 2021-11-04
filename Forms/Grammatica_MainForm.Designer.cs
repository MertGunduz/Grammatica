
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
            this.UserControl_Panel = new System.Windows.Forms.Panel();
            this.WindowControl_Panel = new System.Windows.Forms.Panel();
            this.TotalWord_Label = new System.Windows.Forms.Label();
            this.MinimizeLogo_Panel = new System.Windows.Forms.Panel();
            this.Minimize_PictureBox = new System.Windows.Forms.PictureBox();
            this.ExitMiddleMargin_Panel = new System.Windows.Forms.Panel();
            this.ExitLogo_Panel = new System.Windows.Forms.Panel();
            this.Exit_PictureBox = new System.Windows.Forms.PictureBox();
            this.ExitRightMargin_Panel = new System.Windows.Forms.Panel();
            this.WindowControlBottomMargin_Panel = new System.Windows.Forms.Panel();
            this.WindowControlTopMargin_Panel = new System.Windows.Forms.Panel();
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Navigation_Panel = new System.Windows.Forms.Panel();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Statistics_Button = new System.Windows.Forms.Button();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Header_PictureBox = new System.Windows.Forms.PictureBox();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.grammatica_HomeUserControl1 = new Grammatica.User_Controls.Grammatica_HomeUserControl();
            this.Main_Panel.SuspendLayout();
            this.UserControl_Panel.SuspendLayout();
            this.WindowControl_Panel.SuspendLayout();
            this.MinimizeLogo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_PictureBox)).BeginInit();
            this.ExitLogo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PictureBox)).BeginInit();
            this.Left_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header_PictureBox)).BeginInit();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.Main_Panel.Controls.Add(this.UserControl_Panel);
            this.Main_Panel.Controls.Add(this.WindowControl_Panel);
            this.Main_Panel.Controls.Add(this.Left_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1000, 600);
            this.Main_Panel.TabIndex = 0;
            // 
            // UserControl_Panel
            // 
            this.UserControl_Panel.Controls.Add(this.grammatica_HomeUserControl1);
            this.UserControl_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_Panel.Location = new System.Drawing.Point(200, 43);
            this.UserControl_Panel.Name = "UserControl_Panel";
            this.UserControl_Panel.Size = new System.Drawing.Size(800, 557);
            this.UserControl_Panel.TabIndex = 2;
            // 
            // WindowControl_Panel
            // 
            this.WindowControl_Panel.Controls.Add(this.TotalWord_Label);
            this.WindowControl_Panel.Controls.Add(this.MinimizeLogo_Panel);
            this.WindowControl_Panel.Controls.Add(this.ExitMiddleMargin_Panel);
            this.WindowControl_Panel.Controls.Add(this.ExitLogo_Panel);
            this.WindowControl_Panel.Controls.Add(this.ExitRightMargin_Panel);
            this.WindowControl_Panel.Controls.Add(this.WindowControlBottomMargin_Panel);
            this.WindowControl_Panel.Controls.Add(this.WindowControlTopMargin_Panel);
            this.WindowControl_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowControl_Panel.Location = new System.Drawing.Point(200, 0);
            this.WindowControl_Panel.Name = "WindowControl_Panel";
            this.WindowControl_Panel.Size = new System.Drawing.Size(800, 43);
            this.WindowControl_Panel.TabIndex = 1;
            // 
            // TotalWord_Label
            // 
            this.TotalWord_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.TotalWord_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalWord_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.TotalWord_Label.Location = new System.Drawing.Point(0, 10);
            this.TotalWord_Label.Name = "TotalWord_Label";
            this.TotalWord_Label.Size = new System.Drawing.Size(453, 23);
            this.TotalWord_Label.TabIndex = 8;
            this.TotalWord_Label.Text = "  Total Learned Words:";
            // 
            // MinimizeLogo_Panel
            // 
            this.MinimizeLogo_Panel.Controls.Add(this.Minimize_PictureBox);
            this.MinimizeLogo_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeLogo_Panel.Location = new System.Drawing.Point(734, 10);
            this.MinimizeLogo_Panel.Name = "MinimizeLogo_Panel";
            this.MinimizeLogo_Panel.Size = new System.Drawing.Size(23, 23);
            this.MinimizeLogo_Panel.TabIndex = 7;
            // 
            // Minimize_PictureBox
            // 
            this.Minimize_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minimize_PictureBox.Image = global::Grammatica.Grammatica_Resources.Grammatica_HorizontalLineIcon;
            this.Minimize_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Minimize_PictureBox.Name = "Minimize_PictureBox";
            this.Minimize_PictureBox.Size = new System.Drawing.Size(23, 23);
            this.Minimize_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimize_PictureBox.TabIndex = 0;
            this.Minimize_PictureBox.TabStop = false;
            this.Minimize_PictureBox.Click += new System.EventHandler(this.Minimize_PictureBox_Click);
            // 
            // ExitMiddleMargin_Panel
            // 
            this.ExitMiddleMargin_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitMiddleMargin_Panel.Location = new System.Drawing.Point(757, 10);
            this.ExitMiddleMargin_Panel.Name = "ExitMiddleMargin_Panel";
            this.ExitMiddleMargin_Panel.Size = new System.Drawing.Size(10, 23);
            this.ExitMiddleMargin_Panel.TabIndex = 6;
            // 
            // ExitLogo_Panel
            // 
            this.ExitLogo_Panel.Controls.Add(this.Exit_PictureBox);
            this.ExitLogo_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitLogo_Panel.Location = new System.Drawing.Point(767, 10);
            this.ExitLogo_Panel.Name = "ExitLogo_Panel";
            this.ExitLogo_Panel.Size = new System.Drawing.Size(23, 23);
            this.ExitLogo_Panel.TabIndex = 5;
            // 
            // Exit_PictureBox
            // 
            this.Exit_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_PictureBox.Image = global::Grammatica.Grammatica_Resources.Grammatica_ExitIcon;
            this.Exit_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Exit_PictureBox.Name = "Exit_PictureBox";
            this.Exit_PictureBox.Size = new System.Drawing.Size(23, 23);
            this.Exit_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Exit_PictureBox.TabIndex = 1;
            this.Exit_PictureBox.TabStop = false;
            this.Exit_PictureBox.Click += new System.EventHandler(this.Exit_PictureBox_Click);
            // 
            // ExitRightMargin_Panel
            // 
            this.ExitRightMargin_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitRightMargin_Panel.Location = new System.Drawing.Point(790, 10);
            this.ExitRightMargin_Panel.Name = "ExitRightMargin_Panel";
            this.ExitRightMargin_Panel.Size = new System.Drawing.Size(10, 23);
            this.ExitRightMargin_Panel.TabIndex = 4;
            // 
            // WindowControlBottomMargin_Panel
            // 
            this.WindowControlBottomMargin_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WindowControlBottomMargin_Panel.Location = new System.Drawing.Point(0, 33);
            this.WindowControlBottomMargin_Panel.Name = "WindowControlBottomMargin_Panel";
            this.WindowControlBottomMargin_Panel.Size = new System.Drawing.Size(800, 10);
            this.WindowControlBottomMargin_Panel.TabIndex = 3;
            // 
            // WindowControlTopMargin_Panel
            // 
            this.WindowControlTopMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowControlTopMargin_Panel.Location = new System.Drawing.Point(0, 0);
            this.WindowControlTopMargin_Panel.Name = "WindowControlTopMargin_Panel";
            this.WindowControlTopMargin_Panel.Size = new System.Drawing.Size(800, 10);
            this.WindowControlTopMargin_Panel.TabIndex = 2;
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
            this.Left_Panel.Controls.Add(this.Navigation_Panel);
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
            // Navigation_Panel
            // 
            this.Navigation_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.Navigation_Panel.Location = new System.Drawing.Point(1, 160);
            this.Navigation_Panel.Name = "Navigation_Panel";
            this.Navigation_Panel.Size = new System.Drawing.Size(2, 45);
            this.Navigation_Panel.TabIndex = 2;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
            this.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
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
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Statistics_Button
            // 
            this.Statistics_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistics_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
            this.Statistics_Button.FlatAppearance.BorderSize = 0;
            this.Statistics_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
            this.Statistics_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(45)))), ((int)(((byte)(129)))));
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
            this.Statistics_Button.Click += new System.EventHandler(this.Statistics_Button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.Home_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
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
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Header_Panel
            // 
            this.Header_Panel.Controls.Add(this.Header_PictureBox);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 125);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(200, 35);
            this.Header_Panel.TabIndex = 1;
            // 
            // Header_PictureBox
            // 
            this.Header_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_PictureBox.Image = global::Grammatica.Grammatica_Resources.Grammatica_LittleLogoHeaderIcon;
            this.Header_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Header_PictureBox.Name = "Header_PictureBox";
            this.Header_PictureBox.Size = new System.Drawing.Size(200, 35);
            this.Header_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Header_PictureBox.TabIndex = 1;
            this.Header_PictureBox.TabStop = false;
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
            // grammatica_HomeUserControl1
            // 
            this.grammatica_HomeUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.grammatica_HomeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grammatica_HomeUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grammatica_HomeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.grammatica_HomeUserControl1.Name = "grammatica_HomeUserControl1";
            this.grammatica_HomeUserControl1.Size = new System.Drawing.Size(800, 557);
            this.grammatica_HomeUserControl1.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.Grammatica_MainForm_Load);
            this.Main_Panel.ResumeLayout(false);
            this.UserControl_Panel.ResumeLayout(false);
            this.WindowControl_Panel.ResumeLayout(false);
            this.MinimizeLogo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_PictureBox)).EndInit();
            this.ExitLogo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PictureBox)).EndInit();
            this.Left_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Header_PictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox Header_PictureBox;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button Statistics_Button;
        private System.Windows.Forms.Panel WindowControl_Panel;
        private System.Windows.Forms.Panel MinimizeLogo_Panel;
        private System.Windows.Forms.Panel ExitMiddleMargin_Panel;
        private System.Windows.Forms.Panel ExitLogo_Panel;
        private System.Windows.Forms.Panel ExitRightMargin_Panel;
        private System.Windows.Forms.Panel WindowControlBottomMargin_Panel;
        private System.Windows.Forms.Panel WindowControlTopMargin_Panel;
        private System.Windows.Forms.PictureBox Minimize_PictureBox;
        private System.Windows.Forms.PictureBox Exit_PictureBox;
        private System.Windows.Forms.Panel Navigation_Panel;
        private System.Windows.Forms.Label TotalWord_Label;
        private System.Windows.Forms.Panel UserControl_Panel;
        private User_Controls.Grammatica_HomeUserControl grammatica_HomeUserControl1;
    }
}