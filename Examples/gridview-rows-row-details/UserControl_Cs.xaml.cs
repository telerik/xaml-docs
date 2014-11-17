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

#region gridview-rows-row-details_1
private void radGridView_LoadingRowDetails( object sender, GridViewRowDetailsEventArgs e )
{
    StackPanel element = e.DetailsElement as StackPanel;
    if ( e.Row.IsAlternating )
    {
        element.Background = new SolidColorBrush( Colors.Black );
    }
    else
    {
        element.Background = new SolidColorBrush( Colors.White );
    }
}
#endregion
}
