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

Most of these events are inherited from the [RadWindow]({%slug radwindow-events-overview%}) control. As the RadTabbedWindow contains a **TabbedWindowTabControl** which inherits from **RadTabControl**, most of its [events]({%slug radtabcontrol-features-pinandclose%}#events) bubble to the window as well.

## AddingNewTab

Occurs when a RadTabItem is being added via the 'Add' button in the UI. Its **AddingNewTabEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether adding the new tab via add button should be cancelled.

* **Item**: Gets or sets the newly added item. The type of the item depends on the scenario. 

	If the RadTabbedWindow control is __populated directly with RadTabItem elements__, the Item property contains an object of type RadTabItem which you can customize or completely replace. 
	
	#### [C#] Example 1: Handle the AddingNewTab event in data binding scenario  
	```C#
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
	```

	#### [VB.NET] Example 1: Handle the AddingNewTab event  
	```VB.NET
		Private Sub RadTabbedWindow_AddingNewTab(ByVal sender As Object, ByVal e As TabControlAddingNewTabEventArgs)
			If Me.TotalTabCount > Me.MaxTabCount Then ' replace with your cancel condition
				e.Cancel = True
			Else
				e.Item = New Person("P " & Me.Items.Count)
			End If
		End Sub
	```
	
	If the __ItemsSource of the control is populated (data binding scenario)__, the Item property will be empty (*null*) and you should manually set it to an object of your business type. Otherwise, no tab will added.
	
	#### [C#] Example 2: Handle the AddingNewTab event
	```C#
		private void RadTabbedWindow_AddingNewTab(object sender, TabControlAddingNewTabEventArgs e)
		{
			RadTabItem tabItem = e.Item as RadTabItem;
            if (tabItem != null)
            {
                tabItem.Header = "New tab";
                tabItem.Content = "Empty tab";
            } 
		}
	```

	#### [VB.NET] Example 2: Handle the AddingNewTab event
	```VB.NET
		Private Sub RadTabbedWindow_AddingNewTab(ByVal sender As Object, ByVal e As TabControlAddingNewTabEventArgs)
			Dim tabItem As RadTabItem = TryCast(e.Item, RadTabItem)

			If tabItem IsNot Nothing Then
				tabItem.Header = "New tab"
				tabItem.Content = "Empty tab"
			End If
		End Sub
	```
	
	>tip If the Item property is left empty (*null*), no tab will be added.

>important If the provided Item's **type** does not match the data type of the current **ItemsSource** an exception will be thrown.

## TabbedWindowCreating

Occurs when a new RadTabbedWindow is created via drag and drop and is about to be shown. Its **TabbedWindowCreatingEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether the creation of the new window should be cancelled.
* **SourceWindow**: The source window from which the drag drop operation is started.
* **NewWindow**: The new window created via drag drop operation.
* **DraggedTab**: The dragged RadTabItem from the source RadTabbedWindow. As of **R2 2019 SP1**, this property is **obsolete** and the **DraggedItem** property needs to be used instead.
* **DraggedItem**: The dragged RadTabItem in an unbound scenario or the dragged item (viewmodel) in a databinding scenario.

**Example 3** demonstrates how you can cancel the creation of the new window or attach the same handler to its **AddingNewTab** event as that of the source window in an **unbound scenario**.

#### [C#] Example 3: Handle the TabbedWindowCreating event in an unbound scenario
```C#
    private void MainWindow_TabbedWindowCreating(object sender, TabbedWindowCreatingEventArgs e)
    {
		var tab = e.DraggedItem as RadTabItem;
        if (tab != null && tab.Header.ToString() == "Progress") // replace with your cancel condition
        {
            e.Cancel = true;
        }
        else
        {
            e.NewWindow.AddingNewTab += this.MainWindow_AddingNewTab; // the AddingNewTab handler of the main RadTabbedWindow
        }
    }
```

#### [VB.NET] Example 3: Handle the TabbedWindowCreating event in an unbound scenario
```VB.NET
	Private Sub MainWindow_TabbedWindowCreating(ByVal sender As Object, ByVal e As TabbedWindowCreatingEventArgs)
		Dim tab = TryCast(e.DraggedItem, RadTabItem)
		If tab IsNot Nothing AndAlso tab.Header.ToString() = "Progress" Then ' replace with your cancel condition
			e.Cancel = True
		Else
			e.NewWindow.AddingNewTab += Me.MainWindow_AddingNewTab ' the AddingNewTab handler of the main RadTabbedWindow
		End If
	End Sub
```

You can also use the TabbedWindowCreating event to clear, update or replace the ItemsSource of the new window. **Example 4** demonstrates how to do so in a **databound scenario**.

#### [C#] Example 4: Change the ItemsSource of the new window in a databinding scenario
```C#
    private void MainWindow_TabbedWindowCreating(object sender, TabbedWindowCreatingEventArgs e)
    {
		var tabItem = e.DraggedItem as MyTabItem;
        if (tabItem != null && tabItem.Header == "Progress")
        {
            e.NewWindow.ItemsSource = null; 
		}
        else if (tabItem != null && tabItem.Header == "Microsoft")
        {
            var collection = e.NewWindow.ItemsSource as ObservableCollection<object>;
            if (collection != null)
            {
                collection.Add(new MyTabItem() { Header = "My tab 1" });
                collection.Add(new MyTabItem() { Header = "My tab 2" });
            }
		}
        else
        {
            var collection = new ObservableCollection<Person>();
			collection.Add(new Person() { Name = "John Doe", Age = 23 });
            e.NewWindow.ItemsSource = collection;
            e.NewWindow.DisplayMemberPath = "Name";
        }
    }
```

#### [VB.NET] Example 4: Change the ItemsSource of the new window in a databinding scenario
```VB.NET
	Private Sub MainWindow_TabbedWindowCreating(ByVal sender As Object, ByVal e As TabbedWindowCreatingEventArgs)
		Dim tabItem = TryCast(e.DraggedItem, MyTabItem)
		If tabItem IsNot Nothing AndAlso tabItem.Header = "Progress" Then
			e.NewWindow.ItemsSource = Nothing
		ElseIf tabItem IsNot Nothing AndAlso tabItem.Header = "Microsoft" Then
			Dim collection = TryCast(e.NewWindow.ItemsSource, ObservableCollection(Of Object))
			If collection IsNot Nothing Then
				collection.Add(New MyTabItem() With {.Header = "My tab 1"})
				collection.Add(New MyTabItem() With {.Header = "My tab 2"})
			End If
		Else
			Dim collection = New ObservableCollection(Of Person)
			collection.Add(New Person() With {
				.Name = "John Doe",
				.Age = 23
			})
			e.NewWindow.ItemsSource = collection
			e.NewWindow.DisplayMemberPath = "Name"
		End If
	End Sub
```

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

* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Styles and Templates]({%slug radtabbedwindow-styles-and-templates%})
