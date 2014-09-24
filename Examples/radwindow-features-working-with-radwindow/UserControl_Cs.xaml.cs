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

#region radwindow-features-working-with-radwindow_0
RadWindow radWindow = new RadWindow();
radWindow.Width = 400;
radWindow.Height = 300;
#endregion

#region radwindow-features-working-with-radwindow_2
radWindow.Show();
#endregion

#region radwindow-features-working-with-radwindow_4
radWindow.ShowDialog();
#endregion

#region radwindow-features-working-with-radwindow_6
Grid grid = new Grid();
grid.Background = new SolidColorBrush( Color.FromArgb( 255, 240, 255, 255 ) );
radWindow.Content = grid;
#endregion

#region radwindow-features-working-with-radwindow_9
radWindow.ContentTemplate = this.Resources[ "WindowContentTemplate" ] as DataTemplate;
#endregion
}
