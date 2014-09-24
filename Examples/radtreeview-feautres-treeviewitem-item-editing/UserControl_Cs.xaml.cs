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

#region radtreeview-feautres-treeviewitem-item-editing_2
private void EnableTreeViewForEdit()
{
    radTreeView.IsEditable = true;
}
#endregion

#region radtreeview-feautres-treeviewitem-item-editing_4
private void StartEdit()
{
    radTreeViewItemFutsal.IsInEditMode = true;
}
#endregion

#region radtreeview-feautres-treeviewitem-item-editing_6
private void EndEdit()
{
    radTreeViewItemFutsal.IsInEditMode = false;
}
#endregion

#region radtreeview-feautres-treeviewitem-item-editing_8
private void CancelEdit()
{
    radTreeViewItemFutsal.CancelEdit();
}
#endregion

#region radtreeview-feautres-treeviewitem-item-editing_11
private void radTreeView_PreviewEditStarted( object sender, RadRoutedEventArgs e )
{
    RadTreeViewItem targetItem = e.Source as RadTreeViewItem;
}
#endregion

#region radtreeview-feautres-treeviewitem-item-editing_13
private void radTreeView_Edited( object sender, RadTreeViewItemEditedEventArgs e )
{
    ( e.Source as RadTreeViewItem ).Background = new SolidColorBrush( Colors.Red );
}
#endregion
}
