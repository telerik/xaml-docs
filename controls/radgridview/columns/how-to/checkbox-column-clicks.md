---
title: Number of clicks in GridViewCheckBoxColumn
page_title: Number of Clicks in GridViewCheckBoxColumn - RadGridView
description: Configure one-click or two-click checkbox changes in Telerik UI for WPF RadGridView with edit triggers or an interactive cell template.
components: ["gridview"]
slug: gridview-checkbox-column-clicks
tags: number,of,clicks,checkbox,column
published: True
position: 2
---

# Number of clicks in the CheckBox column

The `GridViewCheckBoxColumn` in Progress® Telerik® UI for WPF supports different click behaviors through its edit settings.

With the default settings (`AutoSelectOnEdit="False"` and `EditTriggers="Default"`), changing a checkbox takes three clicks when the cell is not current. The first click makes the cell current, the second enters edit mode, and the third toggles the checkbox.

If the cell is already current, the first click enters edit mode, so only two clicks are needed. The default edit triggers also include `F2` and text input.

## Configuring Checkbox Edit Behavior

Choose a combination of `GridViewCheckBoxColumn` settings for the required click behavior:

- For two clicks, set `EditTriggers="CellClick"` and keep `AutoSelectOnEdit="False"`. The first click enters edit mode, and the second toggles the checkbox.
- Alternatively, set `AutoSelectOnEdit="True"` and keep `EditTriggers="Default"`. From a cell that is not current, the first click makes it current. The second enters edit mode and toggles the checkbox.
- For one click, set both `EditTriggers="CellClick"` and `AutoSelectOnEdit="True"`. The cell enters edit mode and toggles the checkbox on the same click.

>important The `RadGridView` must have focus for the one-click edit behavior.

For details about when a cell enters edit mode, see [Editing Start Triggers]({%slug gridview-edittriggers%}).

Configure the column in XAML or in code-behind for auto-generated columns:

<snippet id='radgridview-columns-how-to-checkbox-column-clicks-1_clicks_solution-xaml' />

<snippet id='radgridview-columns-how-to-checkbox-column-clicks-1_clicks_solution-cs' />

<snippet id='radgridview-columns-how-to-checkbox-column-clicks-1_clicks_solution-vb' />

## Displaying an Interactive Checkbox in View Mode

Use the `CellTemplate` of a `GridViewDataColumn` to display a WPF `CheckBox` that changes the bound value without entering edit mode.

The following XAML column fragment belongs in an existing `RadGridView.Columns` collection. It assumes each row's data item exposes a writable `IsActive` boolean property. Declare `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"` on the containing XAML element, alongside the standard WPF presentation namespace:

```XAML
<telerik:GridViewDataColumn Header="Active" IsReadOnly="True">
    <telerik:GridViewDataColumn.CellTemplate>
        <DataTemplate>
            <CheckBox IsChecked="{Binding IsActive, Mode=TwoWay}" />
        </DataTemplate>
    </telerik:GridViewDataColumn.CellTemplate>
</telerik:GridViewDataColumn>
```

The `CheckBox` uses a two-way binding to `IsActive`, so one click changes the property. It appears enabled in view mode, unlike the checkbox in a `GridViewCheckBoxColumn` before the cell enters edit mode.

>note The column is read-only to prevent cell editing. The `CheckBox` still updates `IsActive` through its two-way binding.

## See Also

- [CheckBox Column]({%slug gridview-checkbox-column%})
- [Styling the CheckBoxColumn]({%slug gridview-columns-styling-checkboxcolumn%})
- [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})
