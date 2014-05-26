using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WordBank.Repository;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;

namespace WordBank.Presentation
{
    public partial class Main : Form
    {
        private readonly IWordBank<Word> _wordBank;

        private SpeechSynthesizer _speechSynthesizer;

        private Word _currentWord;

        //whenever any button is clicked, always follow up by giving the text box focus
        // no answer given if either next is clicked and text box empty
        //or text box empty and submit clicked
        public Main(IWordBank<Word> wordBank)
        {
            _wordBank = wordBank;

            InitializeComponent();
            RegisterForWordBankEmptyEvent();
            InitSpeech();
            DisableNavigationButtons();
            VocaliseWord();
            _txtBoxAnswer.Focus();
        }

        private void RegisterForWordBankEmptyEvent()
        {
            _wordBank.IsEmpty += _wordBank_IsEmpty;
        }

        private void InitSpeech()
        {
            _speechSynthesizer = new SpeechSynthesizer
            {
                Volume = 100,
                Rate = -2,
            };    
        }

        void _wordBank_IsEmpty(object sender, EmptyEventArgs e)
        {
            var r = new Results(new Result{WordMap = _wordBank.WordMap});
            r.ShowDialog();
        }

        private void NextWord_Click(object sender, EventArgs e)
        {
            VocaliseWord();   
            _txtBoxAnswer.Clear();
            _txtBoxAnswer.Focus();
        }

        private void VocaliseWord()
        {
            _currentWord = _wordBank.GetWord();

            if (_currentWord == null) return;
            
            _lblWordPrompt.Text = "Question " + _currentWord.Id;
            _txtBoxAnswer.Tag = _currentWord.Id;
            
            _speechSynthesizer.SpeakAsync(_currentWord.Text);
   
            EnableNavigationButtons();
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            string answer = _txtBoxAnswer.Text;

            if (answer == string.Empty) answer = "No Answer Given";

            _currentWord.Answer = answer;
            _wordBank.Update(_currentWord);

            _txtBoxAnswer.Clear();

            VocaliseWord();
            _txtBoxAnswer.Focus();
        }

        private void DisableNavigationButtons()
        {
            _btnReplay.Enabled = false;
            _btnNext.Enabled = false;
        }

        private void EnableNavigationButtons()
        {
            _btnReplay.Enabled = true;
            _btnNext.Enabled = true;
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _btnReplay_Click(object sender, EventArgs e)
        {
            _speechSynthesizer.SpeakAsync(_currentWord.Text);
            _txtBoxAnswer.Focus();
        }
    }
}
