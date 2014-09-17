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



In this help topic you will learn what mechanism for automatic series
        generation ChartView provides.
      

## Overview

RadCartesianChart and RadPolar chart can create a dynamic number of series depending
          on the data (collection of collections). To take advantage of this feautre,
          you need to create a __ChartSeriesProvider__ object. This will be the object that
          receives the data and holds the __ChartSeriesDescriptors__ – objects that define the specific
          properties of the dynamically generated series.
        

__ChartSeriesDescriptor__  is an abstract class. You need to create an instance
          of one of its inheritors depending on the series you need to produce:
        
<table><th><tr><td>

Series</td><td>

Descriptor</td></tr></th><tr><td>

CategoricalSeries (BarSeries, LineSeries, SplineSeries, AreaSeries, SplineAreaSeries)</td><td>

CategoricalSeriesDescriptor
              </td></tr><tr><td>

OhlcSeries, CandlestickSeries
              </td><td>

OhlcSeriesDescriptor
              </td></tr><tr><td>

Scatter* Series (ScatterPointSeries, ScatterLineSeries, ScatterSplineSeries, ScatterAreaSeries, ScatterSplineAreaSeries)
              </td><td>

ScatterSeriesDescriptor
              </td></tr><tr><td>

Polar* Series (PolarPointSeries, PolarLineSeries, PolarAreaSeries)
              </td><td>

PolarSeriesDescriptor
              </td></tr><tr><td>

Radar* Series (RadarPointSeries, RadarLineSeries, RadarAreaSeries)
              </td><td>

RadarSeriesDescriptor
              </td></tr></table>

## Properties

Important properties of ChartSeriesDescriptor:
        

* __ItemsSourcePath__ – path to the collection that will feed the generated series.
            

* __TypePath__ – path to the property that indicates the series type that needs to be created.
            

* __Style__ – gets or sets the Style that describes the appearance of the series that are to be created.
              If no __TypePath__ is specified, the TargetType property of this style object is used to generate the desired series.
            

* __CollectionIndex__ – gets or sets the index within the Source collection of data (view models) for which
              the current descriptor should be used.
            This property is useful when for example a BarSeries needs to be generated for
              the first data entry and LineSeries for the rest of the entries.
            

Type-specific properties:
        

* __CategoricalSeriesDescriptor__
<table><tr><td>

CategoryPath</td><td>

path to the Category of the data item</td></tr><tr><td>

ValuePath</td><td>

path to the Value of the data item</td></tr></table>

* __OhlcSeriesDescriptor__
<table><tr><td>

OpenPath</td><td>

path to the Open value of the data item</td></tr><tr><td>

HighPath</td><td>

path to the High value of the data item</td></tr><tr><td>

LowPath</td><td>

path to the Low value of the data item</td></tr><tr><td>

ClosePath</td><td>

path to the Close value of the data item</td></tr></table>

* __PolarSeriesDescriptor__
<table><tr><td>

ValuePath</td><td>

path to the Value of the data item</td></tr><tr><td>

Anglepath</td><td>

path to the Angle value of the data item</td></tr></table>

* __RadarSeriesDescriptor__
<table><tr><td>

CategoryPath</td><td>

path to the Category of the data item</td></tr><tr><td>

ValuePath</td><td>

path to the Value of the data item</td></tr></table>

## Example

In the following example the chart is populated by a collection of 3 items, thus creating 3 series.
          There is a CategoricalSeriesDescriptor with CollectionIndex=2 and a style with TargetType="LineSeries".
          This effectively means that there will be a LineSeries, populated by the third item in the collection.
          There is another CategoricalSeriesDescriptor which is responsible for creating BarSeries
          for the rest of the items in the collection.
        

#### __XAML__

{{region radchartview-features-chartseriesprovider_0}}
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



#### __C#__

{{region radchartview-features-chartseriesprovider_0}}
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



#### __VB.NET__

{{region radchartview-features-chartseriesprovider_0}}
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

![Rad Chart View-chartseriesprovider-0](images/RadChartView-chartseriesprovider-0.png)

# See Also
