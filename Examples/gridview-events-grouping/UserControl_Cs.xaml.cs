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

#region gridview-events-grouping_1

private void clubsGrid_Grouping(object sender, GridViewGroupingEventArgs e)
{
 if (e.Action == GroupingEventAction.Place && e.Index > 0)
 {
  e.Cancel = true;
 }
}
    
#endregion

#region gridview-events-grouping_3

private void clubsGrid_Grouped(object sender, GridViewGroupedEventArgs e)
{
    GridViewDataColumn column = ((Telerik.Windows.Controls.GridView.ColumnGroupDescriptor)(e.GroupDescriptor)).Column as GridViewDataColumn;
    MessageBox.Show("The GridView was grouped by column: "+ column.Header.ToString());
}
#endregion

#region gridview-events-grouping_5
clubsGrid.Grouping += new EventHandler<GridViewGroupingEventArgs>(clubsGrid_Grouping);
clubsGrid.Grouped += new EventHandler<GridViewGroupedEventArgs>(clubsGrid_Grouped);
clubsGrid.GroupRowIsExpandedChanged += new EventHandler<GroupRowEventArgs>(radGridView_GroupRowIsExpandedChanged);
clubsGrid.GroupRowIsExpandedChanging +=new EventHandler<GroupRowCancelEventArgs>(rgv2_GroupRowIsExpandedChanging);
#endregion

#region gridview-events-grouping_7
void clubsGrid_GroupRowIsExpandedChanging(object sender, Telerik.Windows.Controls.GridView.GroupRowCancelEventArgs e)
{
    e.Cancel = true;
}
#endregion

#region gridview-events-grouping_9
void clubsGrid_GroupRowIsExpandedChanged(object sender, Telerik.Windows.Controls.GridView.GroupRowEventArgs e)
{
    GridViewGroupRow expandedGroup = e.Row as GridViewGroupRow;
    if (expandedGroup.IsExpanded)
    {
        expandedGroup.Background = new SolidColorBrush(Colors.Red);
    }
    else
    {
        expandedGroup.Background = new SolidColorBrush(Colors.Green);
    }
}
#endregion

}
