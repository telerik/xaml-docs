---
title: Bind the StackGroupKey of the BarSeries when Using ChartSeriesProvider
page_title: ChartSeriesProvider with BarSeries and a Bound StackGroupKey
description: How to bind the StackGroupKey of the BarSeries when using ChartSeriesProvider.
type: how-to
slug: kb-chartview-series-provider-bind-stackgroupkey
position: 0
tags: chartview, series provider, stackgroupkey, dynamic number of series
ticketid: 1691623
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2025.2.521</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadChartView for WPF</td>
	</tr>
</table>

## Description

`Binding` the `StackGroupKey` property of the `BarSeries` when using `ChartSeriesProvider`.

## Solution

The `StackGroupKey` property of the `BarSeries` class is not a `DependencyProperty`, thus it cannot be bound directly. To bind it when using the `ChartSeriesProvider` functionality of `RadChartView`, you can implement a custom [attached property]({%slug common-mvvm-attached-behavior%}). You can bind this attached property to a property in the view model of the series. To bind it, you can create a new `Style` for the `CategoricalSeriesDescriptor` instance.

>important In order for the `StackGroupKey` property to be taken into account, the `CombineMode` property needs to be set to either `Stack` or `Stack100`.

__Adding an additional property for the StackGroupKey in the view model of the series__
```C#
    public class SeriesViewModel
    {
        //Property that holds the stack group key of the current series
        public object StackGroupKey { get; set; }
        public ObservableCollection<MyPointInfo> MyPoints { get; set; }
    }
```

__Defining the series descriptor and binding the StackGroupKey to an attached property__
```XAML
    <telerik:ChartSeriesProvider.SeriesDescriptors>
        <telerik:CategoricalSeriesDescriptor ItemsSourcePath="MyPoints" 
                                             CategoryPath="Category"
                                             ValuePath="Value">
            <telerik:CategoricalSeriesDescriptor.Style>
                <Style TargetType="telerik:BarSeries">
                    <Setter Property="CombineMode" Value="Stack"/>
                    <Setter Property="local:BarSeriesExtensions.StackGroupKey" Value="{Binding StackGroupKey}"/>
                </Style>
            </telerik:CategoricalSeriesDescriptor.Style>
        </telerik:CategoricalSeriesDescriptor>
    </telerik:ChartSeriesProvider.SeriesDescriptors>
```

__Implementing the attached property that will set the StackGroupKey of each BarSeries__
```C#
    public class BarSeriesExtensions
    {
        public static object GetStackGroupKey(DependencyObject obj)
        {
            return (object)obj.GetValue(StackGroupKeyProperty);
        }

        public static void SetStackGroupKey(DependencyObject obj, object value)
        {
            obj.SetValue(StackGroupKeyProperty, value);
        }

        public static readonly DependencyProperty StackGroupKeyProperty =
            DependencyProperty.RegisterAttached("StackGroupKey", typeof(object), typeof(BarSeriesExtensions), new   PropertyMetadata(null, OnStackGroupKeyChanged));

        private static void OnStackGroupKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                BarSeries barSeries = (BarSeries)d;
                barSeries.StackGroupKey = e.NewValue;
            }
        }
    }
```