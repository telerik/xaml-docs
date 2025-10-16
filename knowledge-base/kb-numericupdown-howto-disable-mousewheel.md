---
title: How to Disable the Scroll Wheel in RadNumericUpDown
description: Remove the effect of the mouse wheel in RadNumericUpDown.
type: how-to
page_title: Ignore the Effect of the Mouse Wheel in RadNumericUpDown
slug: kb-numericupdown-howto-disable-mousewheel
position: 0
ticketid: 1401368
tags: numericupdown,disable,mouse,scroll,wheel
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1 318</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadNumericUpDown for WPF and Silverlight</td>
	</tr>
</table>

## Description

How to disable the RadNumericUpDown mouse wheel functionality.

## Solution

You can disable the scroll wheel functionality of the RadNumericUpDown control globally by defining an [attached behavior]({%slug common-mvvm-attached-behavior%}).

__MouseWheelBehavior.cs__
```C#
	public class MouseWheelBehavior
	{
			public static bool GetIsEnabled(DependencyObject obj)
			{
					return (bool)obj.GetValue(IsEnabledProperty);
			}
	
			public static void SetIsEnabled(DependencyObject obj, bool value)
			{
					obj.SetValue(IsEnabledProperty, value);
			}
			
			public static readonly DependencyProperty IsEnabledProperty =
					DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(MouseWheelBehavior), new PropertyMetadata(true, OnIsEnabledChanged));
	
			private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
			{
					if (!(bool)e.NewValue)
					{
							var upDown = d as RadNumericUpDown;
							upDown.AddHandler(RadNumericUpDown.PreviewMouseWheelEvent, new MouseWheelEventHandler((s, a) => { a.Handled = true; }), true);
					}
			}
	}
```

You can then set this behavior via an implicit style to all instances in your application.

__App.xaml__
```XAML
	<Style TargetType="telerik:RadNumericUpDown">
			<Setter Property="local:MouseWheelBehavior.IsEnabled" Value="False" />
	</Style>
```

## See Also

* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [RadNumericUpDown Key Properties]({%slug radnumericupdown-behavior%})
