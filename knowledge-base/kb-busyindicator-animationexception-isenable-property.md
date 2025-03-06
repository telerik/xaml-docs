---
title: AnimationException in WPF RadBusyIndicator 
description: Cannot animate the IsEnabled property on a System.Windows.Controls.ContentControl using a System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames in BusyIndicator for WPF.
type: troubleshooting
page_title: AnimationException - Cannot animate the IsEnabled property on System.Windows.Controls.ContentControl Error on BudyIndicator Unloading
slug: radbusyindicator-wpf-crash-animation
tags: radbusyindicator, wpf, crash, animation, isenabled, tab, tear-out
res_type: kb
ticketid: 1679952
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadBusyIndicator for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.4.1111</td>
</tr>
</tbody>
</table>

## Description

`AnimationException` can be thrown when the RadBusyIndicator is unloaded from the visual tree. For example, drag out a RadPane that contains the indicator from the docking control.

The error message is `Cannot animate the 'IsEnabled' property on a 'System.Windows.Controls.ContentControl' using a 'System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames'. `

The complete stacktrace is the following:

```
	System.Windows.Media.Animation.AnimationException: Cannot animate the 'IsEnabled' property on a 'System.Windows.Controls.ContentControl' using a 'System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames'. For details see the inner exception.
	 ---> System.InvalidOperationException: The enumerator is not valid because the collection changed.
	   at System.Windows.Media.VisualCollection.Enumerator.MoveNext()
	   at System.Windows.FrameworkElement.InvalidateForceInheritPropertyOnChildren(DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.CoerceValue(DependencyProperty dp)
	   at System.Windows.FrameworkElement.InvalidateForceInheritPropertyOnChildren(DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.CoerceValue(DependencyProperty dp)
	   at System.Windows.FrameworkElement.InvalidateForceInheritPropertyOnChildren(DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.CoerceValue(DependencyProperty dp)
	   at System.Windows.FrameworkElement.InvalidateForceInheritPropertyOnChildren(DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.CoerceValue(DependencyProperty dp)
	   at System.Windows.UIElement.InvalidateForceInheritPropertyOnChildren(Visual v, DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.CoerceValue(DependencyProperty dp)
	   at System.Windows.UIElement.InvalidateForceInheritPropertyOnChildren(Visual v, DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.CoerceValue(DependencyProperty dp)
	   at System.Windows.UIElement.InvalidateForceInheritPropertyOnChildren(Visual v, DependencyProperty property)
	   at System.Windows.UIElement.OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.Media.Animation.AnimationStorage.OnCurrentTimeInvalidated(Object sender, EventArgs args)
	   --- End of inner exception stack trace ---
	   at System.Windows.Media.Animation.AnimationStorage.OnCurrentTimeInvalidated(Object sender, EventArgs args)
```

## Solution

To work this around, extract and modify the ControlTemplate of RadBusyIndicator.

The exact modification is to replace the `ObjectAnimationUsingKeyFrames` that animates the `(Control.IsEnabled)` property.

```xml
	<BooleanAnimationUsingKeyFrames BeginTime="00:00:00" Duration="00:00:00.001" Storyboard.TargetName="Content" Storyboard.TargetProperty="(Control.IsEnabled)">
		<DiscreteBooleanKeyFrame KeyTime="00:00:00">
			<DiscreteBooleanKeyFrame.Value>
				<sys:Boolean>False</sys:Boolean>
			</DiscreteBooleanKeyFrame.Value>
		</DiscreteBooleanKeyFrame>
	</BooleanAnimationUsingKeyFrames>
```
