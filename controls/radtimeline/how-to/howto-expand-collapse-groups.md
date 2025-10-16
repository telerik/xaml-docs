---
title: Expand and Collapse Timeline groups
page_title: Expand and Collapse Timeline groups
description: Check our &quot;Expand and Collapse Timeline groups&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-howto-expand-collapse-groups
tags: expand,and,collapse,timeline,groups
published: True
position: 0
---

# Expand and Collapse Timeline groups

This help topic will provide an overview of the methods for collapsing and expanding Timeline groups.

## Expand All Groups at Start

You can expand all groups of items in the RadTimeline control, using an implicit Style Setter. For example:



```XAML
	<Style TargetType="telerik:TimelineItemGroupControl" BasedOn="{StaticResource TimelineItemGroupControlStyle}">
	    <Setter Property="IsExpanded" Value="True" />
	</Style>
```

## Expand A Group at Start

In case you want to expand a specific group initially, you can use a Converter. For example:        



```XAML
	<local:GroupKeyToIsExpandedConverter x:Key="groupKeyToIsExpandedConverter" />
	<sys:String x:Key="InitiallyExpandedGroup">Group2</sys:String>
	
	<Style TargetType="telerik:TimelineItemGroupControl" BasedOn="{StaticResource TimelineItemGroupControlStyle}">
	    <Setter Property="IsExpanded" Value="{Binding GroupKey, Converter={StaticResource groupKeyToIsExpandedConverter}, ConverterParameter={StaticResource InitiallyExpandedGroup}}" />
	</Style>
```



```C#
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
	    if (value != null && value is string)
	    {
	        string groupKey = (string)value;
	        string initiallyExpandedGroupKey = (string)parameter;
	
	        if (groupKey == initiallyExpandedGroupKey)
	        {
	            return true;
	        }
	    }
	
	    return false;
	}
```
```VB.NET
	Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
		If value IsNot Nothing AndAlso TypeOf value Is String Then
			Dim groupKey As String = DirectCast(value, String)
			Dim initiallyExpandedGroupKey As String = DirectCast(parameter, String)
	
			If groupKey = initiallyExpandedGroupKey Then
				Return True
			End If
		End If
	
		Return False
	End Function
```

## Expand And Collapse Groups through binding (attached property)

There are scenarios, in which the expanded and collapsed state of the groups of timeline items depends on a certain condition In this case, you can use an attached behavior.



```XAML
	<Style TargetType="telerik:TimelineItemGroupControl" BasedOn="{StaticResource TimelineItemGroupControlStyle}">
	    <Setter Property="local:TimelineItemGroupControlBehavior.ExpandedGroupKey" Value="{Binding SelectedItem.Group, ElementName=RadTimeline1}" />
	    <Setter Property="telerik:AnimationManager.IsAnimationEnabled" Value="False" />
	</Style>
```



```C#
	public static readonly DependencyProperty ExpandedGroupKeyProperty = DependencyProperty.RegisterAttached("ExpandedGroupKey",
	    typeof(string), typeof(TimelineItemGroupControlBehavior), new PropertyMetadata(OnExpandedGroupKeyChanged));
	
	public static object GetExpandedGroupKey(DependencyObject obj)
	{
	    return (string)obj.GetValue(ExpandedGroupKeyProperty);
	}
	
	public static void SetExpandedGroupKey(DependencyObject obj, string value)
	{
	    obj.SetValue(ExpandedGroupKeyProperty, value);
	}
	
	private static void OnExpandedGroupKeyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
	{
	    TimelineItemGroupControl timelineGroup = sender as TimelineItemGroupControl;
	    if (timelineGroup == null || e.NewValue == null)
	        return;
	
	    timelineGroup.IsExpanded = string.Equals(timelineGroup.Header, (string)e.NewValue);
	}
```
```VB.NET
	Public Shared ReadOnly ExpandedGroupKeyProperty As DependencyProperty = DependencyProperty.RegisterAttached("ExpandedGroupKey", GetType(String), GetType(TimelineItemGroupControlBehavior), New PropertyMetadata(OnExpandedGroupKeyChanged))
	
	Public Shared Function GetExpandedGroupKey(obj As DependencyObject) As Object
		Return DirectCast(obj.GetValue(ExpandedGroupKeyProperty), String)
	End Function
	
	Public Shared Sub SetExpandedGroupKey(obj As DependencyObject, value As String)
		obj.SetValue(ExpandedGroupKeyProperty, value)
	End Sub
	
	Private Shared Sub OnExpandedGroupKeyChanged(sender As DependencyObject, e As DependencyPropertyChangedEventArgs)
		Dim timelineGroup As TimelineItemGroupControl = TryCast(sender, TimelineItemGroupControl)
		If timelineGroup Is Nothing OrElse e.NewValue Is Nothing Then
			Return
		End If
	
		timelineGroup.IsExpanded = String.Equals(timelineGroup.Header, DirectCast(e.NewValue, String))
	End Sub
```