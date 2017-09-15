---
title: Exception with Sum AggregateFuntion
page_title: Exception with Sum AggregateFuntion
description: Exception with Sum AggregateFuntion
slug: gridview-troubleshooting-sum-aggregate
tags: exception,with,sum,aggregatefuntion
published: True
position: 2
---

# Exception with Sum AggregateFuntion

__PROBLEM__

You declare an aggregate SumFunction for a column:

#### __XAML__

{{region xaml-gridview-troubleshooting-sum-aggregate_0}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}">
	    <telerik:GridViewDataColumn.AggregateFunctions>
	        <telerik:SumFunction/>
	    </telerik:GridViewDataColumn.AggregateFunctions>
	</telerik:GridViewDataColumn>
{{endregion}}

As a result, the following error occurs: No generic method 'Sum' on type 'System.Linq.Enumerable' is compatible with the supplied type arguments and arguments. No type arguments should be provided if the method is non-generic.
        
__CAUSE__

You can sum only __Numeric__ types.
        
__SOLUTION__

You can create a {% if site.site_name == 'WPF' %}[Generic AggregateFunction](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_data_aggregatefunction_2.htm){% endif %}{% if site.site_name == 'Silverlight' %}[Generic AggregateFunction](http://docs.telerik.com/devtools/silverlight/api/html/t_telerik_windows_data_aggregatefunction_2.htm){% endif %} instead and return the Sum of the values. 

You can also specify some custom aggregate expressions. Then add the defined function to the AggregateFunctions collection of GridViewDataColumn as illustrated in this [help topic]({%slug gridview-columns-aggregate-functions%}).
        
For example you can define a generic AggregateFunction which calculates the Sum of the Numbers for all the Players populated in RadGridView. You can refer to the sample code below:
        

#### __C#__

{{region cs-gridview-troubleshooting-sum-aggregate_1}}
	var aggregate = new AggregateFunction<Player, int>()
	{
	    AggregationExpression = players => players.Select(x => x.Number).Sum()
	};
	playersGrid.Columns[0].AggregateFunctions.Add(aggregate);
{{endregion}}

## See Also

* [Column Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
