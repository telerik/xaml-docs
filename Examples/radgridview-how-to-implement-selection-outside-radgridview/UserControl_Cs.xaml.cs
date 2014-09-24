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

#region radgridview-how-to-implement-selection-outside-radgridview_1
ObservableCollection<Employee> source = RadGridViewSampleData.GetEmployees();
this.radGridView.ItemsSource = source;
this.listBox.ItemsSource = source;
#endregion

#region radgridview-how-to-implement-selection-outside-radgridview_5
private void listBox_SelectionChanged( object sender, SelectionChangedEventArgs e )
{
}
#endregion

#region radgridview-how-to-implement-selection-outside-radgridview_7
private void listBox_SelectionChanged( object sender, SelectionChangedEventArgs e )
{
    foreach ( var item in e.AddedItems )
    {
        this.radGridView.SelectedItems.Add( item );
    }
    foreach ( var item in e.RemovedItems )
    {
        this.radGridView.SelectedItems.Remove( item );
    }
}
#endregion
}
