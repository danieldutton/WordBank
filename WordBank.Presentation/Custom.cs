using System.IO;
using System.Windows.Forms;

namespace WordBank.Presentation
{
    public partial class Custom : Form
    {
        private readonly string _originalText;

        private readonly string _selectedFileName;

        public Custom()
        {
            InitializeComponent();
            Stream myStream = null;

            var openFileDialog1 = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //add using
                var sr = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default);
                
                _selectedFileName = openFileDialog1.FileName;
                
                _rTextBoxXml.Text = sr.ReadToEnd();
                
                _originalText = _rTextBoxXml.Text;
                
                sr.Close();
            }
        }

        private void OnTyping_TextChanged(object sender, System.EventArgs e)
        {
            //const string tokens = @"(<words>|<word>|</word>|</words>)";
            //var rex = new Regex(tokens);
            //MatchCollection mc = rex.Matches(_rTextBoxXml.Text);
            //int StartCursorPosition = _rTextBoxXml.SelectionStart;
            //foreach (Match m in mc)
            //{
            //    int startIndex = m.Index;
            //    int StopIndex = m.Length;
                
            //    _rTextBoxXml.Select(startIndex, StopIndex);
            //    _rTextBoxXml.SelectionColor = Color.Brown;
            //    _rTextBoxXml.SelectionStart = StartCursorPosition;
            //    _rTextBoxXml.SelectionColor = Color.Black;
            //}
        }

        private void CancelCustomise_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void SaveCustomise_Click(object sender, System.EventArgs e)
        {
            string xmlToSave = _rTextBoxXml.Text;

            //validate the xml

            //sort alphabetically

            //save to the correct file path
            File.WriteAllText(_selectedFileName, xmlToSave);
            Dispose();
            
        }

        private void _btnReset_Click(object sender, System.EventArgs e)
        {
            _rTextBoxXml.Clear();
            _rTextBoxXml.Text = _originalText;
        }
    }
}