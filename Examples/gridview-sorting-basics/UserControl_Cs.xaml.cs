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

#region gridview-sorting-basics_3
private void radGridView_Sorting( object sender, GridViewSortingEventArgs e )
{
    e.Cancel = true;
}
#endregion

#region gridview-sorting-basics_5
private GridViewColumn previousColumn;
private void radGridView_Sorted( object sender, GridViewSortedEventArgs e )
{
    if ( this.previousColumn != null )
    {
         this.previousColumn.Background = new SolidColorBrush( Colors.Transparent );
    }
    e.Column.Background = new SolidColorBrush( Colors.Green );
    this.previousColumn = e.Column;
}
#endregion
}
