---
title: Load on Demand
page_title: Load on Demand
description: Check our &quot;Load on Demand&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-features-load-on-demand
tags: load,on,demand
published: True
position: 8
---

# Load on Demand

The performance of the Telerik __RadTreeView__ control when operating with huge amount of items is significantly optimized through its load on demand feature. This mechanism lets the nodes load their child nodes as the user expands the parent by clicking on the expander icon.

This tutorial will walk you through the following common tasks:

* Enable load on demand behavior declaratively and programmatically.
* Using events to manage the load on demand process.
* Using the __IsLoadingOnDemand__ property.

For the purpose of this tutorial will be used the following treeview declaration: 

```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView">
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football"/>
	        <telerik:RadTreeViewItem Header="Tennis"/>
	        <telerik:RadTreeViewItem Header="Cycling"/>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
```

![{{ site.framework_name }} RadTreeView Sample Structure](images/RadTreeView_FeaturesLoadOnDemand_001.PNG)

## Enable Load on Demand Declaratively 

To enable this feature you can set the __IsLoadOnDemandEnabled__ property to the __RadTreeViewItem__ to __True__.

```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView">
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football" IsLoadOnDemandEnabled="True"/>
	        <telerik:RadTreeViewItem Header="Tennis" IsLoadOnDemandEnabled="True"/>
	        <telerik:RadTreeViewItem Header="Cycling" IsLoadOnDemandEnabled="True"/>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
```

## Enable Load on Demand Programmatically 

The same effect can be achieved if you set the __IsLoadOnDemandEnabled__ property of an instance of the __RadTreeViewItem__ class in the code-behind:

```C#
	private void EnableLoadOnDemand( RadTreeViewItem radTreeViewItem )
	{
	    radTreeViewItem.IsLoadOnDemandEnabled = true;
	}
```
```VB.NET
	Private Sub EnableLoadOnDemand(ByVal radTreeViewItem As RadTreeViewItem)
	    radTreeViewItem.IsLoadOnDemandEnabled = True
	End Sub
```
	
![{{ site.framework_name }} RadTreeView Is Load On Demand Enabled](images/RadTreeView_FeaturesLoadOnDemand_010.PNG)

## Events 

When the expand icon is clicked the __LoadOnDemand__ event is fired. This event provides the opportunity to add new items based on the identity of the clicked-on Item.

* Here is an example of how to handle the __LoadOnDemand__ event when attached to a __RadTreeViewItem__:

	```XAML
		<telerik:RadTreeView Margin="8" x:Name="radTreeView">
			<telerik:RadTreeViewItem Header="Sport Categories">
				<telerik:RadTreeViewItem Header="Football" IsLoadOnDemandEnabled="True" LoadOnDemand="RadTreeViewItem_LoadOnDemand"/>
				<telerik:RadTreeViewItem Header="Tennis" IsLoadOnDemandEnabled="True"/>
				<telerik:RadTreeViewItem Header="Cycling" IsLoadOnDemandEnabled="True"/>
			</telerik:RadTreeViewItem>
		</telerik:RadTreeView>
	```
	
	```C#
		private void RadTreeViewItem_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
		{
			// get the clicked Item
			RadTreeViewItem clickedItem = sender as RadTreeViewItem;
			// add the new items
			RadTreeViewItem newItem = new RadTreeViewItem()
			{
				Header = "Soccer"
			};
			clickedItem.Items.Add( newItem );
		}
	```
	```VB.NET
		Private Sub RadTreeViewItem_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			' get the clicked Item '
			Dim clickedItem As RadTreeViewItem = TryCast(sender, RadTreeViewItem)
			' add the new items '
			Dim newItem As New RadTreeViewItem()
			clickedItem.Items.Add(newItem)
		End Sub
	```

* If you want to enable the Load on demand functionality globally for the entire __RadTreeView__ you can set the __IsLoadOnDemandEnabled__ property to the __RadTreeView__. This will make all Items in the __RadTreeView__ to have the expander icon enabled.
		
	Here is an example of how to handle the __LoadOnDemand__ event when attached to the __RadTreeView__:

	```XAML
		<telerik:RadTreeView Margin="8" x:Name="radTreeView" IsLoadOnDemandEnabled="True" LoadOnDemand="radTreeView_LoadOnDemand">
			<telerik:RadTreeViewItem Header="Sport Categories">
				<telerik:RadTreeViewItem Header="Football"/>
				<telerik:RadTreeViewItem Header="Tennis"/>
				<telerik:RadTreeViewItem Header="Cycling"/>
			</telerik:RadTreeViewItem>
		</telerik:RadTreeView>
	```

	```C#
		private void radTreeView_LoadOnDemand( object sender, RadRoutedEventArgs e )
		{
			// get the treeview
			Telerik.Windows.Controls.RadTreeView tree = sender as Telerik.Windows.Controls.RadTreeView;
			// get the clicked Item
			RadTreeViewItem clickedItem = e.OriginalSource as RadTreeViewItem;
			// add the new items
			RadTreeViewItem newItem = new RadTreeViewItem()
			{
				Header = "New Item"
			};
			clickedItem.Items.Add( newItem );
			clickedItem.IsLoadOnDemandEnabled = false;
		}
	```
	```VB.NET
		Private Sub radTreeView_LoadOnDemand(sender As Object, e As RadRoutedEventArgs)
		 ' get the treeview '
		 Dim tree As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
		 ' get the clicked Item '
		 Dim clickedItem As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
		 ' add the new items '
		 Dim newItem As New RadTreeViewItem()
		 clickedItem.Items.Add(newItem)
		 clickedItem.IsLoadOnDemandEnabled = False
		End Sub
	```

>tip The __RadRoutedEventArgs__ expose both the __Source__ and the __OriginalSource__ of the event.{% if site.site_name == 'Silverlight' %} Both properties point to the __RadTreeViewItem__ that was clicked. {% endif %}{% if site.site_name == 'WPF' %}The __Source__ property points to the __RadTreeView__ control that is currently handling the event, but the __OriginalSource__ property points to the __RadTreeViewItem__ that was clicked.{% endif %}

## The IsLoadingOnDemand Property 

When there are no items to add, and you want to stop the loading animation, set the __IsLoadingOnDemand__ property to __False__ to the __RadTreeViewItem__ that has fired the __LoadOnDemand__ event.

>tip When there are no items to add, and you want to prevent the __LoadOnDemand__ event to fire again, set the __IsLoadOnDemandEnabled__ property to __False__ to the __RadTreeViewItem__ that has fired the __LoadOnDemand__ event.

## See Also

 * [Data Binding]({%slug radtreeview-features-data-binding%})
 * [CheckBox Support]({%slug check-box-support%})
 * [Keyboard Support]({%slug radtreeview-features-keyboard-support%})