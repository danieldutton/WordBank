using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Xml.Linq;
using WordBank.Presentation.ExtMethods;
using WordBank.Repository;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;

namespace WordBank.Presentation
{
    public partial class Main : Form
    {
        [DllImport("winmm.dll", SetLastError = true)]
        public static extern uint waveOutGetNumDevs();

        private readonly IWordBank<Question> _wordBank;

        private readonly SpeechSynthesizer _speechSynthesizer;

        private Question _currentWord;


        public Main(IWordBank<Question> wordBank
            , SpeechSynthesizer speechSynthesizer)
        {
            _wordBank = wordBank;
            _speechSynthesizer = speechSynthesizer;

            InitializeComponent();
            DisableIfNoAudio();
            PronounceWord();
            FocusToAnswerTextBox();
            UpdateQuestionCountLabel();

            _wordBank.IsEmpty += OnWordBankEmpty;
        }

        private void DisableIfNoAudio()
        {
            if (waveOutGetNumDevs() == 0)
            {
                MessageBox.Show(Properties.Resources.NoAudioWarning);
                Enabled = false;
            }
        }

        private void PronounceWord()
        {
            _currentWord = _wordBank.GetQuestion();

            if (_currentWord == null)
                return;

            _speechSynthesizer.SpeakAsync(_currentWord.Word);
        }

        private void FocusToAnswerTextBox()
        {
            _txtBoxAnswer.Clear();
            _txtBoxAnswer.Focus();
        }

        private void UpdateQuestionCountLabel()
        {
            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    _currentWord.Id, _wordBank.WordMap.Count);
        }

        //dry principle violated
        private void ResetQuestionCountLabel()
        {
            const int startCount = 1;

            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    startCount, _wordBank.WordMap.Count);
        }

        private void OnWordBankEmpty(object sender, WordBankEmptyEventArgs e)
        {
            DisplayTestResults();
        }

        private void DisplayTestResults()
        {
            _speechSynthesizer.Dispose();

            List<Question> questions = _wordBank.WordMap.ToQuestionList();

            var resultsForm = new Results(questions);
            resultsForm.ShowDialog();
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            if (_speechSynthesizer.State == SynthesizerState.Speaking)
                return;

            SubmitAnswer();
            FocusToAnswerTextBox();
            PronounceWord();
            UpdateQuestionCountLabel();
        }

        private void SubmitAnswer()
        {
            string answer = _txtBoxAnswer.Text;

            _currentWord.Answer = answer;

            _wordBank.SubmitAnswer(_currentWord);
        }

        private void ReplayWordAudio_Click(object sender, EventArgs e)
        {
            _speechSynthesizer.SpeakAsync(_currentWord.Word);

            FocusToAnswerTextBox();
        }

        private void EndTestEarly_Click(object sender, EventArgs e)
        {
            _speechSynthesizer.Dispose();

            DisplayTestResults();
        }

        private void LoadNewTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = GetOpenFileDialog();

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;

                LoadTestFile(filePath);
            }
        }

        private OpenFileDialog GetOpenFileDialog()
        {
            var fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = Properties.Resources.XmlFileFilter,
                ShowReadOnly = true,
                InitialDirectory = "/TestSamples",
                RestoreDirectory = false
            };
            return fileDialog;
        }

        private void LoadTestFile(string xml)
        {
            try
            {
                XDocument doc = XDocument.Load(xml);

                _wordBank.InitialiseWordBank(doc.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TestLoadFailure);
                return;
            }

            _tabControl.SelectTab(0);

            ResetQuestionCountLabel();
            PronounceWord();
        }

        private void EditTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = GetOpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var custom = new Edit(openFileDialog1.FileName);
                custom.ShowDialog();
            }
        }
    }
}