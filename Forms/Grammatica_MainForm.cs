using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grammatica.Forms
{
    public partial class Grammatica_MainForm : Form
    {
        public Grammatica_MainForm()
        {
            InitializeComponent();
        }

        private void Grammatica_MainForm_Load(object sender, EventArgs e)
        {
            ButtonUI(Home_Button, Statistics_Button, Settings_Button, Navigation_Panel);
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Home_Button, Statistics_Button, Settings_Button, Navigation_Panel);
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Statistics_Button, Home_Button, Settings_Button, Navigation_Panel);
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Settings_Button, Home_Button, Statistics_Button, Navigation_Panel);
        }

        private void Exit_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_PictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonUI(Button firstButton, Button secondButton, Button thirdButton, Panel navigationPanel)
        {
            // First Button
            firstButton.BackColor = Color.FromArgb(68, 56, 202);
            firstButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 56, 202);
            firstButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 56, 202);
            firstButton.FlatAppearance.CheckedBackColor = Color.FromArgb(68, 56, 202);
            navigationPanel.Top = firstButton.Top;
            navigationPanel.Height = firstButton.Height;

            // Second Button
            secondButton.BackColor = Color.FromArgb(49, 45, 129);
            secondButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 45, 129);
            secondButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 45, 129);
            secondButton.FlatAppearance.CheckedBackColor = Color.FromArgb(49, 45, 129);

            // Third Button
            thirdButton.BackColor = Color.FromArgb(49, 45, 129);
            thirdButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 45, 129);
            thirdButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 45, 129);
            thirdButton.FlatAppearance.CheckedBackColor = Color.FromArgb(49, 45, 129);
        }
    }
}