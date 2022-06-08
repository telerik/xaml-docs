---
title: How to Change GridViewCell Highlighted Background Color
page_title: Modify the HighlightedBackground property of the GridViewCell element.
type: how-to
slug: kb-gridview-change-default-cell-highlight-background
position: 0
tags: highlighted background, cell background, cell
ticketid: 1560393
res_type: kb
---

## Environment
<table>
    <tbody>
        <tr>
			<td>Product Version</td>
			<td>2022.2.622</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to change the highlighted background color of a matched GridViewCell element when search as you type is applied.

## Solution

Create a new `Style` and set its `TargetType` property to `GridViewCell`. Then, add a new setter for the `HighlightedBackground` property and set it to the desired value.

#### __[XAML]__
{{region gridview-change-default-cell-highlight-background-0}}
    <!-- If you use NoXaml dlls set the BasedOn property of the Style: BasedOn="{StaticResource GridViewCellStyle}" -->
    <Style TargetType="telerik:GridViewCell">
        <Setter Property="HighlightedBackground" Value="Pink"/>
    </Style>
{{endregion}}

![Telerik {{ site.framework_name }} DataGrid search-panel-highlight-cell-background-color](images/gridview-change-default-cell-highlight-background.png)

## See Also  
* [Styling Search Panel]({%slug gridview-styling-search-panel%})