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

#region gridview-add-button-column_0
public class MyButtonColumn : GridViewColumn
{
 public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
 {
  RadButton button = cell.Content as RadButton;
  if (button == null)
  {
   button = new RadButton();
   button.Content = "Delete";
   button.Command = RadGridViewCommands.Delete;
  }
  button.CommandParameter = dataItem;
  return button;
 }
}
#endregion

#region gridview-add-button-column_2
private void clubsGrid_DataLoaded(object sender, EventArgs e)
{
 if ( clubsGrid.Columns.Last<GridViewColumn>() is MyButtonColumn )
 {
  return;
 }
 this.clubsGrid.Columns.Add(new MyButtonColumn() 
 { 
  Header = "Delete"
 });
}
#endregion
}
