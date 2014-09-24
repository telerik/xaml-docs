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

#region radbuttons-features-button_1
RadButton radButton = new RadButton(){Content = "Click Me!"};
#endregion

#region radbuttons-features-button_4
private void RadButton_Click( object sender, RoutedEventArgs e )
{
    //implement your logic here
}
#endregion
}
