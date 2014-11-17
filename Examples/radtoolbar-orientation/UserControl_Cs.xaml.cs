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

		
		#region radtoolbar-orientation_0
		using Telerik.Windows.Controls;

		private void ToggleOrientation_Click(object sender, RoutedEventArgs e)
		{
			if (this.myToolbarTray.Orientation == Orientation.Horizontal)
			{
				this.myToolbarTray.Orientation = Orientation.Vertical;
				this.myToolbarTray.VerticalAlignment = VerticalAlignment.Stretch;
				this.myToolbarTray.HorizontalAlignment = HorizontalAlignment.Left;
				this.myToolbar.Orientation = Orientation.Vertical;
				this.myToolbar.VerticalAlignment = VerticalAlignment.Stretch;
				this.myToolbar.HorizontalAlignment = HorizontalAlignment.Left;
			}
			else
			{
				this.myToolbarTray.Orientation = Orientation.Horizontal;
				this.myToolbarTray.VerticalAlignment = VerticalAlignment.Top;
				this.myToolbarTray.HorizontalAlignment = HorizontalAlignment.Stretch;
				this.myToolbar.Orientation = Orientation.Horizontal;
				this.myToolbar.VerticalAlignment = VerticalAlignment.Top;
				this.myToolbar.HorizontalAlignment = HorizontalAlignment.Stretch;
			}
		}
		#endregion
	}
}
