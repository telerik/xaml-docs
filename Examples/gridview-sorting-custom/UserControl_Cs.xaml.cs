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

#region gridview-sorting-custom_0
public CustomSorting()
{
    InitializeComponent();
    this.radGridView.Sorting += this.radGridView_Sorting;    
}
private void radGridView_Sorting( object sender, GridViewSortingEventArgs e )
{
}
#endregion

#region gridview-sorting-custom_2
private void radGridView_Sorting( object sender, GridViewSortingEventArgs e )
{
    //Gets the value of the ItemsSource property as IEnumerable.
    IEnumerable<Employee> employees = e.DataControl.ItemsSource as IEnumerable<Employee>;
    //Checks if the value of the collection is null.
    if ( employees == null )
    {
        e.Cancel = true;
        return;
    }
}
#endregion

#region gridview-sorting-custom_4
//If the sorting state is none, sort the items ascending.
if ( e.OldSortingState == SortingState.None )
{
    e.NewSortingState = SortingState.Ascending;
}
//If the sorting state is none, sort the items descending.
else if ( e.OldSortingState == SortingState.Ascending )
{
    e.NewSortingState = SortingState.Descending;
}
//If the sorting state is descending, apply default sorting to the items.
else
{
    e.NewSortingState = SortingState.None;
}
#endregion

#region gridview-sorting-custom_6
//Via the SortPropertyName value get 
//the value of the property to sort your data by.
employees = employees.OrderBy( employee => employee.GetType()
                                                   .GetProperty( (e.Column as GridViewDataColumn).GetDataMemberName() )
                                                   .GetValue( employee, null ) );
#endregion

#region gridview-sorting-custom_8
e.DataControl.ItemsSource = employees.ToList();
e.Cancel = true;
#endregion

#region gridview-sorting-custom_10
private void CustomSortingGrid_Sorting( object sender, GridViewSortingEventArgs e )
{
    //Gets the value of the ItemsSource property as IEnumerable.
    IEnumerable<Employee> employees = e.DataControl.ItemsSource as IEnumerable<Employee>;
    //Checks if the value of the collection is null.
    if ( employees == null )
    {
        e.Cancel = true;
        return;
    }
    //If the sorting state is none, sort the items ascending.
    if ( e.OldSortingState == SortingState.None )
    {
        e.NewSortingState = SortingState.Ascending;
        employees = employees.OrderBy( employee => employee.GetType()
                                                           .GetProperty( (e.Column as GridViewDataColumn).GetDataMemberName() )
                                                           .GetValue( employee, null ) );
    }
    //If the sorting state is none, sort the items descending.
    else if ( e.OldSortingState == SortingState.Ascending )
    {
        e.NewSortingState = SortingState.Descending;
        employees = employees.OrderByDescending( employee => employee.GetType()
                                                            .GetProperty( (e.Column as GridViewDataColumn).GetDataMemberName() )
                                                            .GetValue( employee, null ) );
    }
    //If the sorting state is descending, apply default sorting to the items.
    else
    {
        e.NewSortingState = SortingState.None;
        employees = employees.OrderBy( employee => employee.EmployeeID );
    }
    //Set the sorted collection as source of the RadGridView
    e.DataControl.ItemsSource = employees.ToList();
    e.Cancel = true;
}
#endregion
}
