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

#region gridview-events-edit_1
this.radGridView.BeginningEdit += new EventHandler<Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs>(radGridView_BeginningEdit);
#endregion

#region gridview-events-edit_3
private void radGridView_BeginningEdit( object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e )
{
    e.Cancel = true;
}
#endregion

#region gridview-events-edit_5
private void radGridView_BeginningEdit( object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e )
{
    if ( e.Cell.Column.UniqueName == "CustomerID" )
    {
        ToolTipService.SetToolTip( e.Cell, "Editing the ID may result in inconsistency in the database" );
    }
}
#endregion

#region gridview-events-edit_7
private void clubsGrid_PreparingCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
{
 if ((string) e.Column.Header == "Name")
 {
  var tb = e.EditingElement as TextBox;
  tb.TextWrapping = TextWrapping.Wrap;
 }
}
#endregion

#region gridview-events-edit_9
private void clubsGrid_PreparedCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
{
 if ((string) e.Column.Header == "Name")
 {
  var tb = e.EditingElement as TextBox;
  //remove the selection of the text
  tb.SelectionLength = 0;
 }
}
#endregion

#region gridview-events-edit_12
this.radGridView.CellEditEnded += new EventHandler<Telerik.Windows.Controls.GridViewCellEditEndedEventArgs>(radGridView_CellEditEnded);
#endregion

#region gridview-events-edit_14
private void radGridView_CellEditEnded( object sender, Telerik.Windows.Controls.GridViewCellEditEndedEventArgs e )
{
    Employee editedEmployee = e.Cell.DataContext as Employee;
    string propertyName = e.Cell.Column.UniqueName;
    MessageBox.Show( string.Format( "Property {0} is edited and newValue is {1}", propertyName, e.NewData ) );
}
#endregion

#region gridview-events-edit_17
this.radGridView.RowEditEnded += new EventHandler<Telerik.Windows.Controls.GridViewRowEditEndedEventArgs>(radGridView_RowEditEnded);
#endregion

#region gridview-events-edit_19
private void radGridView_RowEditEnded( object sender, Telerik.Windows.Controls.GridViewRowEditEndedEventArgs e )
{
    Employee newEmployee = e.NewData as Employee;
    if ( newEmployee != null )
    {
        textBlock1.Text = "e.NewData contains: " + newEmployee;
    }
}
#endregion
}
