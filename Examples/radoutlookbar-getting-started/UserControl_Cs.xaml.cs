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
		#region radoutlookbar-getting-started_1
		private void RadOutlookBar1_SelectionChanged(object sender, RoutedEventArgs e)
		{
			RadOutlookBarItem newSelectedItem = (sender as RadOutlookBar).SelectedItem as RadOutlookBarItem;
		}
		#endregion
	}
}
