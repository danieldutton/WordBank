using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WordBank.Repository;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;

namespace WordBank.Presentation
{
    public partial class Console : Form
    {
        private readonly IWordBank<Word> _wordBank;

        private SpeechSynthesizer _speechSynthesizer;

        private Word _currentWord;


        public Console(IWordBank<Word> wordBank)
        {
            _wordBank = wordBank;

            InitializeComponent();
            RegisterForWordBankEmptyEvent();
            InitSpeechSynthesizer();
            DisableNavigationButtons();
            SpeakWord();
            FocusToTextBox();
            DisplayQuestionCount();
        }

        private void RegisterForWordBankEmptyEvent()
        {
            _wordBank.IsEmpty += OnWordBankEmpty;
        }

        private void InitSpeechSynthesizer()
        {
            _speechSynthesizer = new SpeechSynthesizer
            {
                Volume = 100,
                Rate =-2,
            };
        }

        private void DisableNavigationButtons()
        {
            _btnReplay.Enabled = false;
        }

        private void EnableNavigationButtons()
        {
            _btnReplay.Enabled = true;
        }

        void OnWordBankEmpty(object sender, WordBankEmptyEventArgs e)
        {
            var resultsForm = new Results(new Result
            {
                WordMap = _wordBank.WordMap, 
                TotalWordCount = _wordBank.WordMap.Count,
            });
            
            resultsForm.ShowDialog();
        }

        private void SpeakWord()
        {
            _currentWord = _wordBank.GetWord();

            if (_currentWord == null) return;
            
            _txtBoxAnswer.Tag = _currentWord.Id;
            
            _speechSynthesizer.SpeakAsync(_currentWord.Text);
   
            EnableNavigationButtons();
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            string answer = _txtBoxAnswer.Text;

            if (answer == string.Empty) 
                answer = "No Answer Given";

            _currentWord.Answer = answer;
            
            _wordBank.Update(_currentWord);

            FocusToTextBox();            
            SpeakWord(); 
            DisplayQuestionCount();
        }

        private void FocusToTextBox()
        {
            _txtBoxAnswer.Clear();
            _txtBoxAnswer.Focus();
        }

        private void DisplayQuestionCount()
        {
            if(_currentWord != null)
                _lblQuestionCount.Text = _currentWord.Id + " of " + _wordBank.WordMap.Count;
        }
        
        private void ReplayWord_Click(object sender, EventArgs e)
        {
            _speechSynthesizer.SpeakAsync(_currentWord.Text);
            
            _txtBoxAnswer.Focus();
        } 
    }
}
