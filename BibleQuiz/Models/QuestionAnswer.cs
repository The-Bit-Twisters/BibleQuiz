using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace BibleQuiz.Models
{
    internal partial class QuestionAnswer : TableLayoutPanel
    {

        internal QuestionAnswer(string answer, string bible_reference)
        {
            InitializeComponent();
            this.answer = answer;
            this.bible_reference = bible_reference;
            Render();
        }

        private string answer;
        private string bible_reference;

        private void Render()
        {
            SuspendLayout();
            var labelAnswer = new LabelAnswer(answer);
            Controls.Add(labelAnswer, 0, 0);
            if (!string.IsNullOrWhiteSpace(bible_reference))
            {
                var labelBibleReference = new LabelBibleReference(bible_reference);
                Controls.Add(labelBibleReference, 0, 1);
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
