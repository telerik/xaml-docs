---
title: Use the Telerik EventToCommandBehavior in Style Setter
description: How to add  EventBinding objects to EventToCommandBehavior in a WPF Style Setter.
type: how-to
page_title: Adding Event to Command Behavior's EventBindings for a Control in Style Setter
slug: kb-common-eventtocommandbehavior-style-setter
tags: radchartview, wpf, mvvm, cartesiangridlineannotation, mouseevents
res_type: kb
ticketid: 1674339
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>Telerik UI for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2022.3.1109</td>
</tr>
</tbody>
</table>

## Description

How to add [EventToCommandBehavior's]({%slug common-event-to-command-behavior%}) EventBinding objects in a WPF Style Setter.

## Solution

The `EventToCommandBehavior.EventBindings` attached collection property cannot be assigned, so EventBindings cannot be added in a Style `Setter` element. To do this, you can implement an [attached property](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/attached-properties-overview?view=netframeworkdesktop-4.8) that adds `EventBinding` objects in the C# code.

Implementing the attached property.

```csharp
	public static class EventToCommandBehaviorUtilities
	{
		public static EventBindingCollection GetEventBindings(DependencyObject obj)
		{
			return (EventBindingCollection)obj.GetValue(EventBindingsProperty);
		}

		public static void SetEventBindings(DependencyObject obj, EventBindingCollection value)
		{
			obj.SetValue(EventBindingsProperty, value);
		}
				
		public static readonly DependencyProperty EventBindingsProperty =
			DependencyProperty.RegisterAttached("EventBindings", typeof(EventBindingCollection), typeof(EventToCommandBehaviorUtilities), new PropertyMetadata(null, OnEventBindingsChanged));

		private static void OnEventBindingsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var eventBindingsCollection = EventToCommandBehavior.GetEventBindings(d);
			if (e.OldValue != null)
			{
				foreach (EventBinding item in (EventBindingCollection)e.OldValue)
				{
					eventBindingsCollection.Remove(item);
				}
			}

			if (e.NewValue != null)
			{
				foreach (EventBinding item in (EventBindingCollection)e.NewValue)
				{
					eventBindingsCollection.Add(item);
				}
			}
		}
	}
```

Using the attached property.

```xaml
	<Style TargetType="Border">
		 <Setter Property="local:EventToCommandBehaviorUtilities.EventBindings">
			 <Setter.Value>
				 <telerik:EventBindingCollection>
					 <telerik:EventBinding EventName="MouseLeftButtonDown" Command="{Binding MyMouseLeftButtonDownCommand}" />
					 <telerik:EventBinding EventName="MouseMove" Command="{Binding MyMouseMoveCommand}" />
				 </telerik:EventBindingCollection>
			 </Setter.Value>
		 </Setter>
	</Style>
```

