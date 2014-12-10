---
title: Group Footers
page_title: Group Footers
description: Group Footers
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

>Before continuing with this topic make sure that you are familiar with the [Visual Structure]({%slug gridview-visual-structure%}) of the __RadGridView__.

For the purpose of this tutorial the following __RadGridView__ declaration will be used:

#### __XAML__

{{region gridview-group-footers_0}}

	<telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
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
{{endregion}}

## Enable Group Footers Functionality

In order to enable the group footers functionality, merely set the __ShowGroupFooters__ property of the __RadGridView__ to __True__.

#### __XAML__

{{region gridview-group-footers_1}}

	<telerik:RadGridView x:Name="radGridView" ShowGroupFooters="True">
{{endregion}}

![](images/RadGridView_Grouping_GroupFooters_010.png)

>The default value of the __ShowGroupFooters__ property is __False__.

The same operation can be done in the code-behind.

#### __C#__

{{region gridview-group-footers_2}}
	private void EnableGroupFooters()
	{
	    this.radGridView.ShowGroupFooters = true;
	}
{{endregion}}

#### __VB.NET__

{{region gridview-group-footers_3}}

	Private Sub EnableGroupFooters()
	    Me.radGridView.ShowGroupFooters = True
	End Sub
{{endregion}}

## Set the Group Footers Content

* Using the __GroupFootersTemplate__.

If you want your group footers to have a static content, simply set the __GroupFootersTemplate__ property.

#### __XAML__

{{region gridview-group-footers_4}}

	<UserControl.Resources>
	    <DataTemplate x:Key="GroupFooterTemplate">
	        <TextBlock Text="Hello"/>
	    </DataTemplate>
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Background="White">
	    <telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
	        <telerik:RadGridView.Columns>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding EmployeeID}" Header="ID"     GroupFooterTemplate="{StaticResource GroupFooterTemplate}"/>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Header="Name"/>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Title}" Header="Title" UniqueName="Title" />
	        </telerik:RadGridView.Columns>
	    </telerik:RadGridView>
	</Grid>
{{endregion}}


![](images/RadGridView_Grouping_GroupFooters_020.png)


* Using [Aggregate Functions]({%slug gridview-columns-aggregate-functions%}).

The group footers are most commonly used to visualize calculations from aggregate functions within the scope of the current group. Consider the following example.

#### __XAML__

{{region gridview-group-footers_5}}

	<telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False" ShowGroupFooters="True">
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
{{endregion}}

The result can be seen on the next image.

![](images/RadGridView_Grouping_GroupFooters_030.png)

>__RadGridView__ will calculate aggregates over the entire data source and will respect the filter expression applied (if present).

## Styling Group Footers

If you want to learn how to style group footers take a look at the [Styling Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%}) topic.


Check out the following topics which explain in great details the __RadGridView__'s grouping functionality.

* Learn the [basic]({%slug gridview-grouping-basics%}) of the grouping behavior.

* Using group [aggregates]({%slug gridview-grouping-aggregates%}).

* [Implement]({%slug gridview-programmatic-grouping%}) programmatic grouping.

# See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})

 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
