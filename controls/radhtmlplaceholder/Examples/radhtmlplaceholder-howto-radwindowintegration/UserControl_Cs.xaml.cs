#region radhtmlplaceholder-howto-radwindowintegration_1
using System;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace SilverlightApplication18
{
	public partial class MainPage : UserControl
	{
        private RadWindow window;
		public MainPage()
		{
			InitializeComponent();
		}
        private void LoadHtmlPlaceholder(object sender, System.Windows.RoutedEventArgs e)
		{
            this.window = new RadWindow();
            RadHtmlPlaceholder htmlPlaceholder = new RadHtmlPlaceholder();
            Uri uri = new Uri("http://www.bing.com", UriKind.RelativeOrAbsolute);
            htmlPlaceholder.SourceUrl = uri;
            this.window.Content = htmlPlaceholder;
            this.window.Width = 800;
            this.window.Height = 600;
            this.window.Top = 210;
            this.window.Left = 330;
            this.window.Show();
		}
	}
}
#endregion
