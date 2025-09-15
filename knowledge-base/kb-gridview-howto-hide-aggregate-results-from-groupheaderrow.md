---
title: How to Hide Some Aggregate Results From GroupHeaderRow
description: Filter Aggregate Results Displayed in GroupHeaderRow.
type: how-to
page_title: Remove Aggregate Results when RadGridView is grouped
slug: kb-gridview-howto-hide-aggregate-results-from-groupheaderrow
position: 0
ticketid: 1404936
tags: gridview, groupheaderrow, aggregateresults, filter, aggregateresultslist, hide
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF and Silverlight</td>
	</tr>
</table>

## Description

How to hide the aggregate results from the GroupHeaderRow when RadGridView is grouped, and [AggregateFunctions]({%slug gridview-columns-aggregate-functions%}) are defined.

## Solution

1. Handle the __Loaded__ event of the __AggregateResultsList__, which shows the aggregate results in the GroupHeaderRow, through an implicit style.

	
	```XAML
		<!--If the NoXaml binaries are used, the following style needs to be based on the default one, like so:-->
        <!--<Style TargetType="telerik:AggregateResultsList" BasedOn="{StaticResource AggregateResultsListStyle}">-->

        <Style TargetType="telerik:AggregateResultsList">
            <EventSetter Event="Loaded" Handler="AggregateResultsList_Loaded" />
        </Style>
	```

2. Obtain a reference to the __AggregateResultsList__ in the Loaded event and remove items from its ItemsSource. 

    
	```C#
		private void AggregateResultsList_Loaded(object sender, RoutedEventArgs e)
        {
            var aggregateResultsList = sender as Telerik.Windows.Controls.GridView.AggregateResultsList;
            var itemsSource = (aggregateResultsList.ItemsSource as Telerik.Windows.Data.AggregateResultCollection);
            if (itemsSource != null && itemsSource.Count > 1)
            {
                // You can introduce custom logic here to filter the aggregate results
                itemsSource.RemoveAt(itemsSource.Count - 1);
            }
        }
	```


## See Also

* [AggregateFunctions]({%slug gridview-columns-aggregate-functions%})
* [Group Aggregates]({%slug gridview-grouping-aggregates%})
