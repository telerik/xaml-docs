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

#region radtreeview-how-to-get-item-by-path_0
private void GetTreeViewItemByPath()
{
    string path = "Sport Categories|Football|Soccer";
    RadTreeViewItem targetItem = radTreeView.GetItemByPath( path, "|" );
}
#endregion

#region radtreeview-how-to-get-item-by-path_2
private void GetTreeViewItemByPath()
{
    string path = "Sport Categories|Football|Soccer";
    radTreeView.PathSeparator = "|";
    RadTreeViewItem targetItem = radTreeView.GetItemByPath( path );
}
#endregion

#region radtreeview-how-to-get-item-by-path_3
private void GetTreeViewItemByPath()
{
    string path = "Sport Categories|Football|Soccer";
    radTreeView.PathSeparator = "|";
    RadTreeViewItem targetItem = radTreeView.GetItemByPath( path );
}
#endregion
}
