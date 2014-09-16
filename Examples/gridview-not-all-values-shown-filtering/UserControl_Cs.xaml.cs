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

#region gridview-not-all-values-shown-filtering_0
public MainPage()
{
    InitializeComponent();
    this.testGrid.ItemsSource = MyData();
    this.testGrid.DistinctValuesLoading += newEventHandler<GridViewDistinctValuesLoadingEventArgs>(testGrid_DistinctValuesLoading);            
}
void testGrid_DistinctValuesLoading(object sender, GridViewDistinctValuesLoadingEventArgs e)
{
    if((string)e.Column.Header == "Int32")
    {
        e.ItemsSource = testGrid.GetDistinctValues(e.Column, true, testGrid.Items.Count);;
    }
}
List<int> MyData()
{
    return Enumerable.Range(0, 2000).ToList();
}
#endregion
}
