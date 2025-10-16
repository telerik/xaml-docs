---
title: Styling Header Row
page_title: Styling Header Row
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to style the HeaderRow element.
slug: gridview-styling-header-row
tags: styling,header,row
published: True
position: 13
---

# Styling Header Row

#### __Figure 1: GridViewHeaderRow template structure__

![Telerik {{ site.framework_name }} DataGrid-headerrow-template](images/gridview-headerrow-template.png)

## Targeting the GridViewHeaderRow Element

In order to style all __RadGridView__ header rows of an application, you should create an appropriate style targeting the __GridViewHeaderRow__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewHeaderRow style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

__Example 1: Styling all header rows of an application__

```XAML
	<Style TargetType="telerik:GridViewHeaderRow">
	    <Setter Property="Background" Value="Red"/>
	</Style>
```

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewHeaderRowStyle__.

## Setting RadGridView's HeaderRowStyle

__RadGridView's header row__ can also be styled by creating an appropriate __Style__ for the **GridViewHeaderRow**  element and setting it as the __HeaderRowStyle__ property.

__Example 2: Setting RadGridView's HeaderRowStyle__

```XAML
	<telerik:RadGridView HeaderRowStyle="{StaticResource HeaderRowStyle}" />
```

#### __Figure 1: RadGridView with styled header row__

![Telerik {{ site.framework_name }} DataGrid Styles and Templates Styling GridViewHeaderRow 03](images/RadGridView_Styles_and_Templates_Styling_GridViewHeaderRow_03.png)

>As you can see, the changes we made apply only for the row. The header cells remain unchanged. To learn how to style them, take a look at the [Styling Column Headers]({%slug gridview-styling-column-headers%}) topic.

## See Also

* [Styling Column Headers]({%slug gridview-styling-column-headers%})
* [Styling a Row]({%slug gridview-styling-a-row%})
* [Styling the Row Details]({%slug gridview-styling-row-details%})
* [Styling the Group Row]({%slug gridview-styling-group-row%})
