using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WordBank.Repository;

namespace WordBank.Presentation
{
    public partial class Results : Form
    {
        private readonly Result _result;

        public Results(Result result)
        {
            _result = result;

            InitializeComponent();
            PrintResults();
        }

        private void PrintResults()
        {
            int yPos = 0;
            int score = 0;

            foreach (KeyValuePair<string, string> entry in _result.WordMap)
            {
                var lblKey = new Label
                {
                    Text = entry.Key, 
                    Location = new Point(0, yPos)
                };
                
                var lblValue = new Label
                {
                    Text = entry.Value, 
                    Location = new Point(170, yPos)
                };

                Label label;

                if (entry.Key.Equals(entry.Value, StringComparison.InvariantCultureIgnoreCase))
                {
                    label = new Label {Text = "Correct", Location = new Point(320, yPos)};
                    score++;
                }
                else
                {
                    label = new Label { Text = "Wrong", Location = new Point(320, yPos) };    
                }                

                _panelResults.Controls.Add(label);
                _panelResults.Controls.Add(lblKey);
                _panelResults.Controls.Add(lblValue);
                

                yPos += 30;
            }
            var lblSummary = new Label { Text = "You scored " + score + "out of " + _result.WordMap.Count, Location = new Point(5, yPos) };

            _panelResults.Controls.Add(lblSummary);
        }
    }
}
