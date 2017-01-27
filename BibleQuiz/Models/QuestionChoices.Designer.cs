using System.Windows.Forms;
using System.Drawing;

namespace BibleQuiz.Models
{
    partial class QuestionChoices
    {

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Choices
            // 
            AutoSize = true;
            BackColor = Color.Black;
            Dock = DockStyle.Fill;
            GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Margin = new Padding(0);
            ResumeLayout(false);
            PerformLayout();
        }

        /**************************************************
         ********** LABEL LETTER **************************
         **************************************************/

        private class LabelLetter : Label
        {
            internal LabelLetter(string letter, Models.Layout.View screenlayout)
            {
                this.letter = letter;
                this.screenLayout = screenlayout;
                InitializeLayout();
                InitializeComponent();
            }

            //components
            private Models.Layout.View screenLayout;
            private string letter;
            //layouts
            private float fontsize;

            private void InitializeLayout()
            {
                switch (screenLayout)
                {
                    case Models.Layout.View.BigScreen:
                        fontsize = 25F;
                        break;
                    case Models.Layout.View.ControllerEmbed:
                        fontsize = 12F;
                        break;
                }
            }

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.Black;
                Dock = DockStyle.Fill;
                Font = new Font("Impact", fontsize, FontStyle.Regular, GraphicsUnit.Point);
                ForeColor = Color.Gold;
                Text = letter;
                TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        /**************************************************
         ********** LABEL CHOICE **************************
         **************************************************/

        private class LabelChoice : Label
        {
            internal LabelChoice(string choice, Models.Layout.View screenlayout, string choicelayout)
            {
                this.choice = choice;
                this.screenLayout = screenlayout;
                this.choicesLayout = choicelayout;
                InitializeLayout();
                InitializeComponent();
            }

            //components
            private Models.Layout.View screenLayout;
            private string choicesLayout;
            private string choice;
            //layouts
            private float fontsize;
            private int padding;
            private ContentAlignment textalign;

            private void InitializeLayout()
            {
                switch (screenLayout)
                {
                    case Models.Layout.View.BigScreen:
                        padding = 5;
                        if (choicesLayout == Models.Layout.Choices.OneByOne || choicesLayout == Models.Layout.Choices.OneByTwo)
                        {
                            fontsize = 40F;
                            textalign = ContentAlignment.MiddleCenter;
                        }
                        else if (choicesLayout == Models.Layout.Choices.OneByFour || choicesLayout == Models.Layout.Choices.FourByOne || choicesLayout == Models.Layout.Choices.TwoByTwo)
                        {
                            fontsize = 30F;
                            textalign = ContentAlignment.MiddleLeft;
                        }
                        break;
                    case Models.Layout.View.ControllerEmbed:
                        fontsize = 15F;
                        padding = 5;
                        if (choicesLayout == Models.Layout.Choices.OneByOne || choicesLayout == Models.Layout.Choices.OneByTwo)
                        {
                            textalign = ContentAlignment.MiddleCenter;
                        }
                        else if (choicesLayout == Models.Layout.Choices.OneByFour || choicesLayout == Models.Layout.Choices.FourByOne || choicesLayout == Models.Layout.Choices.TwoByTwo)
                        {
                            textalign = ContentAlignment.MiddleLeft;
                        }
                        break;
                }
            }

            private void InitializeComponent()
            {
                AutoSize = true;
                BackColor = Color.White;
                Dock = DockStyle.Fill;
                Font = new Font("Impact", fontsize, FontStyle.Regular, GraphicsUnit.Point);
                ForeColor = Color.Black;
                Padding = new Padding(padding, 0, padding, 0);
                Text = choice;
                TextAlign = textalign;
            }
        }
       
    }
}
