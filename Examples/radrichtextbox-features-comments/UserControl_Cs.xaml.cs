using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using Telerik.Windows.Documents.UI;

namespace Comments
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
            InitializeComponent();
        }

        #region radrichtextbox-features-comments_0
        private void RadRichTexBox_CommentShowing(object sender, CommentShowingEventArgs e)
        {
            if (e.Comment.Author == "Boss")
            {
                e.AppearanceSettings.BorderBrush = new SolidColorBrush(Colors.Red);
                e.AppearanceSettings.BackgroundBrush = new SolidColorBrush(Colors.Orange);
                e.AppearanceSettings.HighlightColor = Colors.Orange;
            }
            else
            {
                e.AppearanceSettings.BorderBrush = new SolidColorBrush(Colors.Green);
                e.AppearanceSettings.BackgroundBrush = new SolidColorBrush(Colors.LightGray);
                e.AppearanceSettings.HighlightColor = Colors.LightGray;
            }
        }
        #endregion
    }
}