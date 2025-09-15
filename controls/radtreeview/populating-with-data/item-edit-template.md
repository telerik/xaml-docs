---
title: ItemEditTemplate
page_title: ItemEditTemplate
description: Check our &quot;ItemEditTemplate&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-item-edit-template
tags: itemedittemplate
published: True
position: 10
---

# ItemEditTemplate

Telerik __RadTreeView__ supports defining a DataTemplate that controls how the items can be edited through the __ItemEditTemplate__. This tutorial will walk you through the common task of creating and applying an __ItemEditTemplate__.

> The definition of the __RadTreeViewSampleData__ class is the same as in the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) article. 

## Defining a RadTreeView and an ItemEditTemplate

__Example 1__ demonstrates how to define a RadTreeView in xaml and setup a DataTemplate that will be used for editing the items. This DataTemplate is displayed when an item enters edit mode (for example after pressing the __F2__ key).

{% if site.site_name == 'Silverlight' %}
__Example 1: Defining the ItemEditTemplate__
```XAML

	<Grid>
        <Grid.Resources>
            <sampleData:RadTreeViewSampleData x:Key="DataSource" />

            <DataTemplate x:Key="Team">
                <TextBlock Text="{Binding Name}" />
            </DataTemplate>
            <telerik:HierarchicalDataTemplate x:Key="Division"
                                      ItemTemplate="{StaticResource Team}"
                                      ItemsSource="{Binding Teams}">
                <TextBlock Text="{Binding Name}" />
            </telerik:HierarchicalDataTemplate>
            <telerik:HierarchicalDataTemplate x:Key="League"
                                      ItemTemplate="{StaticResource Division}"
                                      ItemsSource="{Binding Divisions}">
                <TextBlock Text="{Binding Name}" />
            </telerik:HierarchicalDataTemplate>

            <DataTemplate x:Key="LeagueItemEditTemplate">
                <Grid>
                    <StackPanel Orientation="Horizontal">
                        <TextBox Text="{Binding Name, Mode=TwoWay}"/>
                        <TextBlock Margin="5 0 0 0" Text="{Binding Items.Count, RelativeSource={RelativeSource AncestorType=telerik:RadTreeViewItem}, Mode=OneWay, StringFormat={}{0} children}"/>
                    </StackPanel>
                </Grid>
            </DataTemplate>
        </Grid.Resources>
        <telerik:RadTreeView x:Name="radTreeView"
	   IsEditable="True"
	   ItemsSource="{Binding LeaguesDataSource, Source={StaticResource DataSource}}"
	   ItemTemplate="{StaticResource League}" Margin="8" 
	   ItemEditTemplate="{StaticResource LeagueItemEditTemplate}"/>
    </Grid>
```

{% endif %}
{% if site.site_name == 'WPF' %}
__Example 1: Defining the ItemEditTemplate__
```XAML

	<Grid>
        <Grid.Resources>
            <sampleData:RadTreeViewSampleData x:Key="DataSource" />

            <DataTemplate x:Key="Team">
                <TextBlock Text="{Binding Name}" />
            </DataTemplate>
            <HierarchicalDataTemplate x:Key="Division"
                                      ItemTemplate="{StaticResource Team}"
                                      ItemsSource="{Binding Teams}">
                <TextBlock Text="{Binding Name}" />
            </HierarchicalDataTemplate>
            <HierarchicalDataTemplate x:Key="League"
                                      ItemTemplate="{StaticResource Division}"
                                      ItemsSource="{Binding Divisions}">
                <TextBlock Text="{Binding Name}" />
            </HierarchicalDataTemplate>

            <DataTemplate x:Key="LeagueItemEditTemplate">
                <Grid>
                    <StackPanel Orientation="Horizontal">
                        <TextBox Text="{Binding Name, Mode=TwoWay}"/>
                        <TextBlock Margin="5 0 0 0" Text="{Binding Items.Count, RelativeSource={RelativeSource AncestorType=telerik:RadTreeViewItem}, Mode=OneWay, StringFormat={}{0} children}"/>
                    </StackPanel>
                </Grid>
            </DataTemplate>
        </Grid.Resources>
        <telerik:RadTreeView x:Name="radTreeView"
	   IsEditable="True"
	   ItemsSource="{Binding LeaguesDataSource, Source={StaticResource DataSource}}"
	   ItemTemplate="{StaticResource League}" Margin="8" 
	   ItemEditTemplate="{StaticResource LeagueItemEditTemplate}"/>
    </Grid>
```
{% endif %}

{% if site.site_name == 'WPF' %}
#### __Figure 1: Result from Example 1 in the Fluent theme__
![RadTreeView in edit mode](images/RadTreeView_TemplatingItemEditTemplate_070.PNG)
{% endif %}

>Don't forget to set the __IsEditable__ property of your __RadTreeView__ to __True__.

## See Also
 * [ItemEditTemplateSelector]({%slug radtreeview-populating-with-data-item-edit-template-selector%})
 * [ItemTemplate]({%slug radtreeview-populating-with-data-item-template%})
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})