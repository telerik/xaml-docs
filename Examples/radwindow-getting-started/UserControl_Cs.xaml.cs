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

#region radwindow-getting-started_0
RadWindow radWindow = new RadWindow();
radWindow.Width = 400;
radWindow.Height = 300;
#endregion

#region radwindow-getting-started_2
radWindow.Show();
#endregion

#region radwindow-getting-started_4
Grid grid = new Grid();
grid.Background = new SolidColorBrush( Color.FromArgb( 255, 240, 255, 255 ) );
radWindow.Content = grid;
#endregion

#region radwindow-getting-started_6
RadWindow.Alert( "Hello!" );
#endregion

#region radwindow-getting-started_8
RadWindow.Confirm( new DialogParameters()
{
    Content = "Are you sure?"
} );
#endregion

#region radwindow-getting-started_10
RadWindow.Prompt( new DialogParameters()
{
    Content = "Enter your name:"
} );
#endregion
}
