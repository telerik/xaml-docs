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

#region radtreeview-how-to-add-context-menu_2
this.radTreeView.AddHandler( RadMenuItem.ClickEvent, new RoutedEventHandler( OnContextMenuClick ) );
#endregion

#region radtreeview-how-to-add-context-menu_4
private void OnContextMenuClick(object sender, RoutedEventArgs args)
{
	// Get the clicked context menu item
	RadMenuItem menuItem = ((RadRoutedEventArgs)args).OriginalSource as RadMenuItem;

	League league = clickedElement.Item as League;
	ItemsControl parentItemsControl = (ItemsControl)clickedElement.ParentItem ?? clickedElement.ParentTreeView;
	string header = menuItem.Header as string;
	switch (header)
	{
		case "New Child":
			league.Divisions.Add(new Division("New Division"));
			break;
		case "New Sibling":
			(parentItemsControl.ItemsSource as ObservableCollection<League>).Add(new League("New League"));
			break;
		case "Delete":
			(parentItemsControl.ItemsSource as ObservableCollection<League>).Remove(league);
			break;
	}
}
#endregion

#region radtreeview-how-to-add-context-menu_6
RadTreeViewItem clickedElement;
private void RadContextMenu_Opened(object sender, RoutedEventArgs e)
{
	// Find the tree item that is associated with the clicked context menu item
	clickedElement = (sender as RadContextMenu).GetClickedElement<RadTreeViewItem>();
}
#endregion
}
