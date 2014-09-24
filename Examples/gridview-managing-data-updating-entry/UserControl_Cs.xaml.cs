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

#region gridview-managing-data-updating-entry_0
this.radGridView.BeginEdit();
#endregion

#region gridview-managing-data-updating-entry_3
private void Button_Click( object sender, RoutedEventArgs e )
{
    this.radGridView.BeginEdit();
}
#endregion

#region gridview-managing-data-updating-entry_6
private void radGridView_BeginningEdit( object sender, GridViewBeginningEditRoutedEventArgs e )
{
}
#endregion

#region gridview-managing-data-updating-entry_8
private void radGridView_RowEditEnded( object sender, GridViewRowEditEndedEventArgs e )
{
}
#endregion
}
