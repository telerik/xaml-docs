---
title: Declaratively
page_title: Declaratively
description: Check our &quot;Declaratively&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-declaratively
tags: declaratively
published: True
position: 2
---

# Declaratively

This tutorial will walk you through the common task of populating __RadTreeView__ with __RadTreeViewItems__ declaratively.  

Here is a regular treeview declaration without items: 

#### __XAML__

```XAML
	<telerik:RadTreeView x:Name="radTreeView" Background="Bisque" Margin="8">
	</telerik:RadTreeView>
	```

In order to add treeview items you need to use the __Items__ property. The __Items__ property is an __ItemCollection__ which contains your treeview items. For example, insert the following lines to the declaration of your treeview and new items will be added to the treeview. 

#### __XAML__

```XAML
	<telerik:RadTreeView x:Name="radTreeView" Background="Bisque" Margin="8">
	    <telerik:RadTreeView.Items>
	        <telerik:RadTreeViewItem Header="Category1"/>
	        <telerik:RadTreeViewItem Header="Category2"/>
	        <telerik:RadTreeViewItem Header="Category3"/>
	        <telerik:RadTreeViewItem Header="Category4"/>
	        <telerik:RadTreeViewItem Header="Category5"/>
	    </telerik:RadTreeView.Items>
	</telerik:RadTreeView>
	```

Here is the result: 
![{{ site.framework_name }} RadTreeView Declarative Binding Top Level](images/RadTreeView_PopulatingWithDataDeclaratively_010.PNG)

>Consider adding __RadTreeViewItems__ directly, without specifying __<telerik:RadTreeView.Items>__
explicitly. The effect will be the same, but your XAML will be more readable:
`<telerik:RadTreeView x:Name="radTreeView" Background="Bisque" Margin="8">
    <telerik:RadTreeViewItem Header="Category1"/>
    <telerik:RadTreeViewItem Header="Category2"/>
    <telerik:RadTreeViewItem Header="Category3"/>
    <telerik:RadTreeViewItem Header="Category4"/>
    <telerik:RadTreeViewItem Header="Category5"/>
</telerik:RadTreeView>`

Each one of the __RadTreeViewItem__ nodes `<telerik:RadTreeViewItem Header="Category1"/>` in the example above represents declaration of a single treeview item that will be created and added to your treeview control at run-time. Just insert or delete __RadTreeViewItem__ child nodes to/from your treeview declaration and see how the treeview structure changes.

In order to create your hierarchical structure deeper, you just need to add __RadTreeViewItem__ child nodes to any of the previously declared items. For example: 

#### __XAML__

```XAML
	<telerik:RadTreeView x:Name="radTreeView" Background="Bisque" Margin="8">
	    <telerik:RadTreeViewItem Header="Category1">
	        <telerik:RadTreeViewItem Header="Product1"/>
	        <telerik:RadTreeViewItem Header="Product2"/>
	        <telerik:RadTreeViewItem Header="Product3"/>
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Category2"/>
	    <telerik:RadTreeViewItem Header="Category3"/>
	    <telerik:RadTreeViewItem Header="Category4">
	        <telerik:RadTreeViewItem Header="Product A"/>
	        <telerik:RadTreeViewItem Header="Product B"/>
	        <telerik:RadTreeViewItem Header="Product C"/>
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Category5"/>
	</telerik:RadTreeView>
	```

![{{ site.framework_name }} RadTreeView Declarative Binding Sub Levels](images/RadTreeView_PopulatingWithDataDeclaratively_020.PNG)

>tip Consider declaring treeview items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## See Also
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})
 * [Populating with Data - In Code-Behind]({%slug radtreeview-populating-with-data-in-code-behind%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})
 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to ADO.NET Data Service]({%slug radtreeview-populating-with-data-databinding-to-adonet-service%})