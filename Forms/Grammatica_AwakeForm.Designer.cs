
namespace Grammatica.Forms
{
    partial class Grammatica_AwakeForm
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
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.TopBorder_Panel = new System.Windows.Forms.Panel();
            this.BottomBorder_Panel = new System.Windows.Forms.Panel();
            this.RightBorder_Panel = new System.Windows.Forms.Panel();
            this.LeftBorder_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.LeftBorder_Panel);
            this.Main_Panel.Controls.Add(this.RightBorder_Panel);
            this.Main_Panel.Controls.Add(this.BottomBorder_Panel);
            this.Main_Panel.Controls.Add(this.TopBorder_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(400, 400);
            this.Main_Panel.TabIndex = 0;
            // 
            // TopBorder_Panel
            // 
            this.TopBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.TopBorder_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopBorder_Panel.Name = "TopBorder_Panel";
            this.TopBorder_Panel.Size = new System.Drawing.Size(400, 2);
            this.TopBorder_Panel.TabIndex = 0;
            // 
            // BottomBorder_Panel
            // 
            this.BottomBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.BottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder_Panel.Location = new System.Drawing.Point(0, 398);
            this.BottomBorder_Panel.Name = "BottomBorder_Panel";
            this.BottomBorder_Panel.Size = new System.Drawing.Size(400, 2);
            this.BottomBorder_Panel.TabIndex = 1;
            // 
            // RightBorder_Panel
            // 
            this.RightBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.RightBorder_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder_Panel.Location = new System.Drawing.Point(398, 2);
            this.RightBorder_Panel.Name = "RightBorder_Panel";
            this.RightBorder_Panel.Size = new System.Drawing.Size(2, 396);
            this.RightBorder_Panel.TabIndex = 2;
            // 
            // LeftBorder_Panel
            // 
            this.LeftBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(253)))));
            this.LeftBorder_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder_Panel.Location = new System.Drawing.Point(0, 2);
            this.LeftBorder_Panel.Name = "LeftBorder_Panel";
            this.LeftBorder_Panel.Size = new System.Drawing.Size(2, 396);
            this.LeftBorder_Panel.TabIndex = 3;
            // 
            // Grammatica_AwakeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grammatica_AwakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grammatica";
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel LeftBorder_Panel;
        private System.Windows.Forms.Panel RightBorder_Panel;
        private System.Windows.Forms.Panel BottomBorder_Panel;
        private System.Windows.Forms.Panel TopBorder_Panel;
    }
}