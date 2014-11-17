#region radoutlookbar-events_0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
namespace RadOutlookBarHelpExamples
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void RadOutlookBar1_SelectionChanged(object sender, RoutedEventArgs e)
		{
			RadOutlookBarItem newSelectedItem = (sender as RadOutlookBar).SelectedItem as RadOutlookBarItem;
		}
		private void RadOutlookBar1_DropDownClosed(object sender, DropDownEventArgs e)
		{
			// handle the closing of the dropdown
		}
		private void RadOutlookBar1_DropDownOpened(object sender, DropDownEventArgs e)
		{
			// handle the openning of the dropdown
		}
		private void RadOutlookBar1_ItemPositionChanged(object sender, PositionChangedEventArgs e)
		{
			RadOutlookBarItem itemChangedItsPosition = e.OriginalSource as RadOutlookBarItem;
			OutlookBarItemPosition oldPosition = e.OldPosition;
			OutlookBarItemPosition newPosition = e.NewPosition;
		}
		private void RadOutlookBar1_PreviewSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
		{
			// use the Handled property to prevent the selection           
		}
	}
}
#endregion