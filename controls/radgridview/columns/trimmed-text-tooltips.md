---
title: Trimmed Text Tooltips
page_title: Trimmed Text Tooltips
description: Trimmed Text Tooltips
slug: gridview-trimmed-text-tooltips
tags: trimmed,text,tooltips
published: True
position: 13
---

# Trimmed Text Tooltips

As of **R1 2017** through the new **ShowToolTipOnTrimmedText** property you can specify whether or not a tooltip should be shown when the text of a given cell exceeds its parent column's width. It can be set on both **RadGridView** and **column** level.

## Setting ShowToolTipOnTrimmedText

The ShowToolTipOnTrimmedText is applied to RadGridView's **GridViewHeaderCell**, **GridViewCell** and **GridViewFooterCell** elements. Setting it to **True** will result in a tooltip being showed if the cell's text is trimmed.

#### __[XAML] Example 1: Setting RadGridView's ShowToolTipOnTrimmedText__

{{region xaml-gridview-columns-trimmed-text-tooltips_1}}
	<telerik:RadGridView ShowToolTipOnTrimmedText="True" />
{{endregion}}

#### __[XAML] Example 2: Setting a column's ShowToolTipOnTrimmedText__

{{region xaml-gridview-columns-trimmed-text-tooltips_2}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" ShowToolTipOnTrimmedText="True" />
{{endregion}}

#### __Figure 1: Tooltips for trimmed text__ 

![Tooltips for trimmed text](images/trimmed-text-tooltips-1.png)

Setting the ShowToolTipOnTrimmedText of a column will show tooltips for trimmed text only for the given column. Setting the same property of a RadGridView instance will set the ShowToolTipOnTrimmedText for all of its columns.

>Additionally, when using the ShowToolTipOnTrimmedText property, the following scenarios should be taken into account:

>* If you set the ShowToolTipOnTrimmedText on both column and RadGridView level, the value set for the **column** will take precedence.
>* If you've specified [custom cell templates]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) for your columns, no tooltips will be displayed unless you **explicitly define them**.
>* Tooltips will be displayed in RadGridView's **footer** row only if the content of the footer is either a **string** or a **TextBlock**.
>* You should set **IsLightweightModeEnabled** for your [GridViewComboBoxColumns]({%slug radgridview-columns-column-types-combobox-column%}) in order to benefit from the tooltip functionality.
>* Tooltips for [merged cells]({%slug gridview-merged-cells%}) are not supported.

## See Also

 * [Column Headers]({%slug gridview-columns-column-headers%})

 * [Column Footers]({%slug gridview-columns-column-footers%})
 
 * [Column Groups]({%slug gridview-column-groups%})

 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})

 * [Resizing Columns]({%slug gridview-columns-resizing-columns%})