---
title: How to Expand and Collapse Items in an MVVM Manner
description: An article explaining how to expand and collapse items via the control's public API.
type: how-to
page_title: Expand and Collapse Items with TreeListView's Public Methods
slug: kb-treelistview-expand-collapse-items-through-methods
position: 0
tags: treeview, expand, collapse, methods, items, public, api
ticketid: 0
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.1.117</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadTreeListView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to expand and collapse items via the RadTreeListView control's public methods in an MVVM-friendly manner.

## Solution

Using the IsExpandedBinding mechanism of the RadTreeListView can bring some limitations related with the [UI virtualization]({%slug radgridview-features-ui-virtualization%}) to the forefront. When an item is outside the viewport, setting the IsExpanded properties is only reflected when a container for the item is created in some scenarios.

The public methods exposed by the control can be used in such scenarios to update the UI properly.

Here is how you can use the methods in an MVVM-friendly manner by creating appropriate **Action** properties:

__Define the required Actions__

```C#
    public class WarehouseViewModel : ViewModelBase
    {
        public Action ExpandAllAction { get; set; }
        public Action CollapseAllAction { get; set; }
        public Action<object> ExpandItemAction { get; set; }
        public Action<object> CollapseItemAction { get; set; }

        public WarehouseViewModel()
        {
        }

        // ...
    }
```

You can then set these actions as follows:

__Use the API of the TreeListView in the Actions__

```C#
	public MainWindow()
	{
		InitializeComponent();

		var viewModel = new WarehouseViewModel();
		viewModel.ExpandAllAction = () => { this.TreeListView.ExpandAllHierarchyItems(); };
		viewModel.CollapseAllAction = () => { this.TreeListView.CollapseAllHierarchyItems(); };
		viewModel.ExpandItemAction = (item) => { this.TreeListView.ExpandHierarchyItem(item); };
		viewModel.CollapseItemAction = (item) => { this.TreeListView.CollapseHierarchyItem(item); };

		this.DataContext = viewModel;
	}
```

You can then expose an appropriate method to use inside your viewmodel and also bind it to a command if this is necessary:

__Invoke the ExpandItemAction and ExpandAllAction__

```C#
	public WarehouseViewModel()
	{
		this.ExpandItemCommand = new DelegateCommand(OnExpandItemCommandExecuted);
		this.ExpandAllItemsCommand = new DelegateCommand(OnExpandAllItemsCommandExecuted);
	}

	public void OnExpandItemCommandExecuted(object item)
	{
		(item as WarehouseItem).IsExpanded = true;
		this.ExpandItemAction(item);
	}

	public void OnExpandAllItemsCommandExecuted(object obj)
	{
		foreach (var item in this.WarehouseItems)
		{
			item.IsExpanded = true;
		}

		this.ExpandAllAction();
	}
```

The collapse actions can be bound in a similar manner.

## See Also
* [Expanding and Collapsing Items]({%slug radtreelsitview-how-to-control-expand-settings%})
* [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
