---
title: Dynamic Number of Series (ChartSeriesProvider)
page_title: Dynamic Number of Series (ChartSeriesProvider)
description: Dynamic Number of Series (ChartSeriesProvider)
slug: radchartview-features-chartseriesprovider
tags: dynamic,number,of,series,(chartseriesprovider)
published: True
position: 6
---

# Dynamic Number of Series (ChartSeriesProvider)

In this help topic, you will learn what mechanism ChartView provides for automatic series generation.      

* [Overview](#overview)
* [ChartSeriesDescriptor](#chartseriesdescriptor)
* [Properties](#properties)
* [Code Example](#code-example)

## Overview

RadCartesianChart and RadPolar chart can create a dynamic number of series depending on the data (collection of collections). To take advantage of this feature, you need to create a __ChartSeriesProvider__ object. This will be the object that receives the data and holds the __ChartSeriesDescriptors__ – objects that define the specific properties of the dynamically generated series.        

The series provider uses descriptor objects to define the type and visual apperance of the series. Depending on the series type that you want to use, you can define different descriptors.  
    
|Series|Descriptor|
|------|----------|
|__Categorical Series__ (BarSeries, LineSeries, SplineSeries, AreaSeries, SplineAreaSeries)|CategoricalSeriesDescriptor
|__Financial Series__ (OhlcSeries, CandlestickSeries)|OhlcSeriesDescriptor
|__Scatter Series__ (ScatterPointSeries, ScatterLineSeries, ScatterSplineSeries, ScatterAreaSeries, ScatterSplineAreaSeries)|ScatterSeriesDescriptor
|__Polar Series__ (PolarPointSeries, PolarLineSeries, PolarAreaSeries)|PolarSeriesDescriptor
|__Radar Series__ (RadarPointSeries, RadarLineSeries, RadarAreaSeries)|RadarSeriesDescriptor
|__All Series Types__|[ChartSeriesDescriptor](#chartseriesdescriptor)  

## ChartSeriesDescriptor

ChartSeriesProvider allows you to use a generic descriptor that gives you more flexibility and it can be used with all chart series. This is the base __ChartSeriesDescriptor__ class. The descriptor doesn't expose value properties and it does not expect a specific type of series, so you can define all you need in its style.

#### __[XAML] Example 1: A ChartSeriesDescriptor that describes a RangeSeries__
{{region radchartview-features-chartseriesprovider_01}}
	<telerik:ChartSeriesDescriptor ItemsSourcePath="MyDataPointsCollection">
		<telerik:ChartSeriesDescriptor.Style>
			<Style TargetType="telerik:RangeSeries">
				<Setter Property="CategoryBinding" Value="MyCategory"/>
				<Setter Property="HighBinding" Value="MyHighValue"/>
				<Setter Property="LowBinding" Value="MyLowValue"/>                                    
			</Style>
		</telerik:ChartSeriesDescriptor.Style>
	</telerik:ChartSeriesDescriptor>
{{endregion}}

In this case, the __TargetType__ of the descriptor determines the type of the series that will be created.

## Properties

Important properties of __ChartSeriesDescriptor__:  

* __ItemsSourcePath__: A property of type __string__ that gets or sets the path to the collection property that will feed the generated series.            

* __TypePath__: A property of type __string__ that gets or sets the path to the property that indicates the series type that needs to be created.            

* __Style__: A property of type __style__ that gets or sets the style that describes the appearance of the series that are to be created. If no __TypePath__ is specified, the TargetType property of the style object is used to generate the desired series.  

* __CollectionIndex__: A property of type __int__ that gets or sets the index within the Source collection of data (view models) for which the current descriptor should be used. This property is useful when, for example, a BarSeries needs to be generated for the first data entry and LineSeries for the rest of the entries.            

Type-specific properties:        

* __CategoricalSeriesDescriptor__
	* __CategoryPath__: A property of type __string__ that sets or gets the path to the Category property of the data item.
	* __ValuePath__: A property of type __string__ that sets or gets the path to the Value property of the data item.

* __OhlcSeriesDescriptor__
	* __OpenPath__: A property of type __string__ that sets or gets the path to the Open value of the data item.
	* __HighPath__: A property of type __string__ that sets or gets the path to the High value of the data item.
	* __LowPath__: A property of type __string__ that sets or gets the path to the Low value of the data item.
	* __ClosePath__: A property of type __string__ that sets or gets the path to the Close value of the data item.

* __PolarSeriesDescriptor__
	* __ValuePath__: A property of type __string__ that sets or gets the path to the Value of the data item.
	* __Anglepath__: A property of type __string__ that sets or gets the path to the Angle value of the data item.
	
* __RadarSeriesDescriptor__
	* __CategoryPath__:  A property of type __string__ that sets or gets the path to the Category of the data item.
	* __ValuePath__:  A property of type __string__ that sets or gets the path to the Value of the data item.

## Events

__ChartSeriesProvider__ expose a single event - __SeriesCreated__. The event occurs when a series is created. It allows for the series to be additionally set up or completely replaced.  

The event arguments are of type __ChartSeriesCreatedEventArgs__ and expose the following properties:
* __Series__: A property of type __ChartSeries__ that holds the created series.
* __Context__: A property of type __object__ that holds the model of the series.

> This event may be raised with the series being null (for example, in cases when a suitable descriptor was not found). In such a case, this event can still be used to create and set up a new series.
	
## Code Example

In the following example, the chart is populated by a collection of 3 items, thus creating 3 series. There is a CategoricalSeriesDescriptor with CollectionIndex=2 and a style with TargetType="LineSeries". This effectively means that there will be a LineSeries, populated by the third item in the collection. There is another CategoricalSeriesDescriptor which is responsible for creating BarSeries for the rest of the items in the collection.        

#### __[XAML] Example 2: A sample chart definition with its SeriesProvider set__
{{region radchartview-features-chartseriesprovider_02}}
	<telerik:RadCartesianChart x:Name="chart" Palette="Summer">
	            
	    <telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:CategoricalAxis></telerik:CategoricalAxis>
	    </telerik:RadCartesianChart.HorizontalAxis>
	            
	    <telerik:RadCartesianChart.VerticalAxis>
	        <telerik:LinearAxis HorizontalAlignment="Right"></telerik:LinearAxis>
	    </telerik:RadCartesianChart.VerticalAxis>
	            
	    <telerik:RadCartesianChart.SeriesProvider>
	        <telerik:ChartSeriesProvider Source="{Binding Data}">
	            <telerik:ChartSeriesProvider.SeriesDescriptors>
	
	                <telerik:CategoricalSeriesDescriptor ItemsSourcePath="Data" ValuePath="Sales" CategoryPath="MonthName">
	                    <telerik:CategoricalSeriesDescriptor.Style>
	                        <Style TargetType="telerik:BarSeries">
	                            <Setter Property="CombineMode" Value="Cluster" />
	                        </Style>
	                    </telerik:CategoricalSeriesDescriptor.Style>
	                </telerik:CategoricalSeriesDescriptor>
	
	                <telerik:CategoricalSeriesDescriptor ItemsSourcePath="Data" ValuePath="Sales" CategoryPath="MonthName" CollectionIndex="2">
	                    <telerik:CategoricalSeriesDescriptor.Style>
	                        <Style TargetType="telerik:LineSeries">
	                            <Setter Property="StrokeThickness" Value="2"/>
	                        </Style>
	                    </telerik:CategoricalSeriesDescriptor.Style>
	                </telerik:CategoricalSeriesDescriptor>
	                        
	            </telerik:ChartSeriesProvider.SeriesDescriptors>
	        </telerik:ChartSeriesProvider>
	                
	    </telerik:RadCartesianChart.SeriesProvider>
	</telerik:RadCartesianChart>
{{endregion}}

#### __[C#] Example 3: The chart's view models set up__
{{region radchartview-features-chartseriesprovider_03}}
	public class SalesInfo 
	{
	    public string MonthName { get; set; }
	    public double Sales { get; set; }
	}
	
	public class VendorYearlyData
	{
	    public string VendorName { get; set; }
	    public ObservableCollection<SalesInfo> Data { get; set; }
	}
	
	public class MainViewModel
	{
	    public ObservableCollection<VendorYearlyData> Data { get; set; }
	
	    public MainViewModel()
	    {
	        this.Data = GetSampleData();
	    }
	
	    private ObservableCollection<VendorYearlyData> GetSampleData()
	    {
	        var result = new ObservableCollection<VendorYearlyData>();
	
	        result.Add(new VendorYearlyData()
	        {
	            VendorName = "Vendor A",
	            Data = new ObservableCollection<SalesInfo>()
	            {
	                new SalesInfo() { MonthName = "Jan", Sales = 5 },
	                new SalesInfo() { MonthName = "Feb", Sales = 7 },
	                new SalesInfo() { MonthName = "Mar", Sales = 6 },
	                new SalesInfo() { MonthName = "Apr", Sales = 8 }
	            }
	        });
	
	        result.Add(new VendorYearlyData()
	        {
	            VendorName = "Vendor B",
	            Data = new ObservableCollection<SalesInfo>()
	            {
	                new SalesInfo() { MonthName = "Jan", Sales = 15 },
	                new SalesInfo() { MonthName = "Feb", Sales = 18 },
	                new SalesInfo() { MonthName = "Mar", Sales = 19 },
	                new SalesInfo() { MonthName = "Apr", Sales = 23 }
	            }
	        });
	
	
	        result.Add(new VendorYearlyData()
	        {
	            VendorName = "Vendor C",
	            Data = new ObservableCollection<SalesInfo>()
	            {
	                new SalesInfo() { MonthName = "Jan", Sales = 21 },
	                new SalesInfo() { MonthName = "Feb", Sales = 25 },
	                new SalesInfo() { MonthName = "Mar", Sales = 26 },
	                new SalesInfo() { MonthName = "Apr", Sales = 25 }
	            }
	        });
	
	        return result;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 3: A sample chart definition with its SeriesProvider set__
{{region radchartview-features-chartseriesprovider_04}}
	Public Class SalesInfo
		Public Property MonthName() As String
		Public Property Sales() As Double
	End Class
	
	Public Class VendorYearlyData
		Public Property VendorName() As String
		Public Property Data() As ObservableCollection(Of SalesInfo)
	End Class
	
	Public Class MainViewModel
		Public Property Data() As ObservableCollection(Of VendorYearlyData)
	
		Public Sub New()
			Me.Data = GetSampleData()
		End Sub
	
		Private Function GetSampleData() As ObservableCollection(Of VendorYearlyData)
			Dim result = New ObservableCollection(Of VendorYearlyData)()
	
			result.Add(New VendorYearlyData() With { _
				.VendorName = "Vendor A", _
				.Data = New ObservableCollection(Of SalesInfo)() With { _
					New SalesInfo() With { _
						.MonthName = "Jan", _
						.Sales = 5 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Feb", _
						.Sales = 7 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Mar", _
						.Sales = 6 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Apr", _
						.Sales = 8 _
					} _
				} _
			})
	
			result.Add(New VendorYearlyData() With { _
				.VendorName = "Vendor B", _
				.Data = New ObservableCollection(Of SalesInfo)() With { _
					New SalesInfo() With { _
						.MonthName = "Jan", _
						.Sales = 15 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Feb", _
						.Sales = 18 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Mar", _
						.Sales = 19 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Apr", _
						.Sales = 23 _
					} _
				} _
			})
	
			result.Add(New VendorYearlyData() With { _
				.VendorName = "Vendor C", _
				.Data = New ObservableCollection(Of SalesInfo)() With { _
					New SalesInfo() With { _
						.MonthName = "Jan", _
						.Sales = 21 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Feb", _
						.Sales = 25 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Mar", _
						.Sales = 26 _
					}, _
					New SalesInfo() With { _
						.MonthName = "Apr", _
						.Sales = 25 _
					} _
				} _
			})
			
			Return result
		End Function
	End Class
{{endregion}}

#### __Figure 1: Dynamic number of series generated using SeriesProvider__
![Rad Chart View-chartseriesprovider-0](images/RadChartView-chartseriesprovider-0.png)

> You can find runnable examples that demonstrate the __SeriesProvider__ in our [GitHub SDK repository](https://github.com/telerik/xaml-sdk). There are a couple examples that you can find under the following directories in the repository - {% if site.site_name == 'Silverlight' %}[ChartView/SL/SeriesProvider](https://github.com/telerik/xaml-sdk/tree/master/ChartView/SL/SeriesProvider) and [ChartView/SL/SeriesDescriptorSelector](https://github.com/telerik/xaml-sdk/tree/master/ChartView/SL/SeriesDescriptorSelector){% endif %}{% if site.site_name == 'WPF' %}[ChartView/WPF/SeriesProvider](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/SeriesProvider) and [ChartView/WPF/SeriesDescriptorSelector](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/SeriesDescriptorSelector){% endif %}

## See Also  
* [Getting Started]({%slug radchartview-introduction%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
* [Annotations Provider]({%slug radchartview-annotations-annotationsprovider%})
