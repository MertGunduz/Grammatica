using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grammatica.Forms
{
    public partial class Grammatica_AwakeForm : Form
    {
        int awakeTime = 0;

        public Grammatica_AwakeForm()
        {
            InitializeComponent();
        }

        private void Grammatica_AwakeForm_Load(object sender, EventArgs e)
        {
            AwakeMenu_Timer.Start();
        }

        private void AwakeMenu_Timer_Tick(object sender, EventArgs e)
        {
            if (awakeTime != 100)
            {
                awakeTime++;
            }
            else
            {
                AwakeMenu_Timer.Stop();

                Grammatica_MainForm grammatica_MainForm = new Grammatica_MainForm();
                this.Hide();
                grammatica_MainForm.Show();
            }
        }
    }
}
