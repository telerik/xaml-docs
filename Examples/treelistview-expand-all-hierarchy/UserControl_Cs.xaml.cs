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

#region treelistview-expand-all-hierarchy_0
treeListView.DataLoaded += new EventHandler<EventArgs>(treeListView_DataLoaded);
#endregion

#region treelistview-expand-all-hierarchy_2
void treeListView_DataLoaded(object sender, EventArgs e)
{
    treeListView.DataLoaded -= treeListView_DataLoaded;
    treeListView.ExpandAllHierarchyItems();   
}
#endregion
}
