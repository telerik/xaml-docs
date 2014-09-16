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

#region radgridview-selection-programmatic-selection_0
Employee e = this.radGridView.SelectedItem as Employee;
#endregion

#region radgridview-selection-programmatic-selection_2
this.radGridView.SelectedItem = ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).First();
#endregion

#region radgridview-selection-programmatic-selection_4
this.radGridView.CurrentItem = ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).First();
#endregion

#region radgridview-selection-programmatic-selection_6
public void DeselectItem( object itemToDeselect )
{
    this.radGridView.SelectedItems.Remove( itemToDeselect );
}
public void SelectItem( object itemToSelect )
{
    this.radGridView.SelectedItems.Add( itemToSelect );
}
#endregion

#region radgridview-selection-programmatic-selection_8
GridViewCellInfo cellToSelect = new GridViewCellInfo(item, column, this.radGridView);
public void SelectCell(GridViewCellInfo cellToSelect  )
{
    this.radGridView.SelectedCells.Add( cellToSelect );
}
public void DeselectCell(GridViewCellInfo cellToSelect )
{
    this.radGridView.SelectedCells.Remove( cellToSelect  );
}
#endregion

#region radgridview-selection-programmatic-selection_10
this.radGridView.SelectAll();
#endregion

#region radgridview-selection-programmatic-selection_12
this.radGridView.SelectedItem = null;
#endregion

#region radgridview-selection-programmatic-selection_14
this.radGridView.SelectedItems.Clear();
#endregion
}
