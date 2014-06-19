using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WordBank.Presentation
{
    public partial class Edit : Form
    {
        private string _originalText;

        private readonly string _selectedFileName;


        public Edit(string fileName)
        {
            _selectedFileName = fileName;
            
            InitializeComponent();
            DisplayXml();                              
        }

        private void DisplayXml()
        {
            using (var sReader = new StreamReader(_selectedFileName, System.Text.Encoding.Default))
            {
                _richTextBoxXml.Text = sReader.ReadToEnd();

                _originalText = _richTextBoxXml.Text;
            };   
        }

        private void CancelEdit_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void SaveEdits_Click(object sender, System.EventArgs e)
        {
            string xmlToSave = _richTextBoxXml.Text;

            //sort alphabetically
            XDocument xDoc = XDocument.Parse(xmlToSave);

            var result = xDoc.Descendants("words").OrderBy(x => x.Name);

            string str = result.ToString(); //extract and unit test

            File.WriteAllText(_selectedFileName, xmlToSave);
            Dispose();
            
        }

        private void Undo_Edits_Click(object sender, System.EventArgs e)
        {
            _richTextBoxXml.Clear();
            _richTextBoxXml.Text = _originalText;
        }
    }
}