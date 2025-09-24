---
title: DataBinding
page_title: DataBinding
description: Check our &quot;DataBinding&quot; documentation article for the RadSparkLine {{ site.framework_name }} control.
slug: radsparkline_databinding
tags: databinding
published: True
position: 3
---

# DataBinding

Databinding for the Sparkline control involves the correlation between the business logic/data, and the visualization of the control.

The DataBinding  involves the following three properties:

* __SparkLine.ItemsSource__ - gets or sets the data source used to generate the content of the sparkline  control. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow.

* __Sparkline.XValuePath__ - sets the name of the property from the underlying datasource, which will determine the position of each datapoint along the x axis.

* __Sparkline.YValuePath__ - sets the name of the property from the underlying datasource, which will determine the position of each datapoint along the y axis.

__Supported Data Sources__

You can bind __RadSparkline__ to a data source that implements one of the following interfaces:

* [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) - supports simple iteration of a collection. See the MSDN article for more on [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx).

* [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) - extends [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) and supports size, enumerator, and synchronization methods for collections.

* [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) - extends [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) and is the base class for lists.

__Change Notification Support__

__RadSparkline__ also provides full support for change notifications - changes in data sources that implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx), as well as [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20),  are properly tracked and reflected by the UI.

Some of the implementations of these interfaces include:

* [Array](http://msdn.microsoft.com/en-us/library/system.array.aspx)

* [ArrayList](http://msdn.microsoft.com/en-us/library/system.collections.arraylist.aspx)

* [CollectionBase](http://msdn.microsoft.com/en-us/library/system.collections.collectionbase.aspx) objects

* [DataTable](http://msdn.microsoft.com/en-us/library/system.data.datatable.aspx)

* [Generic Lists](http://msdn2.microsoft.com/en-us/library/6sh2ey19.aspx)

* [ObservableCollection](http://msdn.microsoft.com/en-us/library/ms668604.aspx)

__1.Binding To Collection of Doubles__

The following code snippets demonstrate how to databind RadSparkLine to generic List of double type

Create new *RadLinearSparkline* in XAML and turn on visibility for Indicators as follows:


```XAML
    <telerik:RadLinearSparkline Width="150" Height="50" x:Name="myLinearSparkline" ShowFirstPointIndicator="True" ShowLastPointIndicator="True" ShowHighPointIndicators="True" ShowLowPointIndicators="True"/>
```

Set the List as datasource for the SparkLine using the *ItemsSource *property of the RadLinearSparkline:


```C#
	Random r = new Random();
	List<double> myData = new List<double>();
	for (int i = 0; i < 20; i++)
	{
	myData.Add(r.Next(0,100));
	}
	myLinearSparkline.ItemsSource = myData;
```


```VB.NET
    Dim myLinearSparkline As New RadLinearSparkline()
    Dim r As New Random()
    Dim myData As New List(Of Double)()
        For i As Integer = 0 To 19
              myData.Add(r.Next(0,100))
        Next i
	
	myLinearSparkline.ItemsSource = myData
```

__2.Binding To a List of Business Objects__

If you have a list of business objects and you want to bind it to the RadSparkLine control here is how to do it:


```XAML
    <telerik:RadColumnSparkline x:Name="PART_SparkbarControl" HorizontalAlignment="Left" VerticalAlignment="Top" Height="48" Width="400"
                                ShowAxis="False"
                                ItemsSource="{Binding}"
                                XValuePath="Cost"
                                YValuePath="UnitCost" />

    <telerik:RadLinearSparkline x:Name="PART_SparklineControl" HorizontalAlignment="Left" VerticalAlignment="Top" Height="48" Width="400" Margin="0,54,0,0"
                                ShowAxis="False"
                                ItemsSource="{Binding}"
                                XValuePath="MyDate"
                                YValuePath="UnitCost"
                                ShowLastPointIndicator="True"
                                ShowHighPointIndicators="True"
                                ShowLowPointIndicators="True" />
```


```C#
    public partial class MainPage : UserControl 
    {
        public MainPage() //MainWindow in WPF
        {
            InitializeComponent();
            DateTime today = DateTime.Today;

            List<MyCost> data = new List<MyCost>()
            {
                new MyCost() { Cost = 1, UnitCost = 2, MyDate=today },
                new MyCost() { Cost = 2, UnitCost = 4, MyDate= today.AddDays(1)},
                new MyCost() { Cost = 3, UnitCost = 6, MyDate=today.AddDays(2) },
                new MyCost() { Cost = 4, UnitCost = 4, MyDate=today.AddDays(3)},
                new MyCost() { Cost = 5, UnitCost = 8, MyDate=today.AddDays(4)},
            };
            this.DataContext = data;
        }
    }

    public class MyCost
    {
        public double Cost { get; set; }
        public double UnitCost { get; set; }
        public DateTime MyDate { get; set; }
    }
```


```VB.NET
    Partial Public Class MainPage
        Inherits UserControl
        Public Sub New() 'MainWindow in WPF
            InitializeComponent()
            Dim today As Date = Date.Today

            Dim data As New List(Of MyCost)() From {New MyCost() With {.Cost = 1, .UnitCost = 2, .MyDate = today}, New MyCost() With {.Cost = 2, .UnitCost = 4, .MyDate = today.AddDays(1)}, New MyCost() With {.Cost = 3, .UnitCost = 6, .MyDate = today.AddDays(2)}, New MyCost() With {.Cost = 4, .UnitCost = 4, .MyDate = today.AddDays(3)}, New MyCost() With {.Cost = 5, .UnitCost = 8, .MyDate = today.AddDays(4)}}
            Me.DataContext = data
        End Sub
    End Class

    Public Class MyCost
        Public Property Cost() As Double
        Public Property UnitCost() As Double
        Public Property MyDate() As Date
    End Class
```
