---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-feautres-treeviewitem-selection
tags: selection
published: True
position: 6
---

# Selection

This article describes the selection API exposed by __RadTreeView__. The control allows you to change the selection mode, to set and get the selection and managing the selection process using events.

* [Manual item selection](#manual-item-selection)
* [Selecting an item via the SelectedItems collection](#selecting-an-item-by-using-the-selecteditems-collection)
* [Changing the selection mode](#changing-the-selection-mode)
* [Accessing the selected items](#accessing-the-selected-items)
* [Events](#events)
* [Using the SelectedItem, SelectedValue and SelectedValuePath properties](#using-the-selecteditem-selectedvalue-and-selectedvaluepath-properties)
* [Binding the IsSelected property](#binding-the-isselected-property)
* [Binding the IsSelectable property](#binding-the-isselectable-property)

## Manual item selection

You can select a __RadTreeViewItem__ by setting its __IsSelected__ to True.

__Example 1: Setting IsSelected in XAML__  
```XAML
	<telerik:RadTreeViewItem x:Name="radTreeViewItem" IsSelected="True"/>
```

__Example 2: Setting IsSelected in code__  
```C#
	radTreeViewItem.IsSelected = true;
```
```VB.NET
	radTreeViewItem.IsSelected = True
```

>Note that the code snippets above cover a scenario when the __RadTreeView__ is [populated declaratively]({%slug radtreeview-populating-with-data-declaratively%}) (with static data). If you want to bind the __IsSelected__ property to a property of a custom business object, check out the [Binding the IsSelected Property](#binding-the-isselected-property) section at the end of this topic.

## Selecting an Item by Using the SelectedItems Collection

Another way to select a treeview item programmatically is to add it in the __SelectedItems__ collection of __RadTreeView__. There are two possible cases here depending on how the __RadTreeView__ is populated.

* If __RadTreeView__ is populated in XAML (with static data), then the __SelectedItems__ collection will contain instances of the __RadTreeViewItem__ class.

	__Example 3: Adding RadTreeViewItem in the SelectedItems collection__  
	```C#
		radTreeView.SelectedItems.Add( radTreeViewItem );
	```
```VB.NET
		radTreeView.SelectedItems.Add(radTreeViewItem)
	```

* If __RadTreeView__ is [data bound to a business object]({%slug radtreeview-populating-with-data-data-binding-to-object%}), then the __SelectedItems__ collection will contain instances of the custom business object.

	__Example 4: Adding a business object in the SelectedItems collection__  
	```C#
		radTreeView.SelectedItems.Add( myViewModel );
	```
```VB.NET
		radTreeView.SelectedItems.Add(myViewModel)
	```

## Changing the Selection Mode

The __RadTreeView__ API allows you to change the selection mode. You can do that via the __SelectionMode__ property. The property is a __{% if site.site_name == 'WPF' %}System.Windows.Controls{% endif %}{% if site.site_name == 'Silverlight' %}Telerik.Windows.Controls{% endif %}.SelectionMode__ enumeration that exposes the following members:

* __Single__: In this mode the user will be able to select only one item at once.

* __Multiple__: This mode allows selection of multiple items. Clicking an item selects or deselects it depending on its current state. Also, the previously selected items will preserve their selection state.

* __Extended__: This mode allows the user to select multiple items at once by holding down the __Ctrl__ or __Shift__ keys and clicking multiple items with the mouse or by using the keyboard. A second click on a selected item will unselect that item.

	>important Until Q3 2015 __Multiple__ and __Extended__ SelectionModes worked the same way.  

__Example 5: Setting SelectionMode in XAML__  
```XAML
	<telerik:RadTreeView x:Name="radTreeView" SelectionMode="Multiple">
```
	
__Example 6: Setting SelectionMode in code__  
```C#
	private void ChangeSelectionMode()
	{
		radTreeView.SelectionMode = Telerik.Windows.Controls.SelectionMode.Multiple;
	}
```
```VB.NET
	Private Sub ChangeSelectionMode()
		radTreeView.SelectionMode = Telerik.Windows.Controls.SelectionMode.Multiple
	End Sub
```	

As you can see in __Figure 1__, when the SelectionMode is set to Multiple you are able to select more than one item.

#### __Figure 1: Multiple selection enabled__  
![{{ site.framework_name }} RadTreeView Multiple selection enabled](images/RadTreeView_TreeViewItemSelection_020.png)

>tip The default selection mode of the RadTreeView is __Single__.

## Accessing the Selected Items

The __RadTreeView__ class exposes several properties that allow you to access the currently selected item(s).

* __SelectedItem__: The currently selected item. In a multiple selection scenario the property will hold the first selected item.
* __SelectedItems__: A collection representing the currently selected items. It is appropriate to use the  __SelectedItems__ property when you have multiple selected items. __SelectedItems__ is an __ObservableCollection__ of objects.
* __SelectedContainer__: Gets the current selected item container. This property is __always__ of type __RadTreeViewItem__.		  

The SelectedItem and SelectedItems properties will contain different objects depending on the scenario.

* If RadTreeView is [populated declaratively]({%slug radtreeview-populating-with-data-declaratively%}) with RadTreeViewItems the __SelectedItem__ and __SelectedContainer__ properties will return objects of type __RadTreeViewItem__. The __SelectedItems__ collection also contains __RadTreeViewItems__.	

* If RadTreeView is [data bound]({%slug radtreeview-populating-with-data-data-binding-to-object%}) to a business object the __SelectedItem__ property will contain an instance of the custom business object. The __SelectedItems__ collection will also contain instances of the business object. In this case, the __SelectedContainer__ property still returns __RadTreeViewItem__.

> When you have multiple selected items, the __SelectedItem__ property will return the first selected item in the treeview.

<!-- -->
> When you reset the __RadTreeView__'s __Items__ collection (when you invoke the __RadTreeView.Items.Clear()__ method), that will also clear the __SelectedItems__ collection.

<!-- -->
> The __RadTreeView__ class inherits from __ItemsControl__. The __Items__ collection of the __ItemsControl__ is a collection of data objects, __not__ of __RadTreeViewItems__. There is a very important concept about the items and item containers. For more information read [here]({%slug radtreeview-how-to-iterate-through-treeviewitems%}).

<!-- -->
> Each __ItemsControl__ provides two additional properties for working with selection - __SelectedValue__ and __SelectedValuePath__. If want to learn how to use these two properties, please check out the [Using SelectedItem, SelectedValue and SelectedValuePath](#using-the-selecteditem-selectedvalue-and-selectedvaluepath-properties) section at the end of this topic.

## Events
		 
__RadTreeView__ and __RadTreeViewItem__ classes have several events for managing the selection process.		

__Example 7: RadTreeView selection events__  
```XAML
	<telerik:RadTreeView x:Name="radTreeView"
	        PreviewSelected="radTreeView_PreviewSelected"
	        Selected="radTreeView_Selected"
	        PreviewUnselected="radTreeView_PreviewUnselected"
	        Unselected="radTreeView_Unselected"
			PreviewSelectionChanged="radTreeView_PreviewSelectionChanged"
	        SelectionChanged="radTreeView_SelectionChanged"/>
```

The __PreviewSelected__ event occurs when the treeview item is about to be selected. The __Selected__ event is fired when the treeview item is already selected. The type of the passed event arguments for both of the events is __RadRoutedEventArgs__. In the event handlers you can place some code.

__Example 8: Setting the FontSize of the selected RadTreeViewItem__  
```C#
	private void radTreeView_Selected( object sender, RadRoutedEventArgs e )
	{
	    ( e.Source as RadTreeViewItem ).FontSize = 14;
	}
```
```VB.NET
	Private Sub radTreeView_Selected(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
	    TryCast(e.Source, RadTreeViewItem).FontSize = 14
	End Sub
```

>Note that the e.Source property in __Example 8__ from the event arguments will have a different value depending on if the RadTreeView is bound. In __Example 8__ the e.Source property will be of type RadTreeViewitem if the RadTreeView is not data-bound (the RadTreeViewItem is declared in XAML or added in code). When we bind the control the e.Source property will be the RadTreeView. In this case, you can utilize the PreviewSelectionChanged and SelectionChanged events of the RadTreeView, explained below.

The __PreviewUnselected__ event is fired just before the currently selected item is unselected. The __Unselected__ event occurs when the treeview item is already unselected. The type of the passed event arguments for both of the events is __RadRoutedEventArgs__.

In order to handle a change in the selection you can use the __PreviewSelectionChanged__ or the __SelectionChanged__ event. They are available only in the __RadTreeView__ class. The events are fired each time an item or multiple items are added/removed from the selection. The type of the passed event arguments for the event is __SelectionChangedEventArgs__.

__Example 9: Working with the SelectionChanged event arguments__  
```C#
	private void radTreeView_SelectionChanged( object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e )
	{
	    // Get a reference to the treeview
	    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
	
	    // Get the currently selected items
	    ObservableCollection<Object> selectedItems = treeView.SelectedItems;
	    // Get the newly added items to the collection
	    IList addedItems = e.AddedItems;
	    // Get the removed items from the collection
	    IList removedItems = e.RemovedItems;
	}
```
```VB.NET
	Private Sub radTreeView_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
	    ' Get a reference to the treeview '
	    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
	
	    ' Get the currently selected items '
	    Dim selectedItems As ObservableCollection(Of [Object]) = treeView.SelectedItems
	
	    ' Get the newly added items to the collection '
	    Dim addedItems As IList = e.AddedItems
	
	    ' Get the removed items from the collection '
	    Dim removedItems As IList = e.RemovedItems
	End Sub
```
	
> Four out of the six events (__PreviewSelected, Selected, PreviewUnselected__ and __Unselected__) are exposed by both __RadTreeView__ and __RadTreeViewItem__ classes. While the __SelectionChanged__ and __PreviewSelectionChanged__ events are available only in the __RadTreeView__ class.

<!-- -->
> Handling the PreviewSelected or PreviewSelectionChanged events will cancel the selection. To do this you can set the event arguments' Handled property to True.

## Using the SelectedItem, SelectedValue and SelectedValuePath Properties

The __SelectedValue__ property is used when you have linked your __RadTreeView__ to a data source and you want to return a value other than the one that is displayed. 

The __SelectedValuePath__ property provides a way to specify a __SelectedValue__ for the __SelectedItem__ in a __RadTreeView__. 

The __SelectedItem__ represents an object from the __Items__ collection and the __RadTreeView__ displays the value of a single property of the selected item. The __SelectedValuePath__ property specifies the path to the property that is used to determine the value of the __SelectedValue__ property. The next example illustrates this concept.

Imagine that you have a business object named __MyViewModel__, with three members (properties): __Title__, __Price__ and __Children__. And a __RadTreeView__ that is data bound to a list of __MyViewModel__ objects. The __Title__ property is the property that is displayed. The __Price__ is set to the __SelectedValuePath__ property.

__Example 10: Defining business object's model__ 
```C#
	private class MyViewModel
	{
	    public string Title { get; set; }
	    public string Price { get; set; }
	    public IList<MyViewModel> Children { get; set; }
	}
```
```VB.NET
	Private Class MyViewModel
	Private _Title As String
	    Public Property Title() As String
	        Get
	            Return _Title
	        End Get
	        Set(ByVal value As String)
	            _Title = value
	        End Set
	    End Property
	
	Private _Price As String
	    Public Property Price() As String
	        Get
	            Return _Price
	        End Get
	        Set(ByVal value As String)
	            _Price = value
	        End Set
	    End Property
	
	Private _Children As IList(Of MyViewModel)
	    Public Property Children() As IList(Of MyViewModel)
	        Get
	            Return _Children
	        End Get
	        Set(ByVal value As IList(Of MyViewModel))
	            _Children = value
	        End Set
	    End Property
	End Class
```

{% if site.site_name == 'Silverlight' %}
__Example 11: Setting SelectedValuePath__ 
```XAML
	<telerik:RadTreeView x:Name="radTreeView" SelectedValuePath="Price">
	    <telerik:RadTreeView.ItemTemplate>
	        <telerik:HierarchicalDataTemplate ItemsSource="{Binding RelatedItems}">
	            <TextBlock Text="{Binding Title}" />
	        </telerik:HierarchicalDataTemplate>
	    </telerik:RadTreeView.ItemTemplate>
	</telerik:RadTreeView>
```
{% endif %}

{% if site.site_name == 'WPF' %}

__Example 11: Setting SelectedValuePath__  
```XAML
	<telerik:RadTreeView x:Name="radTreeView" SelectedValuePath="Price">
	    <telerik:RadTreeView.ItemTemplate>
	        <HierarchicalDataTemplate ItemsSource="{Binding RelatedItems}">
	            <TextBlock Text="{Binding Title}" />
	        </HierarchicalDataTemplate>
	    </telerik:RadTreeView.ItemTemplate>
	</telerik:RadTreeView>
```

{% endif %}

When you select a __MyViewModel.Title__ from the __RadTreeView__, the __SelectedItem__ property returns the	 __MyViewModel__ data item that corresponds to the selected __Title__. However, because the __SelectedValuePath__ of this __RadTreeView__ is set to the __MyViewModel__'s __Price__ property, the __SelectedValue__ will return the __Price__ property of the __MyViewModel__ business object (e.g. 101.56$).		

## Binding the IsSelected Property

A very common scenario is to have the __RadTreeViewItem__'s __IsSelected__ property bound to a property of a custom business object. The easiest way to achieve this is to use the __ItemContainerStyle__ property of RadTreeView or an __implicit style__ that targets RadTreeViewItem. 

Let's use the following example. There is a business object that defines a boolean property named *IsSelected* and we want to bind it to the __IsSelected__ property of __RadTreeViewItem__. In this case we can define a Style and set its TargetType to RadTreeViewItem. And then bind the IsSelected property as demonstrated in __Example 12__.

__Example 12: Setting ItemContainerStyle__  
```XAML
	<Style x:Key="ItemContainerStyle" TargetType="telerik:RadTreeViewItem">
	    <Setter Property="IsSelected" Value="{Binding IsSelected, Mode=TwoWay}"/>
	</Style>
	<!-- -->
	<telerik:RadTreeView ItemContainerStyle="{StaticResource ItemContainerStyle}"/>
```

If you remove the x:Key setting of the style, it will become an implicit style. This means that it will be applied globally to all RadTreeViewItems in the scope where the style is defined. In this case you will also need to remove the ItemContainerStyle setting.

## Binding the IsSelectable property

__RadTreeViewItem__ provides the option to control whether the item can be selected through the UI or not. This is done through its __IsSelectable__ property. Similarly to the previous example, the __IsSelectable__ property can be set through a Style targeting RadTreeViewItem. 

__Example 13: Binding the IsSelectable property__  
```XAML
	<Style x:Key="ItemContainerStyle" TargetType="telerik:RadTreeViewItem">
	    <Setter Property="IsSelectable" Value="{Binding IsSelectable}"/>
	</Style>
	<!-- -->
	<telerik:RadTreeView ItemContainerStyle="{StaticResource ItemContainerStyle}"/>
```

> The __IsSelectable__ property is available since the __R3 2018__ version.

## Performing Selection on the MouseLeftButtonUp Event

RadTreeView exposes the `PerformSelectionOnMouseUp` property that allows you to specify if the selection will be executed on the `MouseLeftButtonUp` or the `MoseLeftButtonDown` event. The default value of this property is __False__. Setting the PerformSelectionOnMouseUp property to __True__ will execute the selection logic on the MouseLeftButtonUp event.

__Example 14: Setting the PerformSelectionOnMouseUp property__
```XAML
	<telerik:RadTreeView PerformSelectionOnMouseUp="True"/>
```
		
## See Also  
 * [How to Edit An Item]({%slug radtreeview-feautres-treeviewitem-item-editing%})
 * [Item Images]({%slug radtreeview-feautres-treeviewitem-item-images%})
 * [Enable and Disable Items]({%slug radtreeview-feautres-treeviewitem-enable-disable-items%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})
 * [BringIntoView Support]({%slug radtreeview-features-treeviewitem-bring-into-view-support%})
