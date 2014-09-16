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

#region check-box-support_2
private void EnableCheckBoxes()
{
    radTreeView.IsOptionElementsEnabled = true;
}
#endregion

#region check-box-support_5
private void EnableRadioButtons()
{
    radTreeView.IsOptionElementsEnabled = true;
}
#endregion

#region check-box-support_8
radTreeView.IsTriStateMode = true;
#endregion

#region check-box-support_10
private void RadTreeViewItem_Checked(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
 bool isInitiallyChecked = (e as RadTreeViewCheckEventArgs).IsUserInitiated;
}
#endregion

#region check-box-support_13
private void radTreeView_Checked( object sender, RadRoutedEventArgs e )
{
    ( e.Source as RadTreeViewItem ).Foreground = new SolidColorBrush( Colors.Green );
}
#endregion
}
