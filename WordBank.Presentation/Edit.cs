using System.IO;
using System.Text;
using System.Windows.Forms;

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
            InitButtonToolTips();
            DisplayXml();                              
        }

        private void InitButtonToolTips()
        {
            var tTipSave = new ToolTip();
            tTipSave.SetToolTip(_btnSave, "Save");

            var tTipUndo = new ToolTip();
            tTipUndo.SetToolTip(_btnUndo, "Undo");

            var tTipCancel = new ToolTip();
            tTipCancel.SetToolTip(_btnCancel, "Cancel");
        }

        private void DisplayXml()
        {
            using (var sReader = new StreamReader(_selectedFileName, Encoding.Default))
            {
                _richTextBoxXml.Text = sReader.ReadToEnd();

                _originalText = _richTextBoxXml.Text;
            };   
        }

        private void Undo_Edit_Click(object sender, System.EventArgs e)
        {
            _richTextBoxXml.Clear();
            _richTextBoxXml.Text = _originalText;
        }

        private void CancelEdit_Click(object sender, System.EventArgs e)
        {
            Dispose(true);
        }

        private void SaveEdit_Click(object sender, System.EventArgs e)
        {
            string xmlToSave = _richTextBoxXml.Text;

            try
            {
                File.WriteAllText(_selectedFileName, xmlToSave);
            }
            catch (IOException)
            {
                MessageBox.Show("There was a problem saving the file.  Please try again");
            }
            Dispose();            
        }        
    }
}