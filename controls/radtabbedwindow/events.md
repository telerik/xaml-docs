---
title: Events
page_title: Events
description: This article describes the RadTabbedWindow events.
slug: radtabbedwindow-events
tags: overview
published: True
position: 3
---

# Events

The RadTabbedWindow control exposes a number of events to let you easily customize its behavior.

Most of these events are inherited from the [RadWindow](%slug radwindow-events-overview%) control. As the RadTabbedWindow contains a **TabbedWindowTabControl** which inherits from **RadTabControl**, most of its [events](%slug radtabcontrol-features-pinandclose%#events) bubble to the window as well.

## AddingNewTab

Occurs when a RadTabItem is being added via the 'Add' button in the UI. Its **AddingNewTabEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether adding the new tab via add button should be cancelled.

* **Item**: Gets or sets the newly added item. The type of the item depends on the scenario. 

	If the RadTabbedWindow control is __populated directly with RadTabItem elements__, the Item property contains an object of type RadTabItem which you can customize or completely replace. 
	
	#### [C#] Example 1: Handle the AddingNewTab event in data binding scenario  
	{{region cs-radtabbedwindow-events_1}}
		private void RadTabbedWindow_AddingNewTab(object sender, TabControlAddingNewTabEventArgs e)
		{
			if (this.TotalTabCount > this.MaxTabCount) // replace with your cancel condition
			{
				e.Cancel = true;
			}
			else
			{
				e.Item = new Person("P " + this.Items.Count);
			}
		}
	{{endregion}}

	#### [VB.NET] Example 1: Handle the AddingNewTab event  
	{{region vb-radtabbedwindow-events_1}}
		Private Sub RadTabbedWindow_AddingNewTab(ByVal sender As Object, ByVal e As TabControlAddingNewTabEventArgs)
			If Me.TotalTabCount > Me.MaxTabCount Then ' replace with your cancel condition
				e.Cancel = True
			Else
				e.Item = New Person("P " & Me.Items.Count)
			End If
		End Sub
	{{endregion}}
	
	If the __ItemsSource of the control is populated (data binding scenario)__, the Item property will be empty (*null*) and you should manually set it to an object of your business type. Otherwise, no tab will added.
	
	#### [C#] Example 2: Handle the AddingNewTab event
	{{region cs-radtabbedwindow-events_2}}
		private void RadTabbedWindow_AddingNewTab(object sender, TabControlAddingNewTabEventArgs e)
		{
			RadTabItem tabItem = e.Item as RadTabItem;
            if (tabItem != null)
            {
                tabItem.Header = "New tab";
                tabItem.Content = "Empty tab";
            } 
		}
	{{endregion}}

	#### [VB.NET] Example 2: Handle the AddingNewTab event
	{{region vb-radtabbedwindow-events_2}}
		Private Sub RadTabbedWindow_AddingNewTab(ByVal sender As Object, ByVal e As TabControlAddingNewTabEventArgs)
			Dim tabItem As RadTabItem = TryCast(e.Item, RadTabItem)

			If tabItem IsNot Nothing Then
				tabItem.Header = "New tab"
				tabItem.Content = "Empty tab"
			End If
		End Sub
	{{endregion}}
	
	>tip If the Item property is left empty (*null*), no tab will be added.

>important If the provided Item's **type** does not match the data type of the current **ItemsSource** an exception will be thrown.

## TabbedWindowCreating

Occurs when a new RadTabbedWindow is created via drag and drop and is about to be shown. Its **TabbedWindowCreatingEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether the creation of the new window should be cancelled.
* **SourceWindow**: The source window from which the drag drop operation is started.
* **NewWindow**: The new window created via drag drop operation.
* **DraggedTab**: The dragged RadTabItem from the source RadTabbedWindow.

#### [C#] Example 3: Handle the TabbedWindowCreating event  
{{region cs-radtabbedwindow-events_3}}
    private void MainWindow_TabbedWindowCreating(object sender, TabbedWindowCreatingEventArgs e)
    {
        if (e.DraggedTab.Header.ToString() == "Progress") // replace with your cancel condition
        {
            e.Cancel = true;
        }
        else
        {
            e.NewWindow.AddingNewTab += this.MainWindow_AddingNewTab; // the AddingNewTab handler of the main RadTabbedWindow
        }
    }
{{endregion}}

#### [VB.NET] Example 3: Handle the TabbedWindowCreating event  
{{region vb-radtabbedwindow-events_3}}
	Private Sub MainWindow_TabbedWindowCreating(ByVal sender As Object, ByVal e As TabbedWindowCreatingEventArgs)
		If e.DraggedTab.Header.ToString() = "Progress" Then ' replace with your cancel condition
			e.Cancel = True
		Else
			e.NewWindow.AddingNewTab += Me.MainWindow_AddingNewTab ' the AddingNewTab handler of the main RadTabbedWindow
		End If
	End Sub
{{endregion}}

## PreviewTabClosed

Occurs when a RadTabItem is about to be closed. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabClosed

Occurs when a RadTabItem is closed. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewTabPinned

Occurs when a RadTabItem is about to be pinned. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabPinned

Occurs when a RadTabItem is pinned. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewTabUnpinned

Occurs when a RadTabItem is about to be unpinned. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabUnpinned

Occurs when a RadTabItem is unpinned. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewSelectionChanged

Handling this event by setting the **RadSelectionChangedEventArgs**' **Handled** property to **True** rollbacks the selection.

## SelectionChanged

Occurs when a change has been made to the selection.

## See Also

* [Key Properties](%slug radtabbedwindow-key-properties%)
* [Styles and Templates](%slug radtabbedwindow-styles-and-templates%)
