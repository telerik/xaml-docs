---
title: Styling Merged Column Headers
page_title: Styling Merged Column Headers
description: Styling Merged Column Headers
slug: gridview-styling-merged-column-headers
tags: styling,merged,column,headers
published: True
position: 8
---

# Styling Merged Column Headers

You may achieve the desired result through defining two simple styles targeted at CommonHeaderPresenter and at CommonColumnHeader. The __CommonHeaderPresenter__ hosts all common column headers and the __CommonColumnHeader__ is responsible for a single common column header. 

For example:

#### __XAML__

{{region gridview-styling-merged-column-headers_1}}

	<App.Resources>
		<Style TargetType="telerik:CommonHeaderPresenter">
	            <Setter Property="Background" Value="Red"/>
	        </Style>
		<Style TargetType="telerik:CommonColumnHeader">
			<Setter Property="Background" Value="Red"/>
		</Style>
	</App.Resources>
{{endregion}}

This will result in a red background for the merged header cells.

>importantAs of version __Q2 2015 GridViewColumnGroupRow__ visual element was introduced. You need to also merge its XAML if using Custom Theme.

# See Also

 * [Styles and Templates Overview]({%slug gridview-stylines-and-templates-overview%})
 
 * [Column Groups]({%slug gridview-column-groups%}).
