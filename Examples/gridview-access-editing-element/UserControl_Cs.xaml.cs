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

#region gridview-access-editing-element_0
private void clubsGrid_PreparingCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
{
  if ((string) e.Column.Header == "Name")
  {
    var tb = e.EditingElement as TextBox;
    tb.TextWrapping = TextWrapping.Wrap;
  }
}
#endregion

#region gridview-access-editing-element_2
private void clubsGrid_PreparedCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
{   
   if ((string) e.Column.Header == "Name")
   {
      var tb = e.EditingElement as TextBox;
      tb.SelectionLength = 0;
      tb.SelectionStart = tb.Text.Length;
   }
}
#endregion
}
