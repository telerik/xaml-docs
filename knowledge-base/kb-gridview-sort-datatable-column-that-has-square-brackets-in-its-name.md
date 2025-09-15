---
title: Sort а DataTable Column That Contains Square Brackets in its Name in a RadGridView Scenario
page_title: Sorting DataTable Column That Has Square Bracket Characters in its Name
description: This article shows how to sort a DataTable column that contains square brackets in its name when the DataTable is used with RadGridView.
type: how-to
slug: kb-gridview-sort-datatable-column-that-has-square-brackets-in-its-name
position: 0
tags: gridview, datatable, square bracket, sort
ticketid: 1584470
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.912</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The default sorting logic of RadGridView cannot sort a column that is bound to a DataTable column, which has square brackets in its name.

## Solution

To achieve a sorting functionality in this scenario, implement custom sorting logic using the [Sorting]({%slug gridview-sorting-custom%}#custom-sorting-handling-sorting-event) event of the `RadGridView` control.

1. Subscribe to the Sorting event:

    
    ```XAML
        <telerik:RadGridView Sorting="OnRadGridViewSorting"/>
    ```

2. Retrieve the `DataView` of the DataTable instance that is bound to the `ItemsSource` property of RadGridView. Then, check if the `e.Column` property contains the column that is bound to the DataTable column with square brackets in its name:

    __Handling the Sorting event__
    ```C#
        private void OnRadGridViewSorting(object sender, Telerik.Windows.Controls.GridViewSortingEventArgs e)
        {
            var items = e.DataControl.ItemsSource as DataView;

            if (e.Column.UniqueName.Contains("MyColumnWithSquareBrackets"))
            {

            }
        }
    ```

3. Utilize the `Sort` property of the retrieved `DataView` to sort the DataTable column in the direction of the new sorting state. The square brackets of the column will have to be escaped when using the Sort property:

    __Setting the Sort property of the DataView__
    ```C#
        private void OnRadGridViewSorting(object sender, Telerik.Windows.Controls.GridViewSortingEventArgs e)
        {
            var items = e.DataControl.ItemsSource as DataView;

            if (e.Column.UniqueName.Contains("MyColumnWithSquareBrackets"))
            {
                if (e.NewSortingState == Telerik.Windows.Controls.SortingState.Ascending)
                {
                    items.Sort = @"[[MyColumnWithSquareBrackets]]";
                }
                else if (e.NewSortingState == Telerik.Windows.Controls.SortingState.Descending)
                {
                    items.Sort = "[[MyColumnWithSquareBrackets]] desc";
                }
                else
                {
                    items.Sort = "[[MyColumnWithSquareBrackets]]";
                }
            }
        }
    ```

4. Set the `SortingState` property of the sorted column to the new sorting direction. Then, to prevent the default sorting logic of RadGridView from occurring, set the `e.Cancel` property to __true__:

    __The complete implementation of the custom sorting logic__
    ```C#
        private void OnRadGridViewSorting(object sender, Telerik.Windows.Controls.GridViewSortingEventArgs e)
        {
            var items = e.DataControl.ItemsSource as DataView;
    
            if (e.Column.UniqueName.Contains("MyColumnWithSquareBrackets"))
            {
                if (e.NewSortingState == Telerik.Windows.Controls.SortingState.Ascending)
                {
                    items.Sort = @"[[MyColumnWithSquareBrackets]]";
                }
                else if (e.NewSortingState == Telerik.Windows.Controls.SortingState.Descending)
                {
                    items.Sort = "[[MyColumnWithSquareBrackets]] desc";
                }
                else
                {
                    items.Sort = "[[MyColumnWithSquareBrackets]]";
                }
            }
    
            e.Column.SortingState = e.NewSortingState;
            e.Cancel = true;
        }
    ```

>important The [IsCustomSortingEnabled]({%slug gridview-set-sortingstate-on-column%}) property of the column needes to be set to __true__, when implementing custom sorting logic.
