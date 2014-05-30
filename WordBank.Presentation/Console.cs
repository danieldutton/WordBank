using System;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Xml.Linq;
using WordBank.Repository;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;
using WordBank.Utility;

namespace WordBank.Presentation
{
    public partial class Console : Form
    {
        [DllImport("winmm.dll", SetLastError = true)]
        public static extern uint waveOutGetNumDevs();

        private readonly IWordBank<WordAnswer> _wordBank;

        private readonly SpeechSynthesizer _speechSynthesizer;

        private WordAnswer _currentWord;


        public Console(IWordBank<WordAnswer> wordBank
            , SpeechSynthesizer speechSynthesizer)
        {
            _wordBank = wordBank;
            _speechSynthesizer = speechSynthesizer;

            InitializeComponent();
            DisableIfNoAudio();
            PronounceNextWord();
            GiveFocusToAnswerTextBox();
            UpdateQuestionCountLabels();
            
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

        private void PronounceNextWord()
        {
            _currentWord = _wordBank.GetWord();

            if (_currentWord == null)
                return;

            _speechSynthesizer.SpeakAsync(_currentWord.Word);
        }

        private void GiveFocusToAnswerTextBox()
        {
            _txtBoxUserAnswer.Clear();
            _txtBoxUserAnswer.Focus();
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

        private void UpdateQuestionCountLabels()
        {
            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    _currentWord.Id, _wordBank.WordMap.Count); 
        }

        private void ResetQuestionCountLables()
        {
            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    0, _wordBank.WordMap.Count);    
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            UpdateAnswer();
            GiveFocusToAnswerTextBox();
            PronounceNextWord();
            UpdateQuestionCountLabels();
        }

        private void UpdateAnswer()
        {
            string answer = _txtBoxUserAnswer.Text;

            if (answer == string.Empty)
                answer = "No Answer Given";

            _currentWord.Answer = answer;

            _wordBank.SubmitAnswer(_currentWord);
        }

        private void ReplayWordAudio_Click(object sender, EventArgs e)
        {
            _speechSynthesizer.SpeakAsync(_currentWord.Word);

            GiveFocusToAnswerTextBox();
        }

        private void EndTestEarly_Click(object sender, EventArgs e)
        {
            DisplayTestResults();
        }

        private void ImportWordFile_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "XML files (*.xml)|*.xml",
            };
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //read in xmlFile
                string xml = openFileDialog1.FileName;
                XDocument doc = XDocument.Load(xml);
                
                //check it's well formed

                //save it to resources                
                _wordBank.InitialiseWordBank(doc.ToString());
                //it is not clearing the first word pronounced
                tabControl1.SelectTab(0);
                ResetQuestionCountLables();
                PronounceNextWord();
            }
        }

        private void ResetToDefaultWordXmlFile(object sender, EventArgs e)
        {
            _wordBank.InitialiseWordBank(
                ResourceLoader.GetRepositoryResourceManager().GetString("words"));

            tabControl1.SelectTab(0);
            ResetQuestionCountLables();
            PronounceNextWord();
        }
    }
}