---
title: Iterate Through TreeViewItems
page_title: Iterate Through TreeViewItems
description: Check our &quot;Iterate Through TreeViewItems&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-iterate-through-treeviewitems
tags: iterate,through,treeviewitems
published: True
position: 11
---

# Iterate Through TreeViewItems

Telerik __RadTreeView__ class inherits from __ItemsControl__. The __Items__ collection of the __ItemsControl__ is a collection of data objects, __not__ from __RadTreeViewItems__. There is a very important concept about the items and item containers. When you bind an __ItemsControl__ you have your data items populating the __Items__ collection of the control. The containers are the __visual presentations__ of those data items (in this case the containers are the __RadTreeViewItems__). Containers are not created automatically when the __ItemsControl__ is bound, but are created __asynchronously and only when needed__. For example in the case with the TreeView, the containers are not being created until their parent is expanded.

So how you can get the container from the data item? Or in this case - how to get the RadTreeViewItem from your data object which you receive when traversing the Items collection?

There are several helper methods that can be used. Each ItemsControl has a Property named __ItemContainerGenerator__. It is of type __ItemContainerGenerator__. This class has the following methods that can help you in this case:		

* __DependencyObject.ContainerFromIndex(int index)__ - returns the Container for the given index from the Items collection.
* __DependencyObject.ContainerFromItem(object item)__ -  returns the Container for the given data item from the Items collection.

So here is an example about how to get access to all of the Containers in the __RadTreeView__:

The item container may be null if it isn't still generated from the runtime. That's why you should access the containers when your control is generated and added to the visual tree. 

#### __C#__

```C#
	this.Loaded += new RoutedEventHandler( IterateTreeViewItems_Loaded );
```

#### __VB.NET__

```VB.NET
	AddHandler Me.Loaded, AddressOf IterateTreeViewItems_Loaded
```

{% if site.site_name == 'Silverlight' %}

#### __C#__

```C#
	private void IterateTreeViewItems_Loaded( object sender, RoutedEventArgs e )
	{
	    this.GetContainers();
	}
	
	private void GetContainers()
	{
	    // gets all nodes from the TreeView  
	    Collection<RadTreeViewItem> allTreeContainers = GetAllItemContainers( this.radTreeView );
	    // gets all nodes (recursively) for the first node  
	    RadTreeViewItem firstNode = this.radTreeView.ItemContainerGenerator.ContainerFromIndex( 0 ) as RadTreeViewItem;
	    if ( firstNode != null )
	    {
	        Collection<RadTreeViewItem> firstNodeContainers = GetAllItemContainers( firstNode );
	    }
	}
	
	private Collection<RadTreeViewItem> GetAllItemContainers( Telerik.Windows.Controls.ItemsControl itemsControl )
	{
	    Collection<RadTreeViewItem> allItems = new Collection<RadTreeViewItem>();
	    for ( int i = 0; i < itemsControl.Items.Count; i++ )
	    {
	        // try to get the item Container  
	        RadTreeViewItem childItemContainer = itemsControl.ItemContainerGenerator.ContainerFromIndex( i ) as RadTreeViewItem;
	        // the item container maybe null if it is still not generated from the runtime  
	        if ( childItemContainer != null )
	        {
	            allItems.Add( childItemContainer );
	            Collection<RadTreeViewItem> childItems = GetAllItemContainers( childItemContainer );
	            foreach ( RadTreeViewItem childItem in childItems )
	            {
	                allItems.Add( childItem );
	            }
	        }
	    }
	    return allItems;
	}
```

#### __VB.NET__

```VB.NET
	Private Sub IterateTreeViewItems_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Me.GetContainers()
		End Sub
	
		Private Sub GetContainers()
			' gets all nodes from the TreeView  '
			Dim allTreeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(Me.radTreeView)
	
			' gets all nodes (recursively) for the first node  '
			Dim firstNode As RadTreeViewItem = TryCast(Me.radTreeView.ItemContainerGenerator.ContainerFromIndex(0), RadTreeViewItem)
			If firstNode IsNot Nothing Then
				Dim firstNodeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(firstNode)
			End If
		End Sub
	
		Private Function GetAllItemContainers(ByVal itemsControl As Telerik.Windows.Controls.ItemsControl) As Collection(Of RadTreeViewItem)
	
			Dim allItems As New Collection(Of RadTreeViewItem)()
	
			For i As Integer = 0 To itemsControl.Items.Count - 1
				' try to get the item Container  '
				Dim childItemContainer As RadTreeViewItem = TryCast(itemsControl.ItemContainerGenerator.ContainerFromIndex(i), RadTreeViewItem)
	
				' the item container maybe null if it is still not generated from the runtime  
				If childItemContainer IsNot Nothing Then'
					allItems.Add(childItemContainer)
	
					Dim childItems As Collection(Of RadTreeViewItem) = GetAllItemContainers(childItemContainer)
					For Each childItem As RadTreeViewItem In childItems
						allItems.Add(childItem)
					Next
				End If
			Next
			Return allItems
		End Function
```

{% endif %}

{% if site.site_name == 'WPF' %}

#### __C#__

```C#
	private void IterateTreeViewItems_Loaded( object sender, RoutedEventArgs e )
	{
	    this.GetContainers();
	}
	
	private void GetContainers()
	{
	    // gets all nodes from the TreeView  
	    Collection<RadTreeViewItem> allTreeContainers = GetAllItemContainers( this.radTreeView );
	    // gets all nodes (recursively) for the first node  
	    RadTreeViewItem firstNode = this.radTreeView.ItemContainerGenerator.ContainerFromIndex( 0 ) as RadTreeViewItem;
	    if ( firstNode != null )
	    {
	        Collection<RadTreeViewItem> firstNodeContainers = GetAllItemContainers( firstNode );
	    }
	}
	
	private Collection<RadTreeViewItem> GetAllItemContainers( System.Windows.Controls.ItemsControl itemsControl )
	{
	    Collection<RadTreeViewItem> allItems = new Collection<RadTreeViewItem>();
	    for ( int i = 0; i < itemsControl.Items.Count; i++ )
	    {
	        // try to get the item Container  
	        RadTreeViewItem childItemContainer = itemsControl.ItemContainerGenerator.ContainerFromIndex( i ) as RadTreeViewItem;
	        // the item container maybe null if it is still not generated from the runtime  
	        if ( childItemContainer != null )
	        {
	            allItems.Add( childItemContainer );
	            Collection<RadTreeViewItem> childItems = GetAllItemContainers( childItemContainer );
	            foreach ( RadTreeViewItem childItem in childItems )
	            {
	                allItems.Add( childItem );
	            }
	        }
	    }
	    return allItems;
	}
```

#### __VB.NET__

```VB.NET
		Private Sub IterateTreeViewItems_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.GetContainers()
		End Sub
	
		Private Sub GetContainers()
			' gets all nodes from the TreeView  '
			Dim allTreeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(Me.radTreeView)
	
			' gets all nodes (recursively) for the first node  '
			Dim firstNode As RadTreeViewItem = TryCast(Me.radTreeView.ItemContainerGenerator.ContainerFromIndex(0), RadTreeViewItem)
			If firstNode IsNot Nothing Then
				Dim firstNodeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(firstNode)
			End If
		End Sub
	
		Private Function GetAllItemContainers(ByVal itemsControl As System.Windows.Controls.ItemsControl) As Collection(Of RadTreeViewItem)
	
			Dim allItems As New Collection(Of RadTreeViewItem)()
	
			For i As Integer = 0 To itemsControl.Items.Count - 1
				' try to get the item Container  '
				Dim childItemContainer As RadTreeViewItem = TryCast(itemsControl.ItemContainerGenerator.ContainerFromIndex(i), RadTreeViewItem)
	
				' the item container maybe null if it is still not generated from the runtime  '
				If childItemContainer IsNot Nothing Then
					allItems.Add(childItemContainer)
	
					Dim childItems As Collection(Of RadTreeViewItem) = GetAllItemContainers(childItemContainer)
					For Each childItem As RadTreeViewItem In childItems
						allItems.Add(childItem)
					Next
				End If
			Next
			Return allItems
		End Function
```

{% endif %}

## See Also
 * [Bind to a Selected Item]({%slug radtreeview-how-to-bind-selected-item%})
 * [Add Context Menu]({%slug radtreeview-how-to-add-context-menu%})
 * [Bind RadTreeView to Self-Referencing Data]({%slug radtreeview-how-to-bind-to-self-referencing-data%})
 * [Bind RadTreeView to Hierarchical Data and Use Style Binding]({%slug radtreeview-howto-bind-hierarchical-data-style-binding%})