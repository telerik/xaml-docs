---
title: Selection
page_title: Selection
description: This article goes over the selection feature of the RadTabControl.
slug: radtabcontrol-features-selection
tags: selection
published: True
position: 2
---

# Selection

__RadTabControl__ exposes several useful properties and events, which can help you to work with items selection.
        
## Properties

* By using the __SelectedIndex__ property, you can get or set the index of the currently selected tab item.

* By using the __SelectedItem__ property, you can get or set the currently selected tab item. The reference you are passing should be to an instance of __RadTabItem__ that has already been added to the Items collection of the RadTabControl.

>If your tab control is bound to a custom collection, then the property __SelectedItem__ will not return __RadTabItem__ as you might expect, but an item of the type the source collection contains i.e. __Person__, __TabModel__ etc.

* Another way to select a certain tab item is by using the __RadTabItem__’s __IsSelected__ property. This is a Boolean property and when set to __True__, that specific tab item is selected, while the previous one gets deselected.

* Use the __SelectedContent__ property to get or set the content of the currently selected tab item. Please note that, when you set this property you will replace the content of the currently selected tab item, but the selected tab item will stay the same.

>__The items counting is zero based, meaning that the index of the first tab items is 0, the index of the second item is 1 and so on.__ If you want to clear the selection just set the property __SelectedIndex to -1__.

## Events

__RadTabControl__ provides two events in regards to its selection: __PreviewSelectionChanged__ and __SelectionChanged__. The first one is raised before the selection is complete. Marking the event as handled will basically revert the selection.

__Example 1: Subscribing to the PreviewSelectionChanged Event__

```XAML
	<telerik:RadTabControl x:Name="radTabControl" SelectedIndex="1" PreviewSelectionChanged="radTabControl_PreviewSelectionChanged">
	</telerik:RadTabControl>
```

__Example 2: Handling the PreviewSelectionChanged Event__

```C#
	private void radTabControl_PreviewSelectionChanged(object sender, Telerik.Windows.Controls.RadSelectionChangedEventArgs e)
        {
            e.Handled = true;
        }
```
```VB.NET
	Private Sub radTabControl_PreviewSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.RadSelectionChangedEventArgs)
    	e.Handled = True
	End Sub
``` 

The __SelectionChanged__ event is raised after the selection has already completed.

__Example 3: Subscribing to the SelectionChanged Event__

```XAML
	<telerik:RadTabControl x:Name="radTabControl" SelectedIndex="1" SelectionChanged="radTabControl_SelectionChanged" />
```

__Example 4: Implementing the SelectionChanged Event Handler__

```C#
	private void radTabControl_SelectionChanged( System.Object sender, System.Windows.RoutedEventArgs e )
	{
	    RadSelectionChangedEventArgs selectionArgs = ( RadSelectionChangedEventArgs )e;
	    MessageBox.Show( “The selected tab item is ” + ( ( RadTabItem )selectionArgs.AddedItems[ 0 ] ).Header.ToString() );
	}
```
```VB.NET
	Private Sub radTabControl_SelectionChanged( ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
	        Dim selectionArgs As RadSelectionChangedEventArgs = DirectCast(e,RadSelectionChangedEventArgs)
	        MessageBox.Show("The selected tab item is " + DirectCast(selectionArgs.AddedItems(0), RadTabItem).Header.ToString() )
	End Sub
```

>If your tab control is bound to a custom collection, the code above will fail with __InvalidCastException__, because the __AddedItems__ collection will no longer contain items of type __RadTabItem__ and the explicit cast will fail. The collection will contain items that are of the same type that the source collection contains i.e. __Person__, __TabModel__ etc.

## See Also  
 * [Keyboard Support]({%slug radtabcontrol-features-keyboard-support%})
 * [Add and Remove Tabs]({%slug radtabcontrol-populating-add-remove-tabs%})
