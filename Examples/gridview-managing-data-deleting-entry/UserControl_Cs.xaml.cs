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

#region gridview-managing-data-deleting-entry_1
private void Button_Click( object sender, RoutedEventArgs e )
{
}
#endregion

#region gridview-managing-data-deleting-entry_3
foreach ( Employee item in this.radGridView.SelectedItems )
{
    itemsToRemove.Add( item );
}
foreach ( Employee item in itemsToRemove )
{
    ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).Remove( item );
}
#endregion

#region gridview-managing-data-deleting-entry_5
private void Button_Click( object sender, RoutedEventArgs e )
{
    if ( this.radGridView.SelectedItems.Count == 0 )
    {
        return;
    }
    ObservableCollection<Employee> itemsToRemove = new ObservableCollection<Employee>();

    //Remove the items from the RadGridView
    foreach ( var item in this.radGridView.SelectedItems )
    {
        itemsToRemove.Add( item as Employee );
    }
    foreach ( var item in itemsToRemove )
    {
        ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).Remove( item as Employee );
    }
}
#endregion
}
