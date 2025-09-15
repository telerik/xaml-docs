---
title: Cancel Edit On LostFocus
page_title:  Cancel Edit On LostFocus
description: Learn how to control what happens if the focus of a grid element is lost when working with RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-cancel-edit-on-lost-focus
tags: cancel,edit,lost,focus,actiononlostfocus
published: True
position: 18
---

# Cancel Edit On LostFocus

The RadGridView control exposes an **ActionOnLostFocus** property which allows you to control what happens when the control loses the focus.

The ActionOnLostFocus enumeration has three possible values:

* **CancelEdit**: When the focus of a field in edit mode is lost, its edit mode will be canceled.
* **CommitEdit**: When the focus of a field in edit mode is lost, its contents will be validated.
* **None**: When the focus of an element is lost, no specific action will be taken.

The default value of the property is **CommitEdit** meaning that all changes will be commited when the control loses focus.

Let's say, for example, that you want to have two buttons outside of your RadGridView which are bound to the **CommitEdit** and **CancelRowEdit** commands.

__Example 1: Buttons Bound to RadGridView Commands__

```XAML
    <Button Content="Confirm" 
            Command="telerik:RadGridViewCommands.CommitEdit"
            CommandTarget="{Binding ElementName=GridView}"/>
	<Button Content="Cancel" 
            Command="telerik:RadGridViewCommands.CancelRowEdit"
            CommandTarget="{Binding ElementName=GridView}"/>
```

With the default behavior, once you edit a cell and click the "Cancel" button, the changes will be actually committed, because RadGridView loses focus prior to the command being executed.

#### __Figure 1: RadGridView with default ActionOnLostFocus__
![Telerik {{ site.framework_name }} DataGrid action-on-lost-focus-commitedit](images/action-on-lost-focus-commitedit.GIF)	

To overcome this, you can simply set the ActionOnLostFocus property to **None**.

__Example 2: Set ActionOnLostFocus to None__

```XAML
    <telerik:RadGridView ActionOnLostFocus="None" ...>
```

This way the "Cancel" button will work as expected as illustrated on **Figure 2**.

#### __Figure 2: RadGridView with ActionOnLostFocus set to None__
![Telerik {{ site.framework_name }} DataGrid action-on-lost-focus-none](images/action-on-lost-focus-none.GIF)

## See Also

* [Commands]({%slug gridview-commands-overview%})
* [Always focus the first cell on insert]({%slug gridview-how-to-focus-first-cell-insert%})
