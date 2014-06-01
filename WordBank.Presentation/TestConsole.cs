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
    public partial class TestConsole : Form
    {
        [DllImport("winmm.dll", SetLastError = true)]
        public static extern uint waveOutGetNumDevs();

        private readonly IWordBank<Question> _wordBank;

        private readonly SpeechSynthesizer _speechSynthesizer;

        private Question _currentWord;


        public TestConsole(IWordBank<Question> wordBank
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
            _currentWord = _wordBank.GetWord();

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

        //dry principleviolated
        private void ResetQuestionCountLabel()
        {
            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    1, _wordBank.WordMap.Count);
        }

        private void OnWordBankEmpty(object sender, WordBankEmptyEventArgs e)
        {
            DisplayTestResults();
        }

        private void DisplayTestResults()
        {
            List<Question> questions = _wordBank.WordMap.ToQuestionList();

            var resultsForm = new TestResults(questions);

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
            DisplayTestResults();
        }

        private void ImportWordFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = GetOpenFileDialog();
            
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                ImportFile(filePath);
            }                
        }

        private OpenFileDialog GetOpenFileDialog()
        {
            var fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = Properties.Resources.XmlFileFilter,
                ShowReadOnly = true,
                InitialDirectory = "TestSamples",
            };
            return fileDialog;
        }

        private void ImportFile(string xml)
        {
            try
            {
                XDocument doc = XDocument.Load(xml);

                _wordBank.InitialiseWordBank(doc.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Corrupt word file.  Please try again");
                return;
            }

            _tabControl.SelectTab(0);

            ResetQuestionCountLabel();
            PronounceWord();
        }

        private void ResetToDefaultWordXmlFile(object sender, EventArgs e)
        {
            _wordBank.InitialiseWordBank(Repository.Properties.Resources.words_default);
            
            ResetQuestionCountLabel();
            PronounceWord();
            _tabControl.SelectTab(0);
        }
    }
}