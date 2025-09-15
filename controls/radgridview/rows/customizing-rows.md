---
title: Customizing Rows
page_title: Customizing Rows
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to easily customize each of the row types by just assigning a style to it. 
slug: gridview-customizing-rows
tags: customizing,rows
published: True
position: 2
---

# Hiding the Row Indicator

By default the first cell of a row represents the row indicator area. The indicator appears when the row is set as current.

![Telerik {{ site.framework_name }} DataGrid CustomizingRows 1](images/RadGridView_CustomizingRows_1.png)

The row indicator visibility is controlled with the __RowIndicatorVisibility__ property of RadGridView.

__Example 1: Hiding the row indicator__  
```XAML
	<telerik:RadGridView RowIndicatorVisibility="Collapsed" />
```

![Telerik {{ site.framework_name }} DataGrid CustomizingRows 2](images/RadGridView_CustomizingRows_2.png)

## Changing Rows Height

To limit the height of the rows, set the __RowHeight__ property of RadGridView. The property affects the rows only if their content is measured with a height smaller or equal to the RowHeight value. Otherwise, the measured size takes precedence.

__Example 2: Setting RowHeight__  
```XAML
	<telerik:RadGridView RowHeight="50" />
```

Additionally, the rows content size can be limited via the __MinHeight__ and __MaxHeight__ properties of the GridViewRow control. To set those, you can use the __RowStyle__ property of RadGridView.

__Example 3: Setting row's MaxHeight__  
```XAML
	<telerik:RadGridView>
		<telerik:RadGridView.RowStyle>
			<!-- If you use NoXaml dlls set the BasedOn property of the Style: BasedOn="{StaticResource GridViewRowStyle}" -->
			<Style TargetType="telerik:GridViewRow">
				<Setter Property="MaxHeight" Value="36" />
			</Style>
		</telerik:RadGridView.RowStyle>
	</telerik:RadGridView>
```

RadGridView allows you to easily customize each of the row types by just assigning a style to it. 

## Styling Row and Alternating Row

To style rows or alternating rows you can use the __RowStyle__ or the __AlternateRowStyle__ properties. To learn how to do this take a look at the [Styling Rows]({%slug gridview-styling-a-row%}) topic.

## Styling the Group Row

To style the group row you can use the __GroupRowStyle__ property. To learn how to do this take a look at the [Styling Group Row]({%slug gridview-styling-group-row%}) topic.

## Styling the Header Row

To style the header row you can use the __HeaderRowStyle__ property. To learn how to do this take a look at the [Styling Header Row]({%slug gridview-styling-header-row%}) topic.

## See Also

 * [Grid Rows - Overview]({%slug gridview-rows-overview%})

 * [Adding Rows]({%slug gridview-rows-adding-rows%})
 
 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
