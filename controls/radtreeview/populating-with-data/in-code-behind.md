---
title: In Code-Behind
page_title: In Code-Behind
description: Check our &quot;In Code-Behind&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-in-code-behind
tags: in,code-behind
published: True
position: 3
---

# In Code-Behind

This tutorial will walk you through the common tasks of __adding__ and __removing RadTreeViewItems__ programmatically.  

Here is a snapshot of a regular treeview without treeview items: 

![{{ site.framework_name }} RadTreeView Without Items](images/RadTreeView_PopulatingWithDataCodeBehind___001.PNG)

#### __XAML__

```XAML
	<telerik:RadTreeView x:Name="radTreeView" Background="Bisque" Margin="8"/>
	```

## Adding TreeView Items 

In order to add new treeview items to a treeview control, first you have to create an instance of the __RadTreeViewItem__ class, set its properties like __Header__, __Foreground__, etc., and then add it to the treeview items collection. 

#### __C#__

```C#
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
	```

#### __VB.NET__

```VB.NET
	Private Sub AddTreeViewItems()
	    Dim category As New RadTreeViewItem()
	    category.Header = "Category1"
	    category.Foreground = New SolidColorBrush(Colors.Green)
	
	    radTreeView.Items.Add(category)
	
	    category = New RadTreeViewItem()
	    category.Header = "Category2"
	    category.Foreground = New SolidColorBrush(Colors.Purple)
	
	    radTreeView.Items.Add(category)
	End Sub
	```

In order to create your hierarchical structure deeper, you just need to add __RadTreeViewItem__ child nodes to any of the previously declared items. For example, here is the same __AddTreeViewItems()__ method, but this time a little more extended: 

#### __C#__

```C#
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
	```

#### __VB.NET__

```VB.NET
	Private Sub AddTreeViewItems()
	    Dim category As New RadTreeViewItem()
	    category.Header = "Category1"
	    category.Foreground = New SolidColorBrush(Colors.Green)
	
	    radTreeView.Items.Add(category)
	
	    ' Adding child items '
	    Dim product As New RadTreeViewItem()
	    product.Header = "Product1.1"
	
	    category.Items.Add(product)
	
	    product = New RadTreeViewItem()
	    product.Header = "Product1.1"
	
	    category.Items.Add(product)
	
	    category = New RadTreeViewItem()
	    category.Header = "Category2"
	    category.Foreground = New SolidColorBrush(Colors.Purple)
	
	    radTreeView.Items.Add(category)
	
	    ' Adding child items '
	    product = New RadTreeViewItem()
	    product.Header = "Product2.1"
	
	    category.Items.Add(product)
	
	    product = New RadTreeViewItem()
	    product.Header = "Product2.2"
	
	    category.Items.Add(product)
	End Sub
	```

This will be the result if you execute the __AddTreeViewItems()__ method: 
![{{ site.framework_name }} RadTreeView Populated from Code-Behind](images/RadTreeView_PopulatingWithDataCodeBehind___010.PNG)

>tip Consider declaring treeview items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## Removing TreeView Items 

In order to remove a treeview item you have to remove it from the treeview items collection.

#### __C#__

```C#
	private void RemoveTreeViewItem( RadTreeViewItem itemToRemove )
	{
	    radTreeView.Items.Remove( itemToRemove );
	}
	```

#### __VB.NET__

```VB.NET
	Private Sub RemoveTreeViewItem(ByVal itemToRemove As RadTreeViewItem)
	    radTreeView.Items.Remove(itemToRemove)
	End Sub
	```

## See Also
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})
 * [Populating with Data - Declaratively]({%slug radtreeview-populating-with-data-declaratively%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})
 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to ADO.NET Data Service]({%slug radtreeview-populating-with-data-databinding-to-adonet-service%})