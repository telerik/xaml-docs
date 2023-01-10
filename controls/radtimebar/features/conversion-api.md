---
title: Conversion API
page_title: Conversion API
description: Check our &quot;Conversion API&quot; documentation article for the RadTimeBar {{ site.framework_name }} control.
slug: radtimebar-features-conversion-api
tags: conversion,api,convertpointtodatetime
published: True
position: 8
---

# {{ site.framework_name }} RadTimeBar Conversion API

__RadTimeBar__ allows you to convert a screen coordinates (a Point), to a DateTime value plotted on the timebar control. You can do that via the __ConvertPointToDateTime__ method of RadTimeBar. The method excepts an argument of type __Point__ and it returns a __DateTime__ object.

#### __[C#] Example 1: Getting the DateTime under the mouse__ 
{{region radtimebar-features-conversion-api-0}}
	private void UIElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		Point mousePosition = e.GetPosition(radTimeBar);
		DateTime date = radTimeBar.ConvertPointToDateTime(mousePosition);
	}
{{endregion}}

## See Also
 * [Getting Started]({%slug radtimebar-mvvm-support%})
 * [Properties]({%slug radtimebar-properties%})
