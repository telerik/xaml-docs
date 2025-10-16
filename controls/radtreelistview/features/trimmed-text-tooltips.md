---
title: Trimmed Text Tooltips
page_title: Trimmed Text Tooltips
description: Check our &quot;Trimmed Text Tooltips&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-trimmed-text-tooltips
tags: trimmed,text,tooltips
published: True
position: 16
---

# Trimmed Text Tooltips

As of **R1 2017** through the new **ShowToolTipOnTrimmedText** property you can specify whether or not a tooltip should be shown when the text of a given cell exceeds its parent column's width. It can be set on both **RadTreeListView** and **column** level.

## Setting ShowToolTipOnTrimmedText

The ShowToolTipOnTrimmedText is applied to RadTreeListView's **GridViewHeaderCell**, **GridViewCell** and **GridViewFooterCell** elements. Setting it to **True** will result in a tooltip being showed if the cell's text is trimmed.

__Example 1: Setting RadTreeListView's ShowToolTipOnTrimmedText__

```XAML
	<telerik:RadTreeListView ShowToolTipOnTrimmedText="True" />
```

__Example 2: Setting a column's ShowToolTipOnTrimmedText__

```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" ShowToolTipOnTrimmedText="True" />
```

Setting the ShowToolTipOnTrimmedText of a column will show tooltips for trimmed text only for the given column. Setting the same property of a RadTreeListView instance will set the ShowToolTipOnTrimmedText for all of its columns.

>Additionally, when using the ShowToolTipOnTrimmedText property, the following scenarios should be taken into account:

>* If you set the ShowToolTipOnTrimmedText on both column and RadTreeListView level, the value set for the **column** will take precedence.
>* If you've specified [custom cell templates]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) for your columns, no tooltips will be displayed unless you **explicitly define them**.
>* Tooltips will be displayed in RadTreeListView's **footer** row only if the content of the footer is either a **string** or a **TextBlock**.
>* You should set **IsLightweightModeEnabled** for your [GridViewComboBoxColumns]({%slug radgridview-columns-column-types-combobox-column%}) in order to benefit from the tooltip functionality.
{% if site.site_name == 'WPF' %}>* Tooltips for [merged cells]({%slug gridview-merged-cells%}) are not supported.{% endif %}

## See Also

 * [Connecting Lines]({%slug radtreelistview-features-treelines%})

 * [Column Footers]({%slug gridview-columns-column-footers%})