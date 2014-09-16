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

#region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_1
private void ExpandTreeViewItem()
{
    radTreeViewItem.IsExpanded = true;
}
private void CollapseTreeViewItem()
{
    radTreeViewItem.IsExpanded = false;
}
#endregion

#region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_3
private void ExpandAllTreeViewItems()
{
    radTreeView.ExpandAll();
}
private void CollapseAllTreeViewItems()
{
    radTreeView.CollapseAll();
}
#endregion

#region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_6
radTreeView.IsSingleExpandPath = true;
#endregion

#region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_9
private void ExpandItemByPath()
{
    string path = "Sport Categories|Cycling|Indoor Cycling";
    radTreeView.ExpandItemByPath( path, "|" );
}
#endregion

#region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_11
private void ExpandItemByPath()
{
    string path = "Sport Categories|Cycling|Indoor Cycling";
    radTreeView.PathSeparator = "|";
    radTreeView.ExpandItemByPath( path );
}
#endregion

#region radtreeview-feautres-treeviewitem-expanding-and-collapsing-items_15
private void ExpandOnSingleClick()
{
    radTreeView.IsExpandOnSingleClickEnabled = true;
}
private void ExpandOnDoubleClick()
{
    radTreeView.IsExpandOnDblClickEnabled = true;
}
#endregion
}
