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

#region radtabcontrol-features-selection_1
private void radTabControl_SelectionChanged( System.Object sender, System.Windows.RoutedEventArgs e )
{
    RadSelectionChangedEventArgs selectionArgs = ( RadSelectionChangedEventArgs )e;
    MessageBox.Show( “The selected tab item is ” + ( ( RadTabItem )selectionArgs.AddedItems[ 0 ] ).Header.ToString() );
}
#endregion
}
