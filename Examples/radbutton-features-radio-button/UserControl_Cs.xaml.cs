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

#region radbutton-features-radio-button_1
RadRadioButton radRadioButton = new RadRadioButton(){Content = "Radio Item"};
#endregion

#region radbutton-features-radio-button_4
private void RadRadioButton_Checked( object sender, RoutedEventArgs e )
{
    //implement your logic here
}
#endregion
}
