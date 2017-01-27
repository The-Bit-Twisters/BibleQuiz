using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using BibleQuiz.Components;

namespace BibleQuiz.Models
{
    internal partial class QuestionChoices : TableLayoutPanel
    {
        internal QuestionChoices(Question question, Models.Layout.View layout)
        {
            this.layout = layout;
            this.question = question;
            InitializeComponent();
            InitializeLayout();
            Render();
        }

        //components
        private Models.Layout.View layout;
        private Question question;
        private List<LabelLetter> labelLetters;
        private List<LabelChoice> labelChoices;
        //layout
        private int individualMargin;

        internal void RevealAnswer()
        {
            if (question.Choices.Count > 0)
            {
                foreach (Choice choice in question.Choices)
                {
                    foreach (LabelChoice labelChoice in labelChoices)
                    {
                        if (choice.Answer && choice.Value == labelChoice.Text)
                        {
                            labelChoice.BackColor = Color.Lime;
                            return;
                        }
                    }
                }
                labelChoices[0].Text = question.Choices[0].Value;
                labelChoices[0].BackColor = Color.Lime;
            }
        }

        private void InitializeLayout()
        {
            switch (layout) 
            {
                case Models.Layout.View.BigScreen:
                    Margin = new Padding(15, 0, 15, 15);
                    individualMargin = 10;
                    break;
                case Models.Layout.View.ControllerEmbed:
                    Margin = new Padding(0);
                    individualMargin = 5;
                    break;
            }
        }

        private void Render()
        {
            SuspendLayout();
            labelLetters = new List<LabelLetter>();
            labelChoices = new List<LabelChoice>();
            if (question.ChoicesLayout == Models.Layout.Choices.OneByOne)
            {
                ColumnCount += 1;
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                RowCount += 1;
                RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                LabelChoice labelChoice = new LabelChoice("", layout, question.ChoicesLayout);
                labelChoices.Add(labelChoice);
                Controls.Add(labelChoice, 0, 0);
                // margins
                labelChoices[0].Margin = new Padding(individualMargin);
            }
            else if (question.ChoicesLayout == Models.Layout.Choices.OneByTwo)
            {
                RowCount = 1;
                RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                foreach (Choice choice in question.Choices)
                {
                    ColumnCount += 1;
                    ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    LabelChoice labelChoice = new LabelChoice(choice.Value, layout, question.ChoicesLayout);
                    labelChoices.Add(labelChoice);
                    Controls.Add(labelChoice, ColumnCount - 1, 0);
                }
                // margins
                labelChoices[0].Margin = new Padding(individualMargin, individualMargin, individualMargin / 2, individualMargin);
                labelChoices[1].Margin = new Padding(individualMargin / 2, individualMargin, individualMargin, individualMargin);
            }
            else if (question.ChoicesLayout == Models.Layout.Choices.OneByFour)
            {
                RowCount = 1;
                RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                int ctr = 0;
                foreach (Choice choice in question.Choices)
                {
                    ctr++;
                    ColumnCount += 2;
                    ColumnStyles.Add(new ColumnStyle());
                    ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                    string letter = "";
                    switch (ctr) 
                    {
                        case 1:
                            letter = "A";
                            break;
                        case 2:
                            letter = "B";
                            break;
                        case 3:
                            letter = "C";
                            break;
                        case 4:
                            letter = "D";
                            break;
                    }
                    LabelLetter labelLetter = new LabelLetter(letter, layout);
                    labelLetters.Add(labelLetter);
                    Controls.Add(labelLetter, ColumnCount - 2, 0);
                    LabelChoice labelChoice = new LabelChoice(choice.Value, layout, question.ChoicesLayout);
                    labelChoices.Add(labelChoice);
                    Controls.Add(labelChoice, ColumnCount - 1, 0);
                }
                // margins
                labelLetters[0].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin);
                labelLetters[1].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin);
                labelLetters[2].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin);
                labelLetters[3].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin);
                labelChoices[0].Margin = new Padding(0, individualMargin, 0, individualMargin);
                labelChoices[1].Margin = new Padding(0, individualMargin, 0, individualMargin);
                labelChoices[2].Margin = new Padding(0, individualMargin, 0, individualMargin);
                labelChoices[3].Margin = new Padding(0, individualMargin, individualMargin, individualMargin);
            }
            else if (question.ChoicesLayout == Models.Layout.Choices.FourByOne)
            {
                ColumnCount = 2;
                ColumnStyles.Add(new ColumnStyle());
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                int ctr = 0;
                foreach (Choice choice in question.Choices)
                {
                    ctr++;
                    RowCount += 1;
                    RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                    string letter = "";
                    switch (ctr)
                    {
                        case 1:
                            letter = "A";
                            break;
                        case 2:
                            letter = "B";
                            break;
                        case 3:
                            letter = "C";
                            break;
                        case 4:
                            letter = "D";
                            break;
                    }
                    LabelLetter labelLetter = new LabelLetter(letter, layout);
                    labelLetters.Add(labelLetter);
                    Controls.Add(labelLetter, 0, RowCount - 1);
                    LabelChoice labelChoice = new LabelChoice(choice.Value, layout, question.ChoicesLayout);
                    labelChoices.Add(labelChoice);
                    Controls.Add(labelChoice, 1, RowCount - 1);
                }
                // margins
                labelLetters[0].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin / 2);
                labelLetters[1].Margin = new Padding(individualMargin, individualMargin / 2, 0, individualMargin / 2);
                labelLetters[2].Margin = new Padding(individualMargin, individualMargin / 2, 0, individualMargin / 2);
                labelLetters[3].Margin = new Padding(individualMargin, individualMargin / 2, 0, individualMargin);
                labelChoices[0].Margin = new Padding(0, individualMargin, individualMargin, individualMargin / 2);
                labelChoices[1].Margin = new Padding(0, individualMargin / 2, individualMargin, individualMargin / 2);
                labelChoices[2].Margin = new Padding(0, individualMargin / 2, individualMargin, individualMargin / 2);
                labelChoices[3].Margin = new Padding(0, individualMargin / 2, individualMargin, individualMargin);
            }
            else if (question.ChoicesLayout == Models.Layout.Choices.TwoByTwo)
            {
                ColumnCount = 4;
                ColumnStyles.Add(new ColumnStyle());
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                ColumnStyles.Add(new ColumnStyle());
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                RowCount = 2;
                RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                int ctr = 0;
                foreach (Choice choice in question.Choices)
                {
                    ctr++;
                    string letter = "";
                    switch (ctr)
                    {
                        case 1:
                            letter = "A";
                            break;
                        case 2:
                            letter = "B";
                            break;
                        case 3:
                            letter = "C";
                            break;
                        case 4:
                            letter = "D";
                            break;
                    }
                    LabelLetter labelLetter = new LabelLetter(letter, layout);
                    labelLetters.Add(labelLetter);
                    LabelChoice labelChoice = new LabelChoice(choice.Value, layout, question.ChoicesLayout);
                    labelChoices.Add(labelChoice);
                }
                Controls.Add(labelLetters[0], 0, 0);
                Controls.Add(labelLetters[1], 0, 1);
                Controls.Add(labelLetters[2], 2, 0);
                Controls.Add(labelLetters[3], 2, 1);
                Controls.Add(labelChoices[0], 1, 0);
                Controls.Add(labelChoices[1], 1, 1);
                Controls.Add(labelChoices[2], 3, 0);
                Controls.Add(labelChoices[3], 3, 1);
                // margins
                labelLetters[0].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin / 2);
                labelLetters[1].Margin = new Padding(individualMargin, individualMargin / 2, 0, individualMargin);
                labelLetters[2].Margin = new Padding(individualMargin, individualMargin, 0, individualMargin / 2);
                labelLetters[3].Margin = new Padding(individualMargin, individualMargin / 2, 0, individualMargin);
                labelChoices[0].Margin = new Padding(0, individualMargin, 0, individualMargin / 2);
                labelChoices[1].Margin = new Padding(0, individualMargin / 2, 0, individualMargin);
                labelChoices[2].Margin = new Padding(0, individualMargin, individualMargin, individualMargin / 2);
                labelChoices[3].Margin = new Padding(0, individualMargin / 2, individualMargin, individualMargin);
            }
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
