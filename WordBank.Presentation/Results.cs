using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WordBank.Presentation
{
    public partial class Results : Form
    {
        private readonly Dictionary<string, string> _wordMap; 

        private int _score;

        private int _newLineYPos;


        public Results(Dictionary<string, string> wordMap)
        {
            _wordMap = wordMap;

            InitializeComponent();
            PrintResults();
        }

        private void PrintResults()
        {
            foreach (KeyValuePair<string, string> entry in _wordMap)
            {
                DisplayTestWordsAndAnswer(entry);

                if (AnswerCorrect(entry))
                    MarkAsCorrect();
                else
                    MarkAsIncorrect();

                    MoveToNextLine();                
            }
            DisplayFinalScore();
        }

        private void DisplayTestWordsAndAnswer(KeyValuePair<string, string> entry)
        {
            var lblWord = new Label
            {
                Text = entry.Key,
                Location = new Point(5, _newLineYPos),
            };

            var lblAnswer = new Label
            {
                Text = entry.Value,
                Location = new Point(170, _newLineYPos),
            };

            _panelResults.Controls.Add(lblWord);
            _panelResults.Controls.Add(lblAnswer);
        }

        private bool AnswerCorrect(KeyValuePair<string, string> entry)
        {
            return entry.Key.Equals(entry.Value, 
                StringComparison.InvariantCultureIgnoreCase);
        }

        private void MarkAsCorrect()
        {
            _score++;

            var label = new Label
            {
                Image = Properties.Resources.greentick,
                Location = new Point(280, _newLineYPos - 5)
            };

            _panelResults.Controls.Add(label);
        }

        private void MarkAsIncorrect()
        {
            var label = new Label
            {
                Image = Properties.Resources.redCrossIcon,
                Location = new Point(280, _newLineYPos - 5)
            };

            _panelResults.Controls.Add(label);
        }

        private void MoveToNextLine()
        {
            _newLineYPos += 30;    
        }

        private void DisplayFinalScore()
        {
            _lblScore.Text = string.Format("You Scored {0} out of {1}",
                _score, _wordMap.Count);
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