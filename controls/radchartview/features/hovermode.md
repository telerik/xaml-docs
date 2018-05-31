---
title: HoverMode
page_title: HoverMode
description: HoverMode
slug: radchartview-features-hovermode
tags: radchartview,hover, mode
published: True
position: 9
---

# HoverMode

The RadChartBase exposes a property called **HoverMode** which controls weather the rest of the series will fade out when a certain series is hovered. It is useful in situations with many overlapping series and has two possible values: **FadeOtherSeries** and **None**. The default value is **None**. This article will demonstrate how you can use this property.

First we have to set up the desired chart and set its **HoverMode** property to **FadeOtherSeries** as demonstrated in Example 1.
        
#### __[XAML] Example 1: Define the RadCartesianChart with HoverMode__

{{region radchartview-features-hovermode_0}}
	<telerik:RadCartesianChart x:Name="chart" HoverMode="FadeOtherSeries">
        <telerik:RadCartesianChart.VerticalAxis>
            <telerik:LinearAxis />
        </telerik:RadCartesianChart.VerticalAxis>
        <telerik:RadCartesianChart.HorizontalAxis>
            <telerik:CategoricalAxis />
        </telerik:RadCartesianChart.HorizontalAxis>
        <telerik:RadCartesianChart.Series>
            <telerik:LineSeries ValueBinding="Value" 
                                CategoryBinding="Category" 
                                ItemsSource="{Binding Data[0]}"
                                Stroke="#007ACC">
            </telerik:LineSeries>
            <telerik:LineSeries ValueBinding="Value" 
                                CategoryBinding="Category" 
                                ItemsSource="{Binding Data[1]}"
                                Stroke="#FF5AC3"
                                StrokeThickness="3"
                                DashArray="2 2">
            </telerik:LineSeries>
            <telerik:LineSeries ValueBinding="Value" 
                                CategoryBinding="Category" 
                                ItemsSource="{Binding Data[2]}" 
                                Stroke="#FF9C33"
                                StrokeThickness="3"
                                DashArray="2 2">
            </telerik:LineSeries>
            <telerik:LineSeries ValueBinding="Value" 
                                CategoryBinding="Category" 
                                ItemsSource="{Binding Data[3]}"
                                Stroke="#27C106">
            </telerik:LineSeries>
        </telerik:RadCartesianChart.Series>
    </telerik:RadCartesianChart>
{{endregion}}

Next we will define the model which will hold the data for the points and the view model which will generate the data. We will also set the DataContext to our view model. This is demonstrated in Example 2.

#### __[C#] Example 2: Define the model and view model__
{{region radchartview-features-hovermode_1}}
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainViewModel();
    }

    public class MainViewModel
    {
        Random r = new Random();
        public List<ObservableCollection<PlotInfo>> Data { get; set; }

        public MainViewModel()
        {
            
            this.Data = new List<ObservableCollection<PlotInfo>>();
            for (int i = 0; i < 4; i++)
            {
                var items = new ObservableCollection<PlotInfo>();
                for (int k = 0; k < 30; k++)
                {
                    items.Add(new PlotInfo() { Category = k.ToString(), Value = r.Next(100, 300) });
                }
                this.Data.Add(items);
            }
        }
    }

    public class PlotInfo
    {
        public string Category { get; set; }
        public double Value { get; set; }
    }
{{endregion}}


#### __[VB.NET] Example 2: Define the model and view model__
{{region radchartview-features-hovermode_2}}
    Public Sub New()
		InitializeComponent()
		Me.DataContext = New MainViewModel()
    End Sub

    Public Class MainViewModel
        Private r As New Random()
        Public Property Data() As List(Of ObservableCollection(Of PlotInfo))

        Public Sub New()
            Me.Data = New List(Of ObservableCollection(Of PlotInfo))()
            For i As Integer = 0 To 3
                Dim items = New ObservableCollection(Of PlotInfo)()
                For k As Integer = 0 To 29
                    items.Add(New PlotInfo() With {
                        .Category = k.ToString(),
                        .Value = r.Next(100, 300)
                    })
                Next k
                Me.Data.Add(items)
            Next i
        End Sub
    End Class

    Public Class PlotInfo
		Public Property Category() As String
		Public Property Value() As Double
    End Class
{{endregion}}

#### Figure 1: Result from Example 2 comparing hovering over different series
![RadChartView HoverMode](images/RadChartView-HoverMode.png)

> Due to the random generation of the data, the result will differ every time.

## See also

* [Getting Started]({%slug radchartview-introduction%})
* [Chart Types]({%slug radchartview-chart-types%})