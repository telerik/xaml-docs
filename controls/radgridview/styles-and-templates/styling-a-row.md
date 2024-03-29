---
title: Styling Rows
page_title: Styling Rows
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to set the background of the selected row.
slug: gridview-styling-a-row
tags: styling,rows
published: True
position: 14
---

# Styling Rows

>tip Before reading this topic, you might find it useful to get familiar with the [Template Structure of the GridViewRow]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewrow).

{% if site.site_name == 'WPF' %}
> `RadGridView` supports setting the background color of the selected row, as well as setting the mouse-over color of the row. More information can be found in the [SelectedBackground and MouseOverBackground]({%slug radgridview-rows-selected-background%}) article.
{% endif %}

In this article we will discuss the following topics:

* [Targeting the GridViewRow Element](#targeting-the-gridviewrow-element)

* [Setting RadGridView's RowStyle and AlternateRowsStyle](#setting-radgridviews-rowstyle-and-alternaterowsstyle)

* [Setting RadGridView's RowStyleSelector and AlternateRowsStyleSelector](#setting-radgridviews-rowstyleselector-and-alternaterowsstyleselector)

#### __GridViewRow template structure__

![Telerik {{ site.framework_name }} DataGrid-row-template](images/gridview-row-template.png)

## Targeting the GridViewRow Element

In order to style all RadGridView rows of an application, you should create an appropriate style targeting the `GridViewRow` element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

> To learn how to modify the default `GridViewCell` style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Styling all rows of an application__
{{region xaml-gridview-styling-row-1}}
	<Style TargetType="telerik:GridViewRow">
	    <Setter Property="Background" Value="Red"/>
	    <Setter Property="Foreground" Value="White"/>
	</Style>
{{endregion}}

> If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewRowStyle__.

## Setting RadGridView's RowStyle and AlternateRowStyle

`RadGridView` exposes the `RowStyle` and `AlternateRowStyle` properties of type `Style`. `GridViewRow` elements can be styled by providing an appropriate style for each of these properties.

> In order to use the `AlternateRowStyle`, you should first set the `AlternationCount` property of your RadGridView. For example, if you want to alternate each second row, you have to set its value to 2.

#### __[XAML] Creating styles for the RowStyle and AlternativeRowStyle properties__
{{region xaml-gridview-styling-row-2}}
	<Application.Resources>
		 <!-- If you use NoXaml dlls set the BasedOn property of the Style: BasedOn="{StaticResource GridViewRowStyle}" -->
		<Style x:Key="GridViewRowStyle" TargetType="telerik:GridViewRow">
			<Setter Property="Background" Value="Red"/>
        	<Setter Property="Foreground" Value="White"/>
		</Style>
		 <!-- If you use NoXaml dlls set the BasedOn property of the Style: BasedOn="{StaticResource GridViewAlternateRowStyle}" -->
		<Style x:Key="GridViewAlternateRowStyle" TargetType="telerik:GridViewRow">
			<Setter Property="Background" Value="Blue"/>
            <Setter Property="Foreground" Value="White"/>
		</Style>
	</Application.Resources>
{{endregion}}

#### __[XAML] Applying styles to the RowStyle and AlternateRowStyle properties__
{{region xaml-gridview-styling-row-3}}
	<telerik:RadGridView RowStyle="{StaticResource GridViewRowStyle}"
			     AlternationCount="2"
			     AlternateRowStyle="{StaticResource GridViewAlternateRowStyle}" />
{{endregion}}

#### __RadGridView with styled rows__

![Telerik {{ site.framework_name }} DataGrid-styled-row-and-alternate-row](images/gridview-styled-row-and-alternaterow.png)

## Setting RadGridView's RowStyleSelector and AlternateRowsStyleSelector

You could also use RadGridView's `RowStyleSelector` and `AlternateRowsStyleSelector` properties to style rows differently based on a specific condition. More details about how this can be achieved can be found in the [RowStyleSelector article]({%slug gridview-rowstyleselector%}).

## See Also

 * [Alternating Rows]({%slug radgridview-rows-alternating-rows%})

 * [Styling the Row Details]({%slug gridview-styling-row-details%})

 * [Styling the Group Row]({%slug gridview-styling-group-row%})

 * [Styling the Header Row]({%slug gridview-styling-header-row%})
