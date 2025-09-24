---
title: Performance Tips and Tricks
page_title: Performance Tips and Tricks
description: Check our &quot;Performance Tips and Tricks&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-performance-tips-and-tricks
tags: performance,tips,and,tricks
published: True
position: 0
---

# Performance Tips and Tricks

When having scenarios with large sets of data, you can experience a lower __RadChart__ performance. Here is a list with some simple changes that can improve the performance in large data scenarios:

* __Use fewer data points__ - typical performance guidance for Silverlight and WPF recommends capping the total number of UI elements in the low- to mid-hundreds. Given that each of the chart item instances instantiates around 3-5 UI elements, trying to render a chart with 1000 data points can start to bog the system down quite fast.

>Note that the __Q1 2010__ edition of __RadChart__ is able to handle hundred of thousands of data points thanks to its new __Virtual Scrolling__ and __Data Sampling__ mechanisms.

* __Disable animations__ - disabling animations can also boost the performance.

* __Turn off visibility of PointMarks and Labels for Self-Drawing(Continuous) Series__ - you will achieve fast series out-of-the-box.

* __Simplify the chart ControlTemplate__ - If you cannot reduce the number of data points, you will need to simplify the chart ControlTemplate. For example the Bar Template contains masks which can be removed (as their purpose is to beautify the control but this slows down the performance when you have many data points in series). You can extract the templates from your current version of our controls using Expression Blend as shown in our help topic [Editing Control Templates in Expression Blend](http://www.telerik.com/help/silverlight/common-styling-appearance-edit-control-templates-blend.html). __Note that the ControlTemplate differs in versions older than Q2 2010.__

* __Specify fixed axis range manually__ - if your data changes a lot, but you know the ranges over which it will vary, you can disable the __Axis__ auto-range algorithm and specify the __Axis__ range manually. This will probably lower the processing time a bit. 

* __Add the points more efficiently (ObservableCollection scenario)__ - the control is built around a model where any changes to the data are automatically shown on the screen. This is accomplished by detecting classes that implement the [INotifyPropertyChanged interface](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) and collections that implement the [INotifyCollectionChanged interface](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) and by registering to find out about changes as they occur. However, this system can be counterproductive in one scenario: starting with an empty collection and adding a bunch of data points all at once. By default, each new data point generates a change notification which prompts __RadChart__ to re-analyze the data, re-compute the axis properties, re-layout the visuals, etc. It would be more efficient to add all the points at once and then send a __single__ notification to the control that its data has changed. Unfortunately, the otherwise handy [ObservableCollection class](http://msdn.microsoft.com/en-us/library/ms668604.aspx) doesn't offer a good way of doing this but it is pretty easy to add: 



```C#
	public class AddRangeObservableCollection<T> : ObservableCollection<T>
	{
	    private bool suppressOnCollectionChanged;
	    public void AddRange( IEnumerable<T> items )
	    {
	        if ( items == null )
	        {
	            throw new ArgumentNullException( "items" );
	        }
	        if ( items.Any() )
	        {
	            try
	            {
	                this.suppressOnCollectionChanged = true;
	                foreach ( var item in items )
	                {
	                    this.Add( item );
	                }
	            }
	            finally
	            {
	                this.suppressOnCollectionChanged = false;
	                this.OnCollectionChanged( new NotifyCollectionChangedEventArgs( NotifyCollectionChangedAction.Reset ) );
	            }
	        }
	    }
	    protected override void OnCollectionChanged( NotifyCollectionChangedEventArgs e )
	    {
	        if ( !this.suppressOnCollectionChanged )
	        {
	            base.OnCollectionChanged( e );
	        }
	    }
	}
```
```VB.NET
	Public Class AddRangeObservableCollection(Of T)
	    Inherits ObservableCollection(Of T)
	    Private suppressOnCollectionChanged As Boolean
	    Public Sub AddRange(items As IEnumerable(Of T))
	        If items Is Nothing Then
	            Throw New ArgumentNullException("items")
	        End If
	        If items.Any() Then
	            Try
	                Me.suppressOnCollectionChanged = True
	                For Each item As Object In items
	                    Me.Add(item)
	                Next
	            Finally
	                Me.suppressOnCollectionChanged = False
	                Me.OnCollectionChanged(New NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset))
	            End Try
	        End If
	    End Sub
	    Protected Overloads Overrides Sub OnCollectionChanged(e As NotifyCollectionChangedEventArgs)
	        If Not Me.suppressOnCollectionChanged Then
	            MyBase.OnCollectionChanged(e)
	        End If
	    End Sub
	End Class
```

## See Also
 * [Overview]({%slug radchart-overview%})
 * [Populating with Data - Overview]({%slug radchart-populating-with-data-overview%})