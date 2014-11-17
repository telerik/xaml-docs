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
		#region radoutlookbar-resizing_0
		private void RadOutlookBar1_ItemPositionChanged(object sender, PositionChangedEventArgs e)
		{
			RadOutlookBarItem outlookBarItem = e.OriginalSource as RadOutlookBarItem;
			OutlookBarItemPosition oldPosition = e.OldPosition;
			OutlookBarItemPosition newPosition = e.NewPosition;
		}
		#endregion
	}
}
