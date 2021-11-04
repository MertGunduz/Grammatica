using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grammatica.Forms
{
    public partial class Grammatica_MainForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Classes.Database.databaseConnectionString);
        int totalWord;

        public Grammatica_MainForm()
        {
            InitializeComponent();
        }

        private void Grammatica_MainForm_Load(object sender, EventArgs e)
        {
            ButtonUI(Home_Button, Settings_Button, Navigation_Panel);
            UpdateTotalWords();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Home_Button, Settings_Button, Navigation_Panel);
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Settings_Button, Home_Button, Navigation_Panel);
        }

        private void Exit_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_PictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Refresh_PictureBox_Click(object sender, EventArgs e)
        {
            UpdateTotalWords();
        }

        private void ButtonUI(Button firstButton, Button secondButton, Panel navigationPanel)
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
        }

        public void UpdateTotalWords()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand readTotalCommand = new SqlCommand("Select Count(*) From Word_Table", sqlConnection);
                SqlDataReader sqlDataReader = readTotalCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    totalWord = Convert.ToInt32(sqlDataReader[0]);
                }

                TotalWord_Label.Text = "  Total Learned Words: " + totalWord.ToString();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception exception)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

                MessageBox.Show(exception.Message + "\n" + exception.Data.ToString(), "Information - Exception Handled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}