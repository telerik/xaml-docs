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

As of **R1 2017**, **LocalDataSourceProvider** exposes a **GetUnderlyingData** method that allows you to extract the records from your ItemsSource that were used for accumulating the result for a particular row and column. The GetUnderlyingData method takes two parameters: **Row Group** and **Column Group**.

{% if site.site_name == 'Silverlight' %}
__Example 1: Calling GetUnderlyingData on Cell Double-Click__
```C#
	private void pivotGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount == 2)
        {
			var pivotGrid = sender as RadPivotGrid;
			if (pivotGrid != null)
		    {
	            var cellData = (e.OriginalSource as FrameworkElement).DataContext as CellData;
	            if (cellData != null)
	            {
	                var cellAggregateValue = cellData.Data as CellAggregateValue;
	                var localProvider = pivotGrid.DataProvider as LocalDataSourceProvider;
					if (localProvider != null)
				    {
        				localProvider.GetUnderlyingData(cellAggregateValue.RowGroup, cellAggregateValue.ColumnGroup);
					}         
				}
			}
        }
    }
```
{% endif %}
{% if site.site_name == 'WPF' %}
__Example 1: Calling GetUnderlyingData on Cell Double-Click__
```C#
	private void pivotGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		var pivotGrid = sender as RadPivotGrid;
		if (pivotGrid != null)
	    {
		    var cellData = (e.OriginalSource as FrameworkElement).DataContext as CellData;
		    if (cellData != null)
		    {
		        var cellAggregateValue = cellData.Data as CellAggregateValue;
		        var localProvider = pivotGrid.DataProvider as LocalDataSourceProvider;
				if (localProvider != null)
				{
		        	localProvider.GetUnderlyingData(cellAggregateValue.RowGroup, cellAggregateValue.ColumnGroup);
				}          
		    }
		}
	}
```
{% endif %}

{% if site.site_name == 'Silverlight' %}
__Example 1: Calling GetUnderlyingData on Cell Double-Click__
```VB.NET
	Private Sub pivotGrid_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
		If e.ClickCount = 2 Then
			Dim pivotGrid = TryCast(sender, RadPivotGrid)
			If pivotGrid IsNot Nothing Then
				Dim cellData = TryCast((TryCast(e.OriginalSource, FrameworkElement)).DataContext, CellData)
				If cellData IsNot Nothing Then
					Dim cellAggregateValue = TryCast(cellData.Data, CellAggregateValue)
					Dim localProvider = TryCast(pivotGrid.DataProvider, LocalDataSourceProvider)
					If localProvider IsNot Nothing Then
						localProvider.GetUnderlyingData(cellAggregateValue.RowGroup, cellAggregateValue.ColumnGroup)
					End If
				End If
			End If
		End If
	End Sub
```
{% endif %}
{% if site.site_name == 'WPF' %}
__Example 1: Calling GetUnderlyingData on Cell Double-Click__
```VB.NET
	Private Sub pivotGrid_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			Dim pivotGrid = TryCast(sender, RadPivotGrid)
			If pivotGrid IsNot Nothing Then
				Dim cellData = TryCast((TryCast(e.OriginalSource, FrameworkElement)).DataContext, CellData)
				If cellData IsNot Nothing Then
					Dim cellAggregateValue = TryCast(cellData.Data, CellAggregateValue)
					Dim localProvider = TryCast(pivotGrid.DataProvider, LocalDataSourceProvider)
					If localProvider IsNot Nothing Then
						localProvider.GetUnderlyingData(cellAggregateValue.RowGroup, cellAggregateValue.ColumnGroup)
					End If
				End If
			End If
	End Sub
```
{% endif %}

Once RadPivotGrid has finished processing the underlying data, the newly-introduced **GetUnderlyingDataCompleted** event will be fired. Its **DrillDownCompletedEventArgs** have two properties:

* **Result**: An **IEnumerable** representing the result of the underlying data extraction operation.
* **InnerExceptions**: A **read-only** collection of any **exceptions** thrown during the underlying data extraction.

>If the **DeferUpdates** property of the LocalDataSourceProvider is set to **True**, calling the GetUnderlyingData method without first updating the provider will result in an **InvalidOperationException** which will be passed to the DrillDownCompletedEventArgs' InnerExceptions collection.

>importantThe GetUnderlyingDataCompleted event is raised on multiple threads, so it is required to use **Dispatcher** when executing custom logic inside of the event handler.

__Example 2: The GetUnderlyingDataCompleted Event Handler__

```C#
	private void dataProvider_GetUnderlyingDataCompleted(object sender, DrillDownCompletedEventArgs e)
    {
		Dispatcher.BeginInvoke(new Action(() => 
        {
		    if (e.InnerExceptions.Count() == 0)
		    {
		        this.underlyingDataGridView.ItemsSource = e.Result;
		    }
		    else
	        {
	            this.errorText = e.InnerExceptions.First().Message;
	        }
		}));
    }
```
```VB.NET
	Private Sub dataProvider_GetUnderlyingDataCompleted(ByVal sender As Object, ByVal e As DrillDownCompletedEventArgs)
			Dispatcher.BeginInvoke(New Action(Sub()
				If e.InnerExceptions.Count() = 0 Then
					Me.underlyingDataGridView.ItemsSource = e.Result
				Else
					Me.errorText = e.InnerExceptions.First().Message
				End If
			End Sub))
	End Sub
```

{% if site.site_name == 'Silverlight' %}
>A better example of the Drill Down functionality can be found [here](https://demos.telerik.com/silverlight/#PivotGrid/DrillDown).
{% endif %}
{% if site.site_name == 'WPF' %}
>A better example of the Drill Down functionality can be found in the [WPF Controls Samples](https://demos.telerik.com/wpf/) under **PivotGrid -> Underlying data**.
{% endif %}

## See Also

* [Calculations]({%slug radpivotgrid-features-calculations%})

* [Calculated Fields]({%slug radpivotgrid-features-local-calc-fields%})

* [Calculated Items]({%slug radpivotgrid-features-local-calc-items%})