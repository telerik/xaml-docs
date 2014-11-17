---
title: Properties
page_title: Properties
description: Properties
slug: radtimeline-properties
tags: properties
published: True
position: 0
---

# Properties

This help topic will make you familiar with the most important properties, settings and elements of the RadTimeline control:

__ItemsSource__ - gets or sets the data source used to generate the content of the timeline control. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow.        

__Supported Data Sources__

You can bind __RadTimeline__ to a data source that implements one of the following interfaces:        

* [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) - supports simple iteration of a collection. See the MSDN article for more on [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx).         
* [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) - extends [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) and supports size, enumerator, and synchronization methods for collections.          
* [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) - extends [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) and is the base class for lists.          

__Change Notification Support__

__RadTimeline__ also provides full support for change notifications - changes in data sources that implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx), as well as [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20),  are properly tracked and reflected by the UI.        

Some of the implementations of these interfaces include:

* [Array](http://msdn.microsoft.com/en-us/library/system.array.aspx)
* [ArrayList](http://msdn.microsoft.com/en-us/library/system.collections.arraylist.aspx)
* [CollectionBase](http://msdn.microsoft.com/en-us/library/system.collections.collectionbase.aspx) objects
* [DataTable](http://msdn.microsoft.com/en-us/library/system.data.datatable.aspx)
* [Generic Lists](http://msdn2.microsoft.com/en-us/library/6sh2ey19.aspx)
* [ObservableCollection](http://msdn.microsoft.com/en-us/library/ms668604.aspx)

__StartPath__ - sets the name of the property from the underlying datasource, which will determine the start time for the data.
        __DurationPath__ - sets the name of the property from the underlying datasource, which will determine the end time for the data.
        __VisiblePeriodStart and VisiblePeriodEnd__ - set the names of the properties from the underlying datasource,
        which will determine the visible start and end time for the data.
        __PeriodStart and PeriodEnd__ – these properties determine the start and end time period in the Timeline control.
        __Intervals__

Currently the supported intervals are:

* Century;
* Decade;
* Year;
* Quarter;
* Month;
* Week;
* Day;
* Hour;
* Minute;
* Second;
* Millisecond;

A sample Intervals section may look like this:

#### __XAML__

{{region radtimeline-properties_0}}
	 <telerik:RadTimeline.Intervals>
	       <telerik:CenturyInterval />
	       <telerik:DecadeInterval />
	       <telerik:YearInterval />
	       <telerik:MonthInterval/>
	  </telerik:RadTimeline.Intervals>
	{{endregion}}



__IntervalSpans__ - this property can be used to group the given Interval Items Together. For example setting:
        

#### __XAML__

{{region radtimeline-properties_1}}
	<telerik:RadTimeline.Intervals>
	   <telerik:YearInterval IntervalSpans="10"/>
	</telerik:RadTimeline.Intervals>
	{{endregion}}



will make the years in groups with 10 each. You can also set more than one *IntervalSpan* simultaneously by separating them with comma:
        

#### __XAML__

{{region radtimeline-properties_2}}
	<telerik:RadTimeline.Intervals>
	   <telerik:YearInterval IntervalSpans="1,5" />
	   <telerik:MonthInterval IntervalSpans="1,6" />
	</telerik:RadTimeline.Intervals>
	{{endregion}}


