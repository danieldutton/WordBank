﻿using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;
using WordBank.Repository.Model;

namespace WordBank.Presentation
{
    public partial class Console : Form
    {
        private readonly IWordBank<WordAnswer> _wordBank;

        private readonly SpeechSynthesizer _speechSynthesizer;

        private WordAnswer _currentWordAnswer;


        public Console(IWordBank<WordAnswer> wordBank
            , SpeechSynthesizer speechSynthesizer)
        {
            _wordBank = wordBank;
            _speechSynthesizer = speechSynthesizer;

            InitializeComponent();
            RegisterForWordBankEmptyEvent();
            PronounceCurrentWord();
            GiveFocusToAnswerTextBox();
            DisplayQuestionCount();
        }

        private void RegisterForWordBankEmptyEvent()
        {
            _wordBank.IsEmpty += OnWordBankEmpty;
        }

        private void PronounceCurrentWord()
        {
            _currentWordAnswer = _wordBank.GetWord();

            if (_currentWordAnswer == null)
                return;

            _txtBoxAnswer.Tag = _currentWordAnswer.Id;

            _speechSynthesizer.SpeakAsync(_currentWordAnswer.Text);
        }

        private void GiveFocusToAnswerTextBox()
        {
            _txtBoxAnswer.Clear();
            _txtBoxAnswer.Focus();
        }

        private void OnWordBankEmpty(object sender, WordBankEmptyEventArgs e)
        {
            DisplayTestResults();
        }

        private void DisplayTestResults()
        {
            var resultsForm = new Results(_wordBank.WordMap);

            resultsForm.ShowDialog();
        }

        private void DisplayQuestionCount()
        {
            if (_currentWordAnswer != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    _currentWordAnswer.Id, _wordBank.WordMap.Count); 
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            UpdateAnswer();
            GiveFocusToAnswerTextBox();
            PronounceCurrentWord();
            DisplayQuestionCount();
        }

        private void UpdateAnswer()
        {
            string answer = _txtBoxAnswer.Text;

            if (answer == string.Empty)
                answer = "No Answer Given";

            _currentWordAnswer.Answer = answer;

            _wordBank.SubmitAnswer(_currentWordAnswer);
        }

        private void ReplayWord_Click(object sender, EventArgs e)
        {
            _speechSynthesizer.SpeakAsync(_currentWordAnswer.Text);

            _txtBoxAnswer.Focus();
        }

        private void EndTestEarly_Click(object sender, EventArgs e)
        {
            DisplayTestResults();
        }
    }
}