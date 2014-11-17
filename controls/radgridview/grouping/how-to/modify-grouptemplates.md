---
title: Modify the GroupRow
page_title: Modify the GroupRow
description: Modify the GroupRow
slug: gridview-grouping-how-to-modify-grouptemplates
tags: modify,the,grouprow
published: True
position: 1
---

# Modify the GroupRow

This article explains how you can modify the default GroupRow's header and footer templates per RadGridView's level or per GridViewColumn's level.

Basically you can change the GroupRow Headers by predefining the GroupHeaderTemplate and you can change the Group Footers by predefining the GroupFooterTemplate. That way you can set a DataTemplate as per your preferences or reqirements.

>tipFor a reference on the visual structure of the GridView you can follow [this article.]({%slug gridview-visual-structure%})

Please note that the DataContext of the group row is
{% if site.site_name == 'WPF' %}[GroupViewModel](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_gridview_groupviewmodel.html){% endif %}{% if site.site_name == 'Silverlight' %}[GroupViewModel](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_gridview_groupviewmodel.html){% endif %}. As you can check in the API reference, this class contains properties like Group, Column, AggregateResults, etc. Having this in mind you can bind the TextBlock-s in the GroupHeaderTemplate to the values of the properties in the GroupViewModel.
        

Below you can find a sample code showing how to set a new GroupHeaderTemplate for the GridViewDataColumn:

#### __XAML__

{{region gridview-grouping-how-to-modify-grouptemplates_0}}
	<telerik:GridViewDataColumn.GroupHeaderTemplate>
	    <DataTemplate>
	        <StackPanel>
	            <TextBlock Foreground="#FFED7971"
	                 Text="Test Key" />
	            <TextBlock Foreground="#FFED7971"
	                 Text="{Binding Group.Key}" />
	        </StackPanel>
	    </DataTemplate>
	 </telerik:GridViewDataColumn.GroupHeaderTemplate>
{{endregion}}

You could do the same for all the columns by defining a GroupHeaderTemplate for the RadGridView:

#### __XAML__

{{region gridview-grouping-how-to-modify-grouptemplates_1}}
	<telerik:RadGridView.GroupHeaderTemplate>
	    <DataTemplate>
	        <StackPanel>
	            <TextBlock Foreground="#FFED7971"
	                 Text="Test Key" />
	            <TextBlock Foreground="#FFED7971"
	                 Text="{Binding Group.Key}" />
	        </StackPanel>
	    </DataTemplate>
	 </telerik:RadGridView.GroupHeaderTemplate>
{{endregion}}


Note that if you have any AggregateFunctions defined, and you do not want the default aggregate reasults to show after predefining the GroupHeaderTemplate, you will have to hide them. You can achieve this, like so:

#### __XAML__

{{region gridview-grouping-how-to-modify-grouptemplates_2}}
	<Style TargetType="telerik:GridViewGroupRow">
	   <Setter Property="ShowHeaderAggregates" Value="False"/>
	</Style>
{{endregion}}

The same logic applies for the group footers and the GroupFooterTemplate.

>For styling the appearance of the GroupRow via editing the template of the GridViewGroupRow, please follow this [this article.]({%slug gridview-styling-group-row%})
