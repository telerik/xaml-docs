---
title: Group Footers
page_title: Group Footers
description: Get started with the grouping functionality of Telerik's {{ site.framework_name }} DataGrid which that allows you to render a footer under each group in the grid.
slug: gridview-group-footers
tags: group,footers
published: True
position: 5
---

# Group Footers

__RadGridView__ exposes __group footers__ features which provide the option to render a footer under each group in the grid. Group footers display group summaries and contain footer cells that correspond to data columns.

This tutorial will walk you through the common tasks of:

* [Enabling the group footers functionality](#enable-group-footers-functionality)

* [Setting the group footers content](#set-the-group-footers-content)

* [Styling the group footers](#styling-group-footers)

* [Re-defining Group Aggregates](#re-defining-group-aggregates)

>Before continuing with this topic make sure that you are familiar with the [Visual Structure]({%slug gridview-visual-structure%}) of __RadGridView__.

For the purpose of this tutorial the following declaration will be used:


```XAML
	<telerik:RadGridView AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding EmployeeID}"
	                                Header="ID"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                Header="Name"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Title}"
	                                Header="Title"
	                                UniqueName="Title" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
```

## Enable Group Footers Functionality

In order to enable the group footers functionality, merely set __ShowGroupFooters__ property of __RadGridView__ to __True__.


```XAML
	<telerik:RadGridView ShowGroupFooters="True" />
```

![Telerik {{ site.framework_name }} DataGrid Grouping GroupFooters 010](images/RadGridView_Grouping_GroupFooters_010.png)

>The default value of __ShowGroupFooters__ property is __False__.

The same operation can be done in the code-behind.


```C#
	private void EnableGroupFooters()
	{
	    this.radGridView.ShowGroupFooters = true;
	}
```
```VB.NET
	Private Sub EnableGroupFooters()
	    Me.radGridView.ShowGroupFooters = True
	End Sub
```

## Set the Group Footers Content

* Using __GroupFootersTemplate__.

If you want your group footers to have a static content, simply configure __GroupFootersTemplate__ property.


```XAML
	<Grid.Resources>
	    <DataTemplate x:Key="GroupFooterTemplate">
	        <TextBlock Text="Hello"/>
	    </DataTemplate>
	</Grid.Resources>
	<Grid x:Name="LayoutRoot" Background="White">
	    <telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
	        <telerik:RadGridView.Columns>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding EmployeeID}" Header="ID"     GroupFooterTemplate="{StaticResource GroupFooterTemplate}"/>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Header="Name"/>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Title}" Header="Title" UniqueName="Title" />
	        </telerik:RadGridView.Columns>
	    </telerik:RadGridView>
	</Grid>
```

![Telerik {{ site.framework_name }} DataGrid Grouping GroupFooters 020](images/RadGridView_Grouping_GroupFooters_020.png)

* Using [Aggregate Functions]({%slug gridview-columns-aggregate-functions%}).

The group footers are most commonly used to visualize calculations from aggregate functions within the scope of the current group. Consider the following example:


```XAML
	<telerik:RadGridView AutoGenerateColumns="False" ShowGroupFooters="True">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding EmployeeID}" Header="ID">
	            <telerik:GridViewDataColumn.AggregateFunctions>
	                <telerik:CountFunction Caption="Total: "/>
	            </telerik:GridViewDataColumn.AggregateFunctions>
	        </telerik:GridViewDataColumn>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Header="Name"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Title}" Header="Title" UniqueName="Title" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
```

The result can be seen on the next image.

![Telerik {{ site.framework_name }} DataGrid Grouping GroupFooters 030](images/RadGridView_Grouping_GroupFooters_030.png)

>__RadGridView__ will calculate aggregates over the entire data source and will respect the filter expression applied (if present).

## Styling Group Footers

If you want to learn how to style group footers take a look at the [Styling Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%}) topic.

Check out the following topics which explain in great details __RadGridView__'s grouping functionality.

* Learn the [basic]({%slug gridview-grouping-basics%}) of the grouping behavior.

* Using group [aggregates]({%slug gridview-grouping-aggregates%}).

* [Implement]({%slug gridview-programmatic-grouping%}) programmatic grouping.

## Re-defining Group Aggregates

You can modify the default template of displaying group aggregates by applying a new __GroupFooterTemplate__ configured it per specific requirements.


```XAML
	<telerik:GridViewDataColumn.GroupFooterTemplate>
	    <DataTemplate>
	        <StackPanel Orientation="Vertical"
	                    Margin="0,10">
	            <TextBlock Text="Custom footer with aggregates:"
	                       Margin="0,0,0,2" />
	            <telerik:AggregateResultsList ItemsSource="{Binding}"
	                                          VerticalAlignment="Center"
	                                          Grid.Column="4">
	                <ItemsControl.ItemTemplate>
	                    <DataTemplate>
	                        <StackPanel Orientation="Horizontal"
	                                    VerticalAlignment="Center">
	                            <TextBlockVerticalAlignment="Center"
	                                       Text="{Binding Caption}" />
	                            <TextBlockVerticalAlignment="Center"
	                                       Text="{Binding FormattedValue}" />
	                        </StackPanel>
	                    </DataTemplate>
	                </ItemsControl.ItemTemplate>
	                <ItemsControl.ItemsPanel>
	                    <ItemsPanelTemplate>
	                        <StackPanel Orientation="Vertical" />
	                    </ItemsPanelTemplate>
	                </ItemsControl.ItemsPanel>
	            </telerik:AggregateResultsList>
	        </StackPanel>
	    </DataTemplate>
	</telerik:GridViewDataColumn.GroupFooterTemplate>
```

> The GroupFooter's DataContext is __AggregateResultsList__.

## See Also
 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
