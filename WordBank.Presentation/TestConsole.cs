using System;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Xml.Linq;
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
            _txtBoxAnswer.Clear();
            _txtBoxAnswer.Focus();
        }

        private void OnWordBankEmpty(object sender, WordBankEmptyEventArgs e)
        {
            DisplayTestResults();
        }

        private void DisplayTestResults()
        {
            var resultsForm = new TestResults(_wordBank.WordMap);

            resultsForm.ShowDialog();
        }

        private void UpdateQuestionCountLabels()
        {
            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    _currentWord.Id, _wordBank.WordMap.Count); 
        }

        //dry princp
        private void ResetQuestionCountLables()
        {
            if (_currentWord != null)
                _lblQuestionCount.Text = string.Format("{0} of {1}",
                    1, _wordBank.WordMap.Count);    
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            if (_speechSynthesizer.State != SynthesizerState.Speaking)
            {
                SubmitAnswer();
                GiveFocusToAnswerTextBox();
                PronounceNextWord();
                UpdateQuestionCountLabels(); 
            }
        }

        private void SubmitAnswer()
        {
            string answer = _txtBoxAnswer.Text;

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
                ShowReadOnly = true,
                //InitialDirectory = "SampleTests",
                RestoreDirectory = false
            };
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //read in xmlFile
                try
                {
                    string xml = openFileDialog1.FileName;
                    XDocument doc = XDocument.Load(xml);

                    _wordBank.InitialiseWordBank(doc.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Corrupt word file.  Please try again");
                    return;
                }

                _tabControl.SelectTab(0);
                ResetQuestionCountLables();
                PronounceNextWord();
            }
        }

        private void ResetToDefaultWordXmlFile(object sender, EventArgs e)
        {
            _wordBank.InitialiseWordBank(Repository.Properties.Resources.words_default);

            _tabControl.SelectTab(0);
            ResetQuestionCountLables();
            PronounceNextWord();
        }
    }
}