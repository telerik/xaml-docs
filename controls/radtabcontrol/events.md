---
title: Events
page_title: Events
description: This article lists all of the events specific for the RadTabControl control.
slug: radtabcontrol-events
tags: events, radtabcontrol, events
publish: True
position: 3
---

# Events

This article lists the events specific for the __RadTabControl__ control.

* __PreviewTabClosed__: Occurs when a __RadTabItem__ is about to be closed. The event arguments are of type __PreviewTabChangedEventArgs__ and provide access to the following properties:

	* __TabItem__: The __RadTabItem__ that has been changed.
	
	* __DataContext__: The __DataContext__ of the changed __RadTabItem__.
	
		__Example 1: PreviewTabClosed Event Handler__
		```C#
			private void TabControl_PreviewTabClosed(object sender, Telerik.Windows.Controls.PreviewTabChangedEventArgs e)
			{
				if (e.TabItem.Header.ToString() == "Tab 1")
				{
					e.Cancel = true;
				}
			}
		```
```VB.NET
			Private Sub TabControl_PreviewTabClosed(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PreviewTabChangedEventArgs)
				If e.TabItem.Header.ToString() = "Tab 1" Then
					e.Cancel = True
				End If
			End Sub
		```
	
* __TabClosed__: Occurs when a __RadTabItem__ is closed. The event arguments are of type __TabChangedEventArgs__ and expose the following members:

	* __TabItem__: The __RadTabItem__ that has been changed.
	
	* __DataContext__: The DataContext of the changed __TabItem__.
	
* __PreviewTabUnpinned__: Occurs when a __RadTabItem__ is about to be unpinned. Event arguments are of of type __PreviewTabChangedEventArgs__.

	__Example 2: PreviewTabUnpinned Event Handler__	
	```C#
		private void RadTabControl_PreviewTabUnpinned(object sender, Telerik.Windows.Controls.PreviewTabChangedEventArgs e)
		{
			MessageBox.Show($"{e.TabItem.Header} is about to be unpinned.");
		}
	```
```VB.NET
		Private Sub RadTabControl_PreviewTabUnpinned(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PreviewTabChangedEventArgs)
			MessageBox.Show($"{e.TabItem.Header} is about to be unpinned.")
		End Sub
	```

* __TabUnpinned__: Occurs when a __RadTabItem__ is unpinned. The event arguments are of type __TabChangedEventArgs__.

* __PreviewTabPinned__: Occurs when a __RadTabItem__ is about to be pinned. The event arguments are of type __PreviewTabChangedEventArgs__.

	__Example 3: PreviewTabPinned Event Handler__	
	```C#
		private void RadTabControl_PreviewTabPinned(object sender, Telerik.Windows.Controls.PreviewTabChangedEventArgs e)
		{
			e.Cancel = true;
		}
	```
```VB.NET
		Private Sub RadTabControl_PreviewTabPinned(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.PreviewTabChangedEventArgs)
			e.Cancel = True
		End Sub
	```
	
* __TabPinned__: Occurs when a __RadTabItem__ is pinned. The event arguments are of type __TabChangedEventArgs__.

* __DropDownOpened__: An event that is raised when the Telerik.Windows.Controls.TabControl.DropDownMenu is opened. This is a RoutedEvent. The event arguments are of type __DropDownEventArgs__ and expose the following members:

	* __DropDownItemsSource__: Gets or sets the items collection for the drop down context menu.
	
	* __RoutedEvent__: Gets or sets the RoutedEventAgs.RoutedEvent associated with this RoutedEventArgs instance.
	
		__Example 4: DropDownOpened Routed Event__	
		```C#
			private void RadTabControl_DropDownOpened(object sender, DropDownEventArgs e)
			{
				List<string> dropDownItems = e.DropDownItemsSource.Cast<string>().ToList<string>();
				dropDownItems.Add("New DropDown Item.");
				e.DropDownItemsSource = dropDownItems;
			}
		```
```VB.NET
			Private Sub RadTabControl_DropDownOpened(ByVal sender As Object, ByVal e As DropDownEventArgs)
				Dim dropDownItems As List(Of String) = e.DropDownItemsSource.Cast(Of String)().ToList(Of String)()
				dropDownItems.Add("New DropDown Item.")
				e.DropDownItemsSource = dropDownItems
			End Sub
		```

* __DropDownClosed__: This event is raised when the Telerik.Windows.Controls.TabControl.DropDownMenu is closed.	This is a RoutedEvent. The event arguments are of type __DropDownEventArgs__.

* __ItemReordered__: This event occurs when an item is reordered while dragging. This is a RoutedEvent. In order for this event to be raised, the __AllowDragReorder__ property needs to be set to __True__. The event arguments are of type __ItemReorderedEventArgs__ and expose the following members:

	* __OldIndex__: Gets the previous index of the dragged item.
	
	* __NewIndex__: Gets the next index of the dragged item.
