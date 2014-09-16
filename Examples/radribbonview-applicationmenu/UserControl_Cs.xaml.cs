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

#region radribbonview-applicationmenu_1
this.radRibbonView.ApplicationMenu = new ApplicationMenu();
#endregion

#region radribbonview-applicationmenu_7
ribbonView.ApplicationButtonVisibility = Visibility.Collapsed;
#endregion

#region radribbonview-applicationmenu_10
private void RadRibbonView_ApplicationButtonDoubleClick(object sender, RadRoutedEventArgs e)
{
 RadRibbonView ribbonView = sender as RadRibbonView;
 // Do some custom logic here.
}
#endregion
}
