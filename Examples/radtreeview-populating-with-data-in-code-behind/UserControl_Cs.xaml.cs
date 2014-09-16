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

#region radtreeview-populating-with-data-in-code-behind_1
private void AddTreeViewItems()
{
    RadTreeViewItem category = new RadTreeViewItem();
    category.Header = "Category1";
    category.Foreground = new SolidColorBrush( Colors.Green );
    radTreeView.Items.Add( category );
    category = new RadTreeViewItem();
    category.Header = "Category2";
    category.Foreground = new SolidColorBrush( Colors.Purple );
    radTreeView.Items.Add( category );
}
#endregion

#region radtreeview-populating-with-data-in-code-behind_3
private void AddTreeViewItems()
{
    RadTreeViewItem category = new RadTreeViewItem();
    category.Header = "Category1";
    category.Foreground = new SolidColorBrush( Colors.Green );
    radTreeView.Items.Add( category );
    // Adding child items
    RadTreeViewItem product = new RadTreeViewItem();
    product.Header = "Product1.1";
    category.Items.Add( product );
    product = new RadTreeViewItem();
    product.Header = "Product1.1";
    category.Items.Add( product );
    category = new RadTreeViewItem();
    category.Header = "Category2";
    category.Foreground = new SolidColorBrush( Colors.Purple );
    radTreeView.Items.Add( category );
    // Adding child items
    product = new RadTreeViewItem();
    product.Header = "Product2.1";
    category.Items.Add( product );
    product = new RadTreeViewItem();
    product.Header = "Product2.2";
    category.Items.Add( product );
}
#endregion

#region radtreeview-populating-with-data-in-code-behind_5
private void RemoveTreeViewItem( RadTreeViewItem itemToRemove )
{
    radTreeView.Items.Remove( itemToRemove );
}
#endregion
}
