---
title: F2 Should not Select All Text in RadGridView Cell
description: Disable the text selection when a cell enters edit mode by pressing the F2 key.
type: how-to
page_title: Prevent F2 Key Text Selection When Cell is in Edit Mode
slug: kb-gridview-prevent-f2-text-selection
position: 0
tags: preparecellforedit,custom,column
ticketid: 1405699
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.1 415</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to disable the text selection when a cell enters edit mode by pressing the F2 key.

## Solution

1. Create a custom RadGridView column and override its `PrepareCellForEdit` method.
2. In the method override, get the editing element (TextBox) and manually set its `SelectionStart` property.


```C#
	public class CustomGridViewDataColumn : GridViewDataColumn
	{
		protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs)
		{
			var cell = base.PrepareCellForEdit(editingElement, editingEventArgs);
			var tb = editingElement as TextBox;
			if (tb != null && !(editingEventArgs is MouseButtonEventArgs))
			{
				tb.SelectionStart = tb.Text.Length;
			}
			return cell;
		}
	}
```


```XAML
	<telerik:RadGridView.Columns>
		<local:CustomGridViewDataColumn DataMemberBinding="{Binding Name}" />
	</telerik:RadGridView.Columns>
```

## See Also
* [Keyboard Support]({%slug gridview-overview-keyboard-support%})
* [Defining Columns]({%slug gridview-columns-defining-columns%})
* [Custom Column]({%slug gridview-how-to-create-custom-column-editor%})