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

#region radwindow-how-to-close-the-radwidnow-through-its-content_2
private void Button_Click( object sender, RoutedEventArgs e )
{
    this.Close();
}
#endregion

#region radwindow-how-to-close-the-radwidnow-through-its-content_4
private void Button_Click( object sender, RoutedEventArgs e )
{
    RadWindow window = this.ParentOfType<RadWindow>();
    window.Close();
}
#endregion
}
