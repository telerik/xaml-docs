---
title: Modify GroupRow
page_title: Modify GroupRow
description: Learn how you can modify the default GroupRow's header and footer templates in Telerik's {{ site.framework_name }} DataGrid either on grid or column level.
slug: gridview-grouping-how-to-modify-grouptemplates
tags: modify,grouprow
published: True
position: 1
---

# Modify GroupRow

This article explains how you can modify the default header and footer templates of the group row. You can do that by predefining the __GroupHeaderTemplate__ and __GroupFooterTemplate__ properties. 

>tipLearn more about the GridView visual structure in [this article]({%slug gridview-visual-structure%}).

>Please note that the DataContext of the group row is {% if site.site_name == 'WPF' %}[GroupViewModel](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.gridview.groupviewmodel){% endif %}{% if site.site_name == 'Silverlight' %}[GroupViewModel](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.controls.gridview.groupviewmodel){% endif %}. As you can check in the API reference, this class contains properties like Group, Column, AggregateResults, etc. Having this in mind you can bind the TextBlock-s in the GroupHeaderTemplate to the values of the properties in the GroupViewModel.
        
## Overriding GroupHeaderTemplate

__Example 1__ demonstrates how to set the __GroupHeaderTemplate__ for a GridViewDataColumn.

#### __[XAML] Example 1: Setting the GridViewDataColumn GroupHeaderTemplate__
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

You could do the same for all the columns by defining a __GroupHeaderTemplate__ for the RadGridView.

#### __[XAML] Example 2: Setting the RadGridView GroupHeaderTemplate __
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

If you have any AggregateFunctions defined and you do not want the default aggregate reasults to show after predefining the GroupHeaderTemplate, you can hide them as demonstrated in __Example 3__.

#### __[XAML] Example 3: Hiding the aggregates in the group row__
{{region xaml-gridview-grouping-how-to-modify-grouptemplates_2}}
	<!--If you are using the NoXaml binaries, you should based the style on the default one like so-->
	<!-- <Style TargetType="telerik:GroupHeaderRow" BasedOn="{StaticResource GroupHeaderRowStyle}">-->
	<Style TargetType="telerik:GroupHeaderRow">
		<Setter Property="ShowHeaderAggregates" Value="False" />
	</Style>
{{endregion}}

>The __GroupHeaderRow__ control is the default grouping visual element when the __GroupRenderMode__ of the RadGridView is set to __Flat__. You can learn more about this in the [Grouping Modes]({%slug gridview-grouping-groupingmodes%}) article.

## Overriding GroupFooterTemplate

You can override the visual representation of the group footers by setting the __GroupFooterTemplate__ of the GridViewDataColumn.

#### __[XAML] Example 4: Setting the GridViewDataColumn GroupFooterTemplate__
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

>tip You can check the implementation of {% if site.site_name == 'Silverlight' %}the [Totals demo](https://demos.telerik.com/silverlight/#GridView/Totals){% endif %}{% if site.site_name == 'WPF' %}__Totals__ RadGridView example from the [WPF Demos](https://demos.telerik.com/wpf/){% endif %}.   

>If you want to style the GroupHeaderRow further, you can check out [this article]({%slug gridview-styling-group-row%}).