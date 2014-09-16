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

#region gridview-managing-data-add-new-entries_0
this.AddingNewRowsGrid.BeginInsert();
#endregion

#region gridview-managing-data-add-new-entries_3
private void Button_Click( object sender, RoutedEventArgs e )
{
    this.radGridView.BeginInsert();
}
#endregion

#region gridview-managing-data-add-new-entries_6
private void radGridView_AddingNewDataItem( object sender, GridViewAddingNewEventArgs e )
{
    e.NewObject = new Employee();
}
#endregion

#region gridview-managing-data-add-new-entries_8
private void radGridView_RowEditEnded( object sender, GridViewRowEditEndedEventArgs e )
{
}
#endregion

#region gridview-managing-data-add-new-entries_10
private void radGridView_RowEditEnded( object sender, GridViewRowEditEndedEventArgs e )
{
    if ( e.EditAction == GridViewEditAction.Cancel )
    {
        return;
    }
    if ( e.EditOperationType == GridViewEditOperationType.Insert )
    {
        //Add the new entry to the data base.
    }
}
#endregion

#region gridview-managing-data-add-new-entries_12
radGridView_AddingNewDataItem(object sender, GridViewAddingNewEventArgs e)
{
    e.Cancel = true;
    var newRow = this.dataSource.DefaultView.AddNew();
    newRow["FirstName"] = "John";
    newRow["LastName"] = "Doe";
    e.NewObject = newRow;
}
#endregion
}
