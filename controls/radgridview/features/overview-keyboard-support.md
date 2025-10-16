---
title: Keyboard Support
page_title: Keyboard Support
description: Learn how you can control the keyboard interaction and get notified when keyboard events occur within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-overview-keyboard-support
tags: keyboard,support
published: True
position: 7
---

# Keyboard Support

`RadGridView` exposes several useful properties and events, which can help you control the keyboard interaction and get notified when keyboard events occur. Moreover, using the keyboard you can perform some common tasks, such as:

* Change the __selection__&mdash;Use the __arrow__ keys to change your selection. To select multiple rows hold the __Shift\Ctrl__ key pressed and use the arrow keys or the mouse to select the desired rows.
* __Sort__ by multiple columns&mdash;Hold the __Shift__ key pressed and click all column headers by which you wish to sort your data.
* __Sort the current column__&mdash;Press __F3__ to change the SortState property of the current column. You can also hold the __Shift__ key while pressing __F3__ to add, update, or remove the CurrentColumn from the sorting.
* __Filter the current column__&mdash; Press the __F5__ key to open the filtering popup or the filtering button's drop-down menu depending on the `FilteringMode` property.
* __Group the current column__&mdash; Press __F7__ to group/ungroup the current column.
* __Start cell edit__&mdash;Press __F2__ and the current cell will enter in edit mode.
* __End cell edit__&mdash;Press __Enter__ while the cell is in edit mode. This will confirm the changes you've made.
* __Cancel cell edit__&mdash;Press __Escape__ while the cell is in edit mode. This will rollback the changes you've made.
* __Add new row__&mdash;Press __Insert__ and new row will be inserted automatically.
* __Delete existing row__&mdash;Users can delete (if supported by the collection assigned to the ItemsSource of RadGridView) selected items using __DELETE__ key. This feature can be controlled with RadGridView's `CanUserDeleteRows` property. Additional to this, the delete command won't be executed if the `IsReadOnly` property of RadGridView is __true__ or the selected row is in edit mode.

>In case you require to __utilize different commands corresponding to the keyboard interaction__, you may take advantage of the IKeyboardCommandProvider interface and implement your custom logic. Please check  [this article]({%slug gridview-commands-keyboardcommandprovider%}) for further information.

In the following table you can find some of the actions and the respective combination that invokes them:

 Hotkey | Command | Action
--- | --- | ---
Enter | RadGridViewCommands.CommitEdit | Commit the changes(edit mode) and select next row 
Enter | RadGridViewCommands.CommitEdit | Select next row
F2 | RadGridViewCommands.BeginEdit | Put current cell in edit mode
F3 | RadGridViewCommands.SortColumn | Change the SortingState of the CurrentColumn
Shift + F3 | RadGridViewCommands.SortAdditionalColumn | Add/update/remove the CurrentColumn from the sorting
F5 | RadGridViewCommands.FilterColumn | Open the filtering popup or the button's drop-down depending on the FilteringMode property
F7 | RadGridViewCommands.GroupColumn | Group/ungroup the CurrentColumn
Esc | RadGridViewCommands.CancelCellEdit | Cancel the editing of the current cell
Insert | RadGridViewCommands.BeginInsert | Insert new row
Delete | RadGridViewCommands.Delete | Delete selected row
Left key | RadGridViewCommands.MoveLeft | Focus next cell on the left
Right Key | RadGridViewCommands.MoveRight | Focus next cell on the right
Down Key | RadGridViewCommands.MoveDown | Focus next cell below
Up Key | RadGridViewCommands.MoveUp | Focus next cell above
Page Up | RadGridViewCommands.MoveTop  | Focus first cell 
Page Down | RadGridViewCommands.MoveBottom | Focuses first cell of last row 
Home | RadGridViewCommands.MoveHome | Focus first cell of selected row
End | RadGridViewCommands.MoveEnd | Focus last cell of selected row
Tab | RadGridViewCommands.MoveNext | Focuses next cell
Tab + Shift | RadGridViewCommands.MovePrevious | Focuses previous cell
Ctrl + C | RadGridViewCommands.Copy | Copy text
Ctrl + V | RadGridViewCommands.Paste | Paste text
Ctrl + F | RadGridViewCommands.Search | Show Search Panel
Space | RadGridViewCommands.CollapseHierarchyItem | Collapse a particular item in the hierarchy
Space | RadGridViewCommands.ExpandHierarchyItem | Expand a particular item in the hierarchy

>important The actions might vary depending on the mode of RadGridView and different property combinations. 

>You can find more information regarding __RadGridView`s commands__ in the [Commands Overview]({%slug gridview-commands-overview%}) article.
		 

## Properties

* Set the `IsTabStop` property to include/exclude the control in the tab navigation cycle. If this property is set to __True__, then the control will be included; if it is __False__ it will be skipped.

* The `TabIndex` property defines the index of the control in the tab navigation cycle. The lower the number is, the earlier the control will be focused while navigating using the Tab key. If you set this property, do not forget to set IsTabStop to __True__. 

* The `TabStopMode` property of the __column__ denotes if its cells could gain focus with the TAB key navigation.
{% if site.site_name == 'Silverlight' %}

* If you are looking for a better way to control how the tab navigation cycles inside the RadGridView control, use the property `TabNavigation`. You can set it to one of these three possible values:
{% endif %}

## Events

Here is a list of the common keyboard events exposed by the RadGridView, `GridViewRow` and `GridViewCell` elements:

* `KeyUp`&mdash;occurs when the user releases a keyboard key. The type of the passed event arguments is `KeyEventArgs`.

* `KeyDown`&mdash;occurs when the user presses a keyboard key. The type of the passed event arguments is `KeyEventArgs`.

In the following example, you can see how to subscribe to KeyDown and KeyUp events from XAML.

__Subscribe to KeyDown and KeyUp events__
```XAML
	<telerik:RadGridView x:Name="radGridView" KeyDown="radGridView_KeyDown" KeyUp="radGridView_KeyUp"/>
```

>tipIt is always a good practice to attach your event handlers in the XAML, whenever your application logic allows this.

The implementation of both event handlers is located in the code-behind file (C# or VB.NET) and looks like this:

__Implementation of KeyUp and KeyDown events__
```C#
	private void radGridView_KeyDown(object sender, KeyEventArgs e)
	{
	    MessageBox.Show("The pressed key is: " + e.Key.ToString());
	}
	private void radGridView_KeyUp(object sender, KeyEventArgs e)
	{
	    MessageBox.Show("The released key is: " + e.Key.ToString());
	}
```
```VB.NET
	Private Sub radGridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The pressed key is: " & e.Key.ToString())
	End Sub
	
	Private Sub radGridView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
	    MessageBox.Show("The released key is: " & e.Key.ToString())
	End Sub
```


You can attach to the other keyboard events in the same way.

## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})
 * [Mouse Support]({%slug gridview-overview-mouse-support%})
 * [Keyboard Command Provider]({%slug gridview-commands-keyboardcommandprovider%})
 * [Configure the Data Bindings]({%slug gridview-configuring-the-databindings%})
 * [Managing Data]({%slug gridview-overview-managing-data%})
