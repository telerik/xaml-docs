---
title: Column Footers
page_title: Column Footers
description: See examples of setting value and adding a corresponding picture to the column's footer in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-columns-column-footers
tags: column,footers
published: True
position: 4
---

# Column Footers

RadGridView allows you to display additional information which applies to the columns in a specific row placed at the bottom of the control. This row consists of individual footer cells for each column.

By default, column footers are hidden and in order to make them visible you have to set the __ShowColumnFooters__ property to __True__.

#### __[XAML] Example 1: __
{{region xaml-gridview-columns-column-footers_1}}
	<telerik:RadGridView ShowColumnFooters="True">
	  <!-- ... -->
	</telerik:RadGridView>
{{endregion}}

To set the value of the footer cells, you can use the __Footer__ property of the columns.

#### __[XAML] Example 2: __

{{region xaml-gridview-columns-column-footers_2}}
	<telerik:GridViewDataColumn Header="ID" DataMemberBinding="{Binding EmployeeID}" Footer="Footer cell" />
{{endregion}}

#### Figure 1: RadGridView with footer cells

![Telerik {{ site.framework_name }} DataGrid Column Footers 1](images/RadGridView_ColumnFooters_1.png)

Because it is of type object, you are not limited to just using plain text. For example, you can add a corresponding picture to the footer text.

#### __[XAML] Example 3: Adding an image to the footer content__

{{region xaml-gridview-columns-column-footers_1}}
	<telerik:GridViewDataColumn Header="ID" DataMemberBinding="{Binding EmployeeID}">
	  	<telerik:GridViewDataColumn.Footer>
			<Grid>
				<Grid.ColumnDefinitions>
					<ColumnDefinition Width="Auto" />
					<ColumnDefinition />
				</Grid.ColumnDefinitions>
				<Image Stretch="None" Source="../../Images/User.png" Margin="0,0,5,0" />
				<TextBlock Text="The Id of the employee" VerticalAlignment="Center" TextWrapping="Wrap" Grid.Column="1" />
			</Grid>
	  	</telerik:GridViewDataColumn.Footer>
	</telerik:GridViewDataColumn>
{{endregion}}

#### Figure 2: Image in the footer cell

![Telerik {{ site.framework_name }} DataGrid Column Footers 2](images/RadGridView_ColumnFooters_2.png)

## Aggregates

Column footers are also used to display aggregated information on the data displayed in the column via aggregate functions.

#### __[XAML] Example 4: Adding an aggregate function to a column__

{{region xaml-gridview-columns-column-footers_1}}
	<telerik:GridViewDataColumn Header="ID" DataMemberBinding="{Binding EmployeeID}"> 
		<telerik:GridViewDataColumn.AggregateFunctions> 
			<telerik:CountFunction Caption="Count:	" /> 
		</telerik:GridViewDataColumn.AggregateFunctions> 
	</telerik:GridViewDataColumn>
{{endregion}}

#### Figure 3: Footer cell with aggregate results

![Telerik {{ site.framework_name }} DataGrid Column Footers 3](images/RadGridView_ColumnFooters_3.png)

To learn more about aggregate functions please have a look at [this article]({%slug gridview-columns-aggregate-functions%}).

>important Please note that if the **Footer** property is explicitly defined, it will take precedence over the aggregate results.

## See Also

* [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
* [Resizing Columns]({%slug gridview-columns-resizing-columns%})
* [Reordering Columns]({%slug gridview-columns-reordering-columns%})