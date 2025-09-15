---
title: Modifying Group Row
page_title: Modifying Group Row
description: Learn how you can modify the default GroupRow's header and footer templates in Telerik's {{ site.framework_name }} DataGrid either on grid or column level.
slug: gridview-grouping-how-to-modify-grouptemplates
tags: modify,grouprow
published: True
position: 8
---

# Modifying Group Row

This article explains how you can modify the default header and footer templates of the group row. You can do that by predefining the `GroupHeaderTemplate` and `GroupFooterTemplate` properties. 

>tipLearn more about the GridView visual structure in [this article]({%slug gridview-visual-structure%}).

>Please note that the DataContext of the group row is {% if site.site_name == 'WPF' %}[GroupViewModel](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.gridview.groupviewmodel){% endif %}{% if site.site_name == 'Silverlight' %}[GroupViewModel](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.controls.gridview.groupviewmodel){% endif %}. As you can check in the API reference, this class contains properties like Group, Column, AggregateResults, etc. Having this in mind you can bind the TextBlock-s in the GroupHeaderTemplate to the values of the properties in the GroupViewModel.
        
## Overriding GroupHeaderTemplate

The following examples demonstrates how to set the `GroupHeaderTemplate` for a `GridViewDataColumn`.

__Setting the GridViewDataColumn GroupHeaderTemplate__
```XAML
	<telerik:GridViewDataColumn.GroupHeaderTemplate>
	    <DataTemplate>
	        <StackPanel>
	            <TextBlock Foreground="#FFED7971" Text="Test Key" />
	            <TextBlock Foreground="#FFED7971" Text="{Binding Column.Header}" />
	            <TextBlock Foreground="#FFED7971" Text="{Binding Group.Key}" />
	        </StackPanel>
	    </DataTemplate>
	</telerik:GridViewDataColumn.GroupHeaderTemplate>
```

You could do the same for all the columns by defining a `GroupHeaderTemplate` for the `RadGridView`.

__Setting the RadGridView GroupHeaderTemplate__
```XAML
	<telerik:RadGridView.GroupHeaderTemplate>
	    <DataTemplate>
	        <StackPanel>
	            <TextBlock Foreground="#FFED7971" Text="Test Key" />
	     	    <TextBlock Foreground="#FFED7971" Text="{Binding Column.Header}" />
	            <TextBlock Foreground="#FFED7971" Text="{Binding Group.Key}" />
	        </StackPanel>
	    </DataTemplate>
	</telerik:RadGridView.GroupHeaderTemplate>
```

If you have any AggregateFunctions defined and you do not want the default aggregate reasults to show after predefining the GroupHeaderTemplate, you can hide them as demonstrated below.

__Hiding the aggregates in the group row__
```XAML
	<!--If you are using the NoXaml binaries, you should based the style on the default one like so-->
	<!-- <Style TargetType="telerik:GroupHeaderRow" BasedOn="{StaticResource GroupHeaderRowStyle}">-->
	<Style TargetType="telerik:GroupHeaderRow">
		<Setter Property="ShowHeaderAggregates" Value="False" />
	</Style>
```

>The `GroupHeaderRow` element is the default grouping visual element when the `GroupRenderMode` of the `RadGridView` is set to __Flat__. You can learn more about this in the [Grouping Modes]({%slug gridview-grouping-groupingmodes%}) article.

## Overriding GroupFooterTemplate

You can override the visual representation of the group footers by setting the `GroupFooterTemplate` of the GridViewDataColumn.

__Setting the GridViewDataColumn GroupFooterTemplate__
```XAML
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
```

>tip You can check the implementation of {% if site.site_name == 'Silverlight' %}the [Totals demo](https://demos.telerik.com/silverlight/#GridView/Totals){% endif %}{% if site.site_name == 'WPF' %}__Totals__ RadGridView example from the [WPF Demos](https://demos.telerik.com/wpf/){% endif %}. 

## Setting Minimum Height on the Group Row

RadGridView exposes the `GroupHeaderRowMinHeight` property that allows you to specify the minimum height for the `GroupHeaderRow` element. This property will be taken into account only when the `GroupRenderMode` property of RadGridView is set to __Flat__.

__Setting the GroupHeaderRowMinHeight property__
```XAML
	<telerik:RadGridView GroupHeaderRowMinHeight="20"/>
```

>If you want to style the GroupHeaderRow further, you can check out [this article]({%slug gridview-styling-group-row%}).
