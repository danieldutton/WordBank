using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WordBank.Repository;

namespace WordBank.Presentation
{
    public partial class Results : Form
    {
        private readonly Result _result;

        public Results(Result result)
        {
            _result = result;

            InitializeComponent();
            PrintResults();
        }

        private void PrintResults()
        {
            int yPos = 0;
            int score = 0;

            foreach (KeyValuePair<string, string> entry in _result.WordMap)
            {
                var lblKey = new Label{Text = entry.Key, Location = new Point(5, yPos),};
                
                var lblValue = new Label{Text = entry.Value, Location = new Point(170, yPos),};

                Label label;

                if (entry.Key.Equals(entry.Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    label = new Label{Image = Properties.Resources.greentick, Location = new Point(280, yPos - 5)};
                    score++;
                }
                else
                {
                    label = new Label{Image = Properties.Resources.redCrossIcon, Location = new Point(280, yPos - 5)};    
                }                

                _panelResults.Controls.Add(label);
                _panelResults.Controls.Add(lblKey);
                _panelResults.Controls.Add(lblValue);
                
                yPos += 30;
            }
            _lblScore.Text = "You scored " + score + " out of " + _result.TotalWordCount;

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void RestartApplication_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
