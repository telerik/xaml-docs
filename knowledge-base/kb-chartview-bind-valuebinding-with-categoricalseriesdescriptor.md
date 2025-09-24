---
title: How to Bind ValueBinding Property of a Series by Using CategoricalSeriesDescriptor
description: This article demonstrates how to bind the ValueBinding property of a series using a CategoricalSeriesDescriptor.
type: how-to
page_title: How to DataBind ValuePath of CategoricalSeriesDescriptor 
slug: kb-chartview-bind-valuebinding-with-categoricalseriesdescriptor
position: 0
tags: ValuePath, IValueConverter, CategoricalSeriesDescriptor, ValueBinding
ticketid: 1431542
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
			<td>RadChartView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to DataBind ValuePath of CategoricalSeriesDescriptor.

## Solution

As the ValuePath property cannot be data bound what we need do instead is use the Style property of the descriptor to bind the ValueBinding property of the series.

1. In the code-behind we need to create a StringToValuePathConverter like so:

	
	```C#
		public class StringToValuePathConverter : IValueConverter
		{
			public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			{
				var valuePath = value.ToString();
				return new PropertyNameDataPointBinding(valuePath);
			}

			public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			{
				throw new NotImplementedException();
			}
		}
	```
	
2.  In XAML use a ValueBinding property of a series with an IValueConverter. To do that  use the Style property of the CategoricalSeriesDescriptor like so:

	
	```C#
		 <telerik:ChartSeriesProvider.SeriesDescriptors>
                                    <telerik:CategoricalSeriesDescriptor x:Name="seriesDescriptor" CategoryPath="ArchiveTime"        
                                                                 ItemsSourcePath="ChartItems">
                                            <telerik:CategoricalSeriesDescriptor.Style>
                                                <Style TargetType="telerik:BarSeries">
                                                    <Setter Property="ValueBinding" Value="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadCartesianChart}, Path=DataContext.BarChartValuePath, Converter={StaticResource StringToValuePathConverter}}" />
                                                </Style>
                                            </telerik:CategoricalSeriesDescriptor.Style>
                                    </telerik:CategoricalSeriesDescriptor>
		</telerik:ChartSeriesProvider.SeriesDescriptors>
	```
