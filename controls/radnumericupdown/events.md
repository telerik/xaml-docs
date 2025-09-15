---
title: Events
page_title: Events
description: This article lists the events exposed by the RadNumericUpDown.
slug: radnumericupdown-events
tags: events
published: True
position: 3
---

# Events

RadNumericUpDown inherits several common events that can be used to customize the functionality of the control.

Here is a brief list of all events exposed by __RadNumericUpDown__.

* __GotFocus__: Occurs when the control receives focus. Inherited from **UIElement**.

* __KeyDown__: Occurs when a key is pressed while the focus is on this element. Inherited from **UIElement**.

* __KeyUp__: Occurs when a key is released while the focus is on this element. Inherited from **UIElement**.

* __LayoutUpdated__: Occurs when the layout of the various visual elements associated with the current Dispatcher changes. Inherited from **FrameworkElement**.

* __Loaded__: Occurs when the element is laid out, rendered, and ready for interaction. Inherited from **FrameworkElement**.

* __LostFocus__: Occurs when this element loses logical focus. Inherited from **UIElement**.

* __MouseEnter__: Occurs when the mouse pointer enters the bounds of this element. Inherited from **UIElement**.

* __MouseLeave__: Occurs when the mouse pointer leaves the bounds of this element. Inherited from **UIElement**.

* __MouseLeftButtonDown__: Occurs when the left mouse button is pressed while the mouse pointer is over this element. Inherited from **UIElement**.

* __MouseLeftButtonUp__: Occurs when the left mouse button is released while the mouse pointer is over this element. Inherited from **UIElement**.

* __MouseMove__: Occurs when the mouse pointer moves while over this element. Inherited from **UIElement**.

* __SizeChanged__: Occurs when either the ActualHeight or the ActualWidth properties change value on this element. Inherited from **FrameworkElement**.

* __ValueChanged__: Occurs when the range value changes. Inherited from **RangeBase**.

Here is an example of how to use the __ValueChanged__ event that is raised whenever the value of __RadNumericUpDown__ is changed:

__Example 1: Handling the ValueChanged event__

```C#
	private void NumericUpDown_ValueChanged(object sender, RadRangeBaseValueChangedEventArgs e)
	{
		MessageBox.Show("New value is: " + e.NewValue + "\nOld value was: " + e.OldValue);
	}
```
```VB.NET
	Private Sub NumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As RadRangeBaseValueChangedEventArgs)
		MessageBox.Show("New value is: " & e.NewValue & ControlChars.Lf & "Old value was: " & e.OldValue)
	End Sub
```
