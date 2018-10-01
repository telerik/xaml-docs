---
title: Modify GroupRow
page_title: Modify GroupRow
description: Modify GroupRow
slug: gridview-grouping-how-to-modify-grouptemplates
tags: modify,grouprow
published: True
position: 1
---

# Modify GroupRow

This article explains how you can modify the default GroupRow's header and footer templates per RadGridView's level or per GridViewColumn's level.

Basically you can change the GroupRow Headers by predefining the GroupHeaderTemplate and you can change the Group Footers by predefining the GroupFooterTemplate. That way you can set a DataTemplate as per your preferences or reqirements.

>For visual modifications of the group row, you can refer to the documentation on [Styling GroupRow]({%slug gridview-visual-structure%}).

>tipFor a reference on the visual structure of the GridView you can follow [this article.]({%slug gridview-visual-structure%}).

>Please note that the DataContext of the group row is {% if site.site_name == 'WPF' %}[GroupViewModel](https://docs.telerik.com/devtools/wpf/controls/radgridview/grouping/how-to/modify-grouptemplates.html){% endif %}{% if site.site_name == 'Silverlight' %}[GroupViewModel](https://docs.telerik.com/devtools/silverlight/api/html/T_Telerik_Windows_Controls_GridView_GroupViewModel.htm){% endif %}. As you can check in the API reference, this class contains properties like Group, Column, AggregateResults, etc. Having this in mind you can bind the TextBlock-s in the GroupHeaderTemplate to the values of the properties in the GroupViewModel.
        
## Overriding GroupHeaderTemplate

Below you can find a sample code showing how to set a new __GroupHeaderTemplate for the GridViewDataColumn__:

#### __XAML__
{{region xaml-gridview-grouping-how-to-modify-grouptemplates_0}}
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

You could do the same for all the columns by defining a __GroupHeaderTemplate for the RadGridView__:

#### __XAML__
{{region xaml-gridview-grouping-how-to-modify-grouptemplates_1}}
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
{{region xaml-gridview-grouping-how-to-modify-grouptemplates_2}}
	<Style TargetType="telerik:GridViewGroupRow">
	    <Setter Property="ShowHeaderAggregates" Value="False"/>
	</Style>
{{endregion}}

>As of __Q3 2012__ we have introduced a new rendering mode of RadGridView - Flat. When you set the Flat mode, the GridView will render rows one below the other. You can also refer to the [Grouping Modes]({%slug gridview-grouping-groupingmodes%}) article.

## Overriding GroupFooterTemplate

A similar logic applies for the group footers and __GroupFooterTemplate__. For example, you can define such per column with the following sample DataTemplate:

#### __XAML__
{{region xaml-gridview-grouping-how-to-modify-grouptemplates_3}}
    <telerik:GridViewDataColumn.GroupFooterTemplate>
       <DataTemplate>
          <telerik:AggregateResultsList ItemsSource="{Binding}">
              <ItemsControl.ItemTemplate>
                  <DataTemplate>
                      <StackPanel Orientation="Horizontal"
              VerticalAlignment="Center" >
                          <TextBlock VerticalAlignment="Center" Text="{Binding Caption}" />
                          <TextBlock VerticalAlignment="Center" Text="{Binding FormattedValue, StringFormat=' {0:hh\\:mm}'}" />
                      </StackPanel>
                  </DataTemplate>
              </ItemsControl.ItemTemplate>
          </telerik:AggregateResultsList>
      </DataTemplate>
    </telerik:GridViewDataColumn.GroupFooterTemplate>
{{endregion}}

>tip You can also check the implementation of {% if site.site_name == 'Silverlight' %} [Totals demo](https://demos.telerik.com/silverlight/#GridView/Totals){% endif %}{% if site.site_name == 'WPF' %} __Totals__ [WPF Demos](https://demos.telerik.com/wpf/#GridView/Totals){% endif %}.   

>For styling the appearance of the GroupRow via editing the template of the GridViewGroupRow, please follow this [this article.]({%slug gridview-styling-group-row%})
