---
title: Drill Down
page_title: Drill Down
description: Check our &quot;Drill Down&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-localdatasourceprovider-drilldown
tags: culture,support
published: True
position: 10
---

# Drill Down

The `LocalDataSourceProvider` exposes a `GetUnderlyingData` method that allows you to extract the records from your ItemsSource that were used for accumulating the result for a particular row and column. The GetUnderlyingData method takes two parameters: __Row Group__ and __Column Group__.

__Calling GetUnderlyingData on Cell Double-Click__

<snippet id='radpivotgrid-features-localdatasourceprovider-drilldown-block_1-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-drilldown-block_1-vb' />

Once RadPivotGrid has finished processing the underlying data, the newly-introduced GetUnderlyingDataCompleted event will be fired. Its `DrillDownCompletedEventArgs` have two properties:

* `Result`&mdash; An IEnumerable representing the result of the underlying data extraction operation.
* `InnerExceptions`&mdash;A __read-only__ collection of any __exceptions__ thrown during the underlying data extraction.

>If the `DeferUpdates` property of the LocalDataSourceProvider is set to __True__, calling the GetUnderlyingData method without first updating the provider will result in an `InvalidOperationException` which will be passed to the DrillDownCompletedEventArgs' InnerExceptions collection.

>important The `GetUnderlyingDataCompleted` event is raised on multiple threads, so it is required to use `Dispatcher` when executing custom logic inside of the event handler.

__Example 2: The GetUnderlyingDataCompleted Event Handler__

<snippet id='radpivotgrid-features-localdatasourceprovider-drilldown-block_2-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-drilldown-block_2-vb' />

>A better example of the Drill Down functionality can be found in the [WPF Controls Samples](https://demos.telerik.com/wpf/) under **PivotGrid -> Underlying data**.

## See Also

* [Calculations]({%slug radpivotgrid-features-calculations%})

* [Calculated Fields]({%slug radpivotgrid-features-local-calc-fields%})

* [Calculated Items]({%slug radpivotgrid-features-local-calc-items%})