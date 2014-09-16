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
		#region radpanelbar-changing-colors_1
		RadPanelBar myPanelBar = new RadPanelBar()
		{
			Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xBA, 0xDD, 0x27))
		};
		#endregion

		#region radpanelbar-changing-colors_3
		myPanelBar.Foreground = new SolidColorBrush(Colors.Red);
		#endregion

		#region radpanelbar-changing-colors_6
		myPanelBar.BorderThickness = new Thickness(2);
		myPanelBar.BorderBrush = new SolidColorBrush(Colors.Red);
		#endregion
	}
}
