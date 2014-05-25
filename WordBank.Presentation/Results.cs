using System;
using System.Windows.Forms;
using WordBank.QuestionBank.Interfaces;
using WordBank.Speech.Interfaces;

namespace WordBank.Presentation
{
    public partial class Results : Form
    {
        private readonly ISpellingsAnnouncer _spellingsAnnouncer;
        
        private readonly ISpellingsBank _spellingsBank;


        public Results(ISpellingsAnnouncer spellingsAnnouncer, 
            ISpellingsBank spellingsBank)
        {
            _spellingsAnnouncer = spellingsAnnouncer;
            _spellingsBank = spellingsBank;
        }

        public Results()
        {
            InitializeComponent();
        }

        private void NextSpelling_Click(object sender, EventArgs e)
        {

        }

        private void ReplaySpelling_Click(object sender, EventArgs e)
        {

        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            
        }               
    }
}
