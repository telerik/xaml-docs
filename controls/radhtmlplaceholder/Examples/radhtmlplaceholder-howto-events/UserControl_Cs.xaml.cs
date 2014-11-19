#region radhtmlplaceholder-howto-events_1
using System;
using System.Windows;
using System.Windows.Controls;
namespace RadHtmlPlaceholderDemo
{
	public partial class Page : UserControl
	{
		public Page()
		{
			InitializeComponent();
		}
		private void RadHtmlPlaceholder_UrlLoaded(object sender, EventArgs e)
		{
			string message = string.Format("{0} has been loaded!", RadHtmlPlaceholder1.SourceUrl);
			MessageBox.Show(message);
		}
	}
}
#endregion