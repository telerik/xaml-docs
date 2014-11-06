---
title: How to use the Events
page_title: How to use the Events
description: How to use the Events
slug: radnumericupdown-howto-events
tags: how,to,use,the,events
published: True
position: 1
site_name: Silverlight
---

# How to use the Events

RadNumericUpDown inherits several common events that can be used to improve the functionality of the control.

Here is a brief list of all events exposed by __RadNumericUpDown__.

* __BindingValidationError__ - Inherited from System.Windows.FrameworkElement

* __GotFocus__ - Inherited from System.Windows.UIElement

* __KeyDown__ - Inherited from System.Windows.UIElement

* __KeyUp__ - Inherited from System.Windows.UIElement 

* __LayoutUpdated__ - Inherited from System.Windows.FrameworkElement

* __Loaded__ - Inherited from System.Windows.FrameworkElement 

* __LostFocus__ - Inherited from System.Windows.UIElement)  

* __MouseEnter__ - Inherited from System.Windows.UIElement

* __MouseLeave__ - Inherited from System.Windows.UIElement

* __MouseLeftButtonDown__ - Inherited from System.Windows.UIElement

* __MouseLeftButtonUp__ - Inherited from System.Windows.UIElement

* __MouseMove__ - Inherited from System.Windows.UIElement

* __SizeChanged__ - Inherited from System.Windows.FrameworkElement

* __ValueChanged__ - Inherited from System.Windows.Controls.Primitives.RangeBase

Here is an example of how to use the __ValueChanged__ event that is raised whenever the value of __RadNumericUpDown__ is changed:

#### __C#__

{{region radnumericupdown-howto-events_0}}
	public void Events()
	{
		RadNumericUpDown numeric = new RadNumericUpDown();
		numeric.ValueChanged += new RoutedPropertyChangedEventHandler<double>(OnNumericValueChanged);
		numeric.Value = 10;
	}
	private void OnNumericValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		 RadWindow.Alert(String.Format("New value: {0}, Old value: {1}", e.NewValue, e.OldValue));
	}
{{endregion}}

#### __VB.NET__

{{region radnumericupdown-howto-events_1}}
	Private Sub Events()
		Dim numeric As RadNumericUpDown = New RadNumericUpDown
		AddHandler numeric.ValueChanged, AddressOf OnNumericValueChanged
		numeric.Value = 10;
	End Sub
	Private Sub OnNumericValueChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of double))
		RadWindow.Alert(String.Format("New value: {0}, Old value: {1}", e.NewValue, e.OldValue))
	End Sub
{{endregion}}