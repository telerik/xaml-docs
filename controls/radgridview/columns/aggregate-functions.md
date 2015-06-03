---
title: Aggregate Functions
page_title: Aggregate Functions
description: Aggregate Functions
slug: gridview-columns-aggregate-functions
tags: aggregate,functions
published: True
position: 1
---

# Aggregate Functions

Column footers can be used to display aggregated information on the data in the column via defining aggregate functions. The aggregate functions might be found in the __Telerik.Windows.Data__ assembly.

The available functions are:

* __AverageFunction__ – returns the average of the values in the column. 

* __CountFunction__ – returns the number of all items in the column 

* __FirstFunction__ – returns the first element in the column according to the current sorting. 

* __LastFunction__ – returns the last elements in the column according to the current sorting. 

* __MaxFunction__ – returns the Max of the values in the column. 

* __MinFunction__ – returns the Min of the values in the column. 

* __SumFunction__ – returns the Sum of all values in the column. 

>tipYou can also create your own custom functions similar to these by inheriting the __Telerik.Windows.Data.EnumerableAggregateFunction__ class.

>tipYou could also use a {% if site.site_name == 'WPF' %}[Generic AggregateFunction](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_data_aggregatefunction_2.htm){% endif %}{% if site.site_name == 'Silverlight' %}[Generic AggregateFunction](http://docs.telerik.com/devtools/silverlight/api/html/t_telerik_windows_data_aggregatefunction_2.htm){% endif %} to define some custom aggregate expressions. An example can be found [here](http://demos.telerik.com/silverlight/#GridView/CustomAggregates).

The footer cell displays the caption and the result of the selected aggregate function.

![](images/RadGridView_Aggregate_Functions.png)

To display an aggregate function for a certain column, just instantiate the function you need and add it to the __AggregateFunctions__ collection of that column.

#### [XAML] Example 1: Display an aggregate function for a certain column

{{region gridview-columns-aggregate-functions_1}}

	<telerik:GridViewDataColumn Header="ID"
                                DataMemberBinding="{Binding EmployeeID}"
                                UniqueName="ID">
		<telerik:GridViewDataColumn.AggregateFunctions>
			<telerik:CountFunction Caption="Count: " />
		</telerik:GridViewDataColumn.AggregateFunctions>
	</telerik:GridViewDataColumn>
{{endregion}}

#### [C#] Example 2: Add an aggregate function for a certain column

{{region gridview-columns-aggregate-functions_2}}

	CountFunction f = new CountFunction();
	((GridViewDataColumn)this.radGridView.Columns["ID"]).AggregateFunctions.Add(f);
{{endregion}}

#### [VB.NET] Example 2: Add an aggregate function for a certain column

{{region gridview-columns-aggregate-functions_3}}

	Dim f As New CountFunction()
	DirectCast(Me.radGridView.Columns("ID"), GridViewDataColumn).AggregateFunctions.Add(f)
{{endregion}}

![](images/RadGridView_Aggregate_Functions_010.png)

>You need to set the __ShowColumnFooters__ property of the RadGridView to true in order to display the aggregates.
            
>You need to set the __ShowGroupFooters__ property of the RadGridView to true in order to display the aggregates under Grouped rows.
            
>You need to set the __SourceField__ property of the AggregateFunctions to specify the field to use in calculating the result.
            
>We use System.Linq to generate a proper __Expression__ to do the calculation based on the aggregate function defined and the type of the bound data.
          
If a recalculation of the aggregates is needed, you may call the CalculateAggregates() method of the grid:

#### [C#] Example 3: Invoke CalculateAggregates() method

{{region gridview-columns-aggregate-functions_4}}

	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	   this.radGridView.CalculateAggregates();
	}
{{endregion}}

That way the column aggregates will be updated and the group aggregates will not be. Please check this [troubleshooting article]({%slug gridview-troubleshooting-aggregates-not-updated%}) on how to refresh them.
        

>tipAggregate functions can also be defined per groups. To find out more take a look at [Group Aggregates]({%slug gridview-grouping-aggregates%}).

# See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})

 * [Aggregates are not shown]({%slug gridview-troubleshooting-aggregates-not-shown%})

 * [Aggregates are not updated]({%slug gridview-troubleshooting-aggregates-not-updated%})
