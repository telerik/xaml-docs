---
title: Column Footers
page_title: Column Footers
description: Column Footers
slug: gridview-columns-column-footers
tags: column,footers
published: True
position: 4
---

# Column Footers

Usually the bottom cell of a column is called footer. Its purpose is to display some additional information that applies to the whole column.

![](images/RadGridView_ColumnFooters_1.png)

To set the value of the footer use __Footer__ property of the column.

#### __XAML__

{{region xaml-gridview-columns-column-footers_0}}
	<telerik:GridViewDataColumn Header="ID"
	                DataMemberBinding="{Binding EmployeeID}"
	                Footer="Footer cell" />
{{endregion}}


Because it is of type object, you are not limited to just using plain text. For example, you can add a corresponding picture to the footer text.

#### __XAML__

{{region xaml-gridview-columns-column-footers_1}}
	<telerik:GridViewDataColumn Header="ID"
	                DataMemberBinding="{Binding EmployeeID}">
	  <telerik:GridViewDataColumn.Footer>
	
	    <Grid>
	      <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="Auto" />
	        <ColumnDefinition />
	      </Grid.ColumnDefinitions>
	      <Image Stretch="None"
	Source="../../Images/User.png"
	Margin="0,0,5,0" />
	      <TextBlock Text="The Id of the employee"
	 VerticalAlignment="Center"
	 TextWrapping="Wrap"
	 Grid.Column="1" />
	
	    </Grid>
	  </telerik:GridViewDataColumn.Footer>
	</telerik:GridViewDataColumn>
{{endregion}}

![](images/RadGridView_ColumnFooters_2.png)

## Showing the Column Footers

By default column footers are hidden, so in order to make them visible you have to set the __ShowColumnFooters__ property to __True__.

#### __XAML__
{{region xaml-gridview-columns-column-footers_2}}
	<telerik:RadGridView x:Name="radGridView"
	                         ShowColumnFooters="True">
	  <!-- ... -->
	</telerik:RadGridView>
{{endregion}}

## Aggregates

Column footers are also used to display aggregated information on the data displayed in the column via aggregate functions.

![](images/RadGridView_ColumnFooters_3.png)

To learn how to do that take a look at the [Aggregate Functions]({%slug gridview-columns-aggregate-functions%}) topic.

# See Also

 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})

 * [Resizing Columns]({%slug gridview-columns-resizing-columns%})

 * [Reordering Columns]({%slug gridview-columns-reordering-columns%})
