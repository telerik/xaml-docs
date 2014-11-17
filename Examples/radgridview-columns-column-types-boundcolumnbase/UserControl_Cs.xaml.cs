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

#region radgridview-columns-column-types-boundcolumnbase_0
var visibleColumns = RadGridView1.Columns.OfType<GridViewBoundColumnBase>()
                     .Where(c => c.IsVisible)
                     .OrderBy(c => c.DisplayIndex).ToList();
for (var i = 0; i < RadGridView1.Items.Count; i++)
{
  for (var j = 0; j < visibleColumns.Count; j++)
  {
     var value = visibleColumns[j].GetValueForItem(RadGridView1.Items[i]);
  }
}
#endregion
}
