---
title: Drill Down
page_title: Drill Down
description: Drill Down
slug: radpivotgrid-features-localdatasourceprovider-drilldown
tags: culture,support
published: True
position: 10
---

# Drill Down

As of **R1 2017**, **LocalDataSourceProvider** exposes a **GetUnderlyingData** method that allows you to extract the records from your ItemsSource that were used for accumulating the result for a particular row and column. The GetUnderlyingData method takes two parameters: **Row Group** and **Column Group**.

#### __[XAML] Example 1: Calling GetUnderlyingData on Cell Double-Click__

{{region xaml-radpivotgrid-features-localdatasourceprovider-drilldown_1}}
	private void pivotGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount == 2)
        {
            var cellData = (e.OriginalSource as FrameworkElement).DataContext as CellData;
            if (cellData != null)
            {
                var cellAggregateValue = cellData.Data as CellAggregateValue;
                var localProvider = this.pivotGrid.DataProvider as LocalDataSourceProvider;
                localProvider.GetUnderlyingData(cellAggregateValue.RowGroup, cellAggregateValue.ColumnGroup);            
			}
        }
    }
{{endregion}}

Once RadPivotGrid has finished processing the underlying data, the newly-introduced **GetUnderlyingDataCompleted** event will be fired. Its **DrillDownCompletedEventArgs** have two properties:

* **Result**: An **IEnumerable** representing the result of the underlying data extraction operation.
* **InnerExceptions**: A **read-only** collection of any **exceptions** thrown during the underlying data extraction.

>If the **DeferUpdates** property of the LocalDataSourceProvider is set to **True**, calling the GetUnderlyingData method without first updating the provider will result in an **InvalidOperationException** which will be passed to the DrillDownCompletedEventArgs' InnerExceptions collection.

#### __[XAML] Example 2: The GetUnderlyingDataCompleted Event Handler__

{{region xaml-radpivotgrid-features-localdatasourceprovider-drilldown_1}}
	private void dataProvider_GetUnderlyingDataCompleted(object sender, DrillDownCompletedEventArgs e)
    {
        if (e.InnerExceptions.Count() == 0)
        {
            this.underlyingDataGridView.ItemsSource = e.Result;
        }
        else
        {
            this.errorText = e.InnerExceptions.First().Message;
        }
    }
{{endregion}}

{% if site.site_name == 'Silverlight' %}
>A better example of the Drill Down functionality can be found in [here](http://demos.telerik.com/silverlight/#PivotGrid/DrillDown).
{% endif %}
{% if site.site_name == 'WPF' %}
>A better example of the Drill Down functionality can be found in the [WPF Controls Samples](http://demos.telerik.com/wpf/) under **PivotGrid -> Underlying data**.
{% endif %}

## See Also

* [Calculations]({%slug radpivotgrid-features-calculations%})

* [Calculated Fields]({%slug radpivotgrid-features-local-calc-fields%})

* [Calculated Items]({%slug radpivotgrid-features-local-calc-items%})