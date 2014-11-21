---
title: Styling the Merged Column Headers
page_title: Styling the Merged Column Headers
description: Styling the Merged Column Headers
slug: gridview-styling-merged-column-headers
tags: styling,the,merged,column,headers
published: True
position: 8
---

# Styling the Merged Column Headers


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

![gridview merged cells 5](images/gridview_merged_cells_5.png)