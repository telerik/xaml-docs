---
title: Column Resizing
page_title: Column Resizing
description: This article describes how users can change the widths of the columns in the RadPivotGrid control via the CanUserResizeColumns property.
slug: radpivotgrid-features-column-resizing
tags: column,resizing
published: True
position: 12
---

# Column Resizing 

As of **R1 2019**, the **RadPivotGrid** control allows users to resize its columns. The user can easily change the column width by positioning the mouse over the column's vertical grid line and dragging it until the desired size is achieved.

## Enable Column Resizing

This functionality can be enabled by setting the **CanUserResizeColumns** property to **True**. Note that the property's default value is **False**, i.e., column resizing is disabled by default.

__Example 1: Enable column resizing in XAML__

```XAML
    <pivot:RadPivotGrid x:Name="pivotGrid" CanUserResizeColumns="True" ... />
```

__Example 2: Enable column resizing in code-behind__

```C#
    this.pivotGrid.CanUserResizeColumns = true;
```
```VB.NET
    Me.pivotGrid.CanUserResizeColumns = True
```

{% figure 1, "Resizing RadPivotGrid's columns", "column-resizing.gif" %}

As can be observed in **Figure 1**, when the content of a header is wider than that of its parent column, it will be trimmed and continued with an ellipsis at the character closest to the trimming edge. Double-clicking the column divider will in turn resize the column to autofit the content.

## Limit Columns Width

The control now also exposes two new properties to control the width of the resized columns - **MinimumResizeWidth** and **MaximumResizeWidth**. Their default values are **20** and **double.PositiveInfinity**, respectively. As their names suggest, these properties limit the minimum and maximum width that can be set for a column when resizing it.

__Example 3: Set minimum and maximum resize width in XAML__

```XAML
    <pivot:RadPivotGrid x:Name="pivotGrid" CanUserResizeColumns="True"
                        MinimumResizeWidth="50" MaximumResizeWidth="150" ... />
```

__Example 4: Set minimum and maximum resize width in code-behind__

```C#
    this.pivotGrid.MinimumResizeWidth = 50;
    this.pivotGrid.MaximumResizeWidth = 150;
```
```VB.NET
    Me.pivotGrid.MinimumResizeWidth = 50
	Me.pivotGrid.MaximumResizeWidth = 150
```

## See Also

* [Layouts]({%slug radpivotgrid-features-layouts%})
{% if site.framework_name == 'WPF' %}* [Selection]({%slug radpivotgrid-features-selection%}){% endif %}
