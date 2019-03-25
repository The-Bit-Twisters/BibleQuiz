using System.Windows.Forms;
using System.Collections.Generic;
using BibleQuiz.Components;

namespace BibleQuiz.Models
{
    internal partial class PassOrPlayGroups : TableLayoutPanel
    {

        internal PassOrPlayGroups()
        {
            InitializeComponent();
            labelGroups = new List<LabelGroup>();
        }

        private List<LabelGroup> labelGroups;

        internal static void AddGroup(PassOrPlayGroups view, Group group)
        {
            view.SuspendLayout();
            LabelGroup labelGroup = new LabelGroup(group.Name);
            view.labelGroups.Add(labelGroup);
            view.RowCount += 1;
            view.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            view.Controls.Add(labelGroup, 0, view.RowCount - 1);
            view.ResumeLayout(false);
            view.PerformLayout();
        }

        internal static void RemoveGroup(PassOrPlayGroups view, Group group)
        {
            view.SuspendLayout();
            LabelGroup removeLabelGroup = new LabelGroup("");
            foreach (LabelGroup labelGroup in view.labelGroups)
            {
                if (group.Name == labelGroup.Text)
                {
                    view.Controls.Remove(labelGroup);
                    removeLabelGroup = labelGroup;
                    view.RowCount -= 1;
                    break;
                }
            }
            view.labelGroups.Remove(removeLabelGroup);
            view.ResumeLayout(false);
            view.PerformLayout();
        }

    }
}
