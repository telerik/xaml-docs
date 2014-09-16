using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}
	#region radbook-events_1
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void RadBook_FoldActivated(object sender, Telerik.Windows.Controls.FoldEventArgs e)
		{
			FoldPosition position = e.Position;
		}
		private void RadBook1_FoldDeactivated(object sender, Telerik.Windows.Controls.FoldEventArgs e)
		{

		}
		private void RadBook1_PageChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
		{
			int currentPage = RadBook1.RightPageIndex;
		}
		private void RadBook1_PageFlipEnded(object sender, Telerik.Windows.Controls.PageFlipEventArgs e)
		{
			RadBookItem flippedPage = e.Page;
		}
		private void RadBook1_PageFlipStarted(object sender, Telerik.Windows.Controls.PageFlipEventArgs e)
		{
			RadBookItem flippedPage = e.Page;
		}
		private void RadBook1_PreviewPageFlipStarted(object sender, Telerik.Windows.Controls.PageFlipEventArgs e)
		{
			RadBookItem flippedPage = e.Page;
			e.Handled = true;//if the page flip should stop
		}
	}
	#endregion
}
