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

#region radtreeview-feautres-treeviewitem-enable-disable-items_3
private void DisableTreeViewItem()
{
    radTreeViewItemSoccer.IsEnabled = false;
}
#endregion

#region radtreeview-feautres-treeviewitem-enable-disable-items_5
private void DisableTreeView()
{
    radTreeView.IsEnabled = false;
}
#endregion

#region radtreeview-feautres-treeviewitem-enable-disable-items_8
this.radTreeViewItemSoccer.IsEnabledChanged += new DependencyPropertyChangedEventHandler( radTreeViewItemSoccer_IsEnabledChanged );
#endregion
}
