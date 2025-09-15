---
title: Resolve RadGauge ArgumentException - The provided DependencyObject is not a context for this Freezable
description: Resolve the provided DependencyObject is not a context for this Freezable error when animated marker is used.
type: how-to
page_title: ArgumentException - The provided DependencyObject is not a context for this Freezable (RadGauge)
slug: kb-gauge-dependencyobject-not-context-for-this-freezable
position: 
tags: 
ticketid: 1412188
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2017.2.614</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGauge for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to resolve ArgumentException with message "The provided DependencyObject is not a context for this Freezable.", when using RadGauge controls.

StackTrace:
	
   Exception: System.ArgumentException: The provided DependencyObject is not a context for this Freezable.
   Parameter name: context
   at System.Windows.Freezable.RemoveContextInformation(DependencyObject context, DependencyProperty property)
   at System.Windows.Freezable.RemoveInheritanceContext(DependencyObject context, DependencyProperty property)
   at System.Windows.DependencyObject.RemoveSelfAsInheritanceContext(DependencyObject doValue, DependencyProperty dp)
   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
   at System.Windows.DependencyObject.SetValueCommon(DependencyProperty dp, Object value, PropertyMetadata metadata, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType, Boolean isInternal)
   at System.Windows.DependencyObject.SetValue(DependencyProperty dp, Object value)
   at Telerik.Windows.Controls.Gauge.ScaleObject.RangeChangedHandler(DependencyObject source, DependencyPropertyChangedEventArgs eventArgs)
   .......


## Solution

This can happen in a scenario with multiple gauge controls with animated indicators (like the [Needle]({%slug radgauge-features-indicators-needle%}) element) that are updated very fast at runtime (on a small time interval). To resolve this, disable the animation of the indicators. To do this set their __IsAnimated__ property to False.


```XAML
	<telerik:Needle IsAnimated="False" /> 
```
