using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordBank.Presentation
{
    public partial class Settings : Form
    {
        private Dictionary<string, string> _questions;

        public Settings()
        {
            InitializeComponent();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SpellingTestStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
