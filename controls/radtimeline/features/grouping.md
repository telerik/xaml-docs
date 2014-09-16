---
title: Grouping
page_title: Grouping
description: Grouping
slug: radtimeline-features-grouping
tags: grouping
publish: True
position: 7
---

# Grouping



The timeline items in a RadTimeline control can be displayed in groups.
        Additionally, groups of timeline items can be made expandable/collapsible.
      

This help topic contains the following information:
      

* [Properties](#properties)

* [Group Expand Modes](#group-expand-modes)

* [Changing the default collapsed state of expandable groups](#changing-the-default-collapsed-state-of-expandable-groups)

## Properties

__GroupPath__

The path to the Group source property.
        

__GroupExpandMode__

A GroupExpandMode value that indicates the group expand mode for a
          RadTimeline instance. The default value is None. Setting the
          GroupExpandMode property of a RadTimeline control changes
          the behavior of the control only if the GroupPath
          property is set to a valid path.
        

## Group Expand Modes

__None (Default)__

A value of None indicates that the groups of timeline items of
          the RadTimeline instance are expanded by default and cannot be
          collapsed.
        

The following example demonstrates how you can group the timeline
          items of a RadTimeline control:
        

#### __XAML__

{{region radtimeline-features-grouping-0}}
	<!-- GroupPath is specified and GroupExpandMode is set to None -->
	<telerik:RadTimeline PeriodStart="2011-01-01"
	                     PeriodEnd="2012-01-01"
	                     VisiblePeriodStart="2011-01-01"
	                     VisiblePeriodEnd="2011-02-01"
	                     StartPath="StartDate"
	                     DurationPath="Duration"
	                     GroupPath="GroupName"
	                     GroupExpandMode="None"
	                     ItemsSource="{Binding TimelineItems}">
	    <telerik:RadTimeline.Intervals>
	        <telerik:YearInterval />
	        <telerik:MonthInterval />
	        <telerik:WeekInterval />
	        <telerik:DayInterval />
	    </telerik:RadTimeline.Intervals>
	</telerik:RadTimeline>
	{{endregion}}

![Rad Timeline-features-grouping-0-Group Expand Mode-None](images/RadTimeline-features-grouping-0-GroupExpandMode-None.jpg)

__Single__

The Single value indicates that only a single group of timeline items 
          can be expanded at a time. By default, all groups of timeline items 
          are collapsed in this mode.
        

The following example demonstrates how you can group the timeline items of a 
          RadTimeline control and set Single group expand mode:
        

#### __XAML__

{{region radtimeline-features-grouping-1}}
	<!-- GroupPath is specified and GroupExpandMode is set to Single -->
	<telerik:RadTimeline PeriodStart="2011-01-01"
	                     PeriodEnd="2012-01-01"
	                     VisiblePeriodStart="2011-01-01"
	                     VisiblePeriodEnd="2011-02-01"
	                     StartPath="StartDate"
	                     DurationPath="Duration"
	                     GroupPath="GroupName"
	                     GroupExpandMode="Single"
	                     ItemsSource="{Binding TimelineItems}">
	    <telerik:RadTimeline.Intervals>
	        <telerik:YearInterval />
	        <telerik:MonthInterval />
	        <telerik:WeekInterval />
	        <telerik:DayInterval />
	    </telerik:RadTimeline.Intervals>
	</telerik:RadTimeline>
	{{endregion}}

![Rad Timeline-features-grouping-1-Group Expand Mode-Single](images/RadTimeline-features-grouping-1-GroupExpandMode-Single.jpg)

__Multiple__

The Multiple value indicates that multiple groups of timeline items can be 
          expanded at a time. By default, all groups of timeline items 
          are collapsed in this mode.
        

The following example demonstrates how you can group the timeline items of a
          RadTimeline control and set Multiple group expand mode:
        

#### __XAML__

{{region radtimeline-features-grouping-2}}
	<!-- GroupPath is specified and GroupExpandMode is set to Multiple -->
	<telerik:RadTimeline PeriodStart="2011-01-01"
	                     PeriodEnd="2012-01-01"
	                     VisiblePeriodStart="2011-01-01"
	                     VisiblePeriodEnd="2011-02-01"
	                     StartPath="StartDate"
	                     DurationPath="Duration"
	                     GroupPath="GroupName"
	                     GroupExpandMode="Multiple"
	                     ItemsSource="{Binding TimelineItems}">
	    <telerik:RadTimeline.Intervals>
	        <telerik:YearInterval />
	        <telerik:MonthInterval />
	        <telerik:WeekInterval />
	        <telerik:DayInterval />
	    </telerik:RadTimeline.Intervals>
	</telerik:RadTimeline>
	{{endregion}}

![Rad Timeline-features-grouping-2-Group Expand Mode-Multiple](images/RadTimeline-features-grouping-2-GroupExpandMode-Multiple.jpg)

## Changing the default collapsed state of expandable groups

>The styles used in this section are __implicit__. In order
            to apply them you have to use NoXAML DLL-s. For more information check the
            [Implicit Styles](http://www.telerik.com/help/silverlight/styling-apperance-implicit-styles-overview.html)
            topic.
          

By default, the groups of timeline items are collapsed when GroupExpandMode 
          is set to either Single or Multiple. You can use the following style 
          to change this default state:
        

#### __XAML__

{{region radtimeline-features-grouping-3}}
	<Style TargetType="telerik:TimelineItemGroupControl" BasedOn="{StaticResource TimelineItemGroupControlStyle}">
	    <Setter Property="IsExpanded" Value="True" />
	</Style>
	{{endregion}}



In order to change the default state of specific groups of timeline items, you can use a converter:
        

#### __XAML__

{{region radtimeline-features-grouping-4}}
	<Style TargetType="telerik:TimelineItemGroupControl" BasedOn="{StaticResource TimelineItemGroupControlStyle}">
	    <Setter Property="IsExpanded" Value="{Binding GroupKey, Converter={StaticResource groupKeyToIsExpandedConverter}}" />
	</Style>
	{{endregion}}



#### __C#__

{{region radtimeline-features-grouping-0}}
	public class GroupKeyToIsExpandedConverter : IValueConverter
	{
	    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	    {
	        string groupKey = value as string;
	
	        if (groupKey != null && groupKey == "Group1")
	            return true;
	
	        return false;
	    }
	
	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
	        throw new NotImplementedException();
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtimeline-features-grouping-0}}
	Public Class GroupKeyToIsExpandedConverter
		Implements IValueConverter
		Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
			Dim groupKey As String = TryCast(value, String)
	
			If groupKey IsNot Nothing AndAlso groupKey = "Group1" Then
				Return True
			End If
	
			Return False
		End Function
	
		Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
			Throw New NotImplementedException()
		End Function
	End Class
	{{endregion}}



# See Also
