using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WordBank.Repository;

namespace WordBank.Presentation
{
    public partial class Results : Form
    {
        //question might need naming better.  why would a user expect an answer in there
        private readonly IEnumerable<Question> _questions;

        private int _score;

        private int _newLineYPos;


        public Results(IEnumerable<Question> questions)
        {
            _questions = questions;

            InitializeComponent();
            DisplayTestResults();
        }

        private void DisplayTestResults()
        {
            foreach (Question question in _questions)
            {
                DisplayTestWordAndAnswer(question);

                if (question.IsCorrect)
                    MarkCorrectAndUpdateScore();
                else
                    MarkIncorrect();

                MoveToNewLine();
            }
            DisplayFinalScore();
        }

        private void DisplayTestWordAndAnswer(Question question)
        {
            var lblWord = new Label
            {
                Text = question.Word,
                Location = new Point(5, _newLineYPos),
            };

            var lblAnswer = new Label
            {
                Text = question.Answer,
                Location = new Point(170, _newLineYPos),
            };

            _panelResults.Controls.Add(lblWord);
            _panelResults.Controls.Add(lblAnswer);
        }

        private void MarkCorrectAndUpdateScore()
        {
            _score++;

            var label = new Label
            {
                Image = Properties.Resources.greentick,
                Location = new Point(280, _newLineYPos - 5)
            };

            _panelResults.Controls.Add(label);
        }

        private void MarkIncorrect()
        {
            var label = new Label
            {
                Image = Properties.Resources.redCrossIcon,
                Location = new Point(280, _newLineYPos - 5)
            };

            _panelResults.Controls.Add(label);
        }

        private void MoveToNewLine()
        {
            _newLineYPos += 30;
        }

        private void DisplayFinalScore()
        {
            _lblScore.Text = string.Format("You Scored {0} out of {1}",
                _score, _questions.Count());
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