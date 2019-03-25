namespace BibleQuiz.Models
{
    internal abstract class Layout
    {

        internal enum View 
        {
            BigScreen = 1,
            ControllerEmbed = 2
        }

        internal static class Choices
        {
            internal static string OneByOne
            {
                get { return "1x1"; }
            }
            internal static string OneByTwo
            {
                get { return "1x2"; }
            }
            internal static string OneByFour
            {
                get { return "1x4"; }
            }
            internal static string FourByOne
            {
                get { return "4x1"; }
            }
            internal static string TwoByTwo
            {
                get { return "2x2"; }
            }
        }

    }
}
