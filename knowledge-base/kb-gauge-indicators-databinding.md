---
title: Dynamic Creation of RadGauge Indicators
description: Data binding the Indicators collection of RadGauge using an attached property.
page_title: Setting the Indicators property of RadGauge
type: how-to
slug: kb-gauge-indicators-databinding
position: 0
tags: indicators, databinding, attached property
ticketid: 1449474
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3.917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGauge for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to data bind the Indicators collection of RadGauge.

## Solution

The Indicators property doesn't support data binding. One way to achieve this requirement, is to use an attached property.


```XAML
	<telerik:VerticalLinearScale local:IndicatorsBehavior.ItemsSource="{Binding Markers}" />
```


```C#
	public class IndicatorsBehavior
    {
        public static IEnumerable GetItemsSource(DependencyObject obj)
        {
            return (IEnumerable)obj.GetValue(ItemsSourceProperty);
        }

        public static void SetItemsSource(DependencyObject obj, IEnumerable value)
        {
            obj.SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.RegisterAttached(
				"ItemsSource", 
				typeof(IEnumerable), 
				typeof(IndicatorsBehavior), 
				new PropertyMetadata(null, OnItemsSourceChanged));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var scale = (VerticalLinearScale)d;
                var markers = (List<double>)e.NewValue;
                foreach (var markerValue in markers)
                {
                    var marker = new Marker()
                    {
                        Value = markerValue
                    };
                    LinearScale.SetRotateForVertical(marker, true);
                    ScaleObject.SetRelativeWidth(marker, new GaugeMeasure(0.05, GridUnitType.Star));
                    ScaleObject.SetRelativeHeight(marker, new GaugeMeasure(0.04, GridUnitType.Star));
                    ScaleObject.SetOffset(marker, new GaugeMeasure(0.04, GridUnitType.Star));
                    scale.Indicators.Add(marker);
                }
            }
        }
    }
```


```C#
	public class MainViewModel
    {
        public List<double> Markers { get; set; } = new List<double>() { 20, 50, 66 };
    }
```