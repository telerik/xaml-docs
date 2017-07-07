---
title: Conversion API
page_title: Conversion API
description: Conversion API
slug: radtimeline-features-conversion-api
tags: conversion,api,convertpointtodatetime
published: True
position: 13
---

# Conversion API 

__RadTimeline__ allows you to convert a screen coordinates (a Point), to a DateTime value plotted on the timebar control. You can do that via the __ConvertPointToDateTime__ method of RadTimeline. The method excepts an argument of type __Point__ and it returns a __DateTime__ object.

#### __[C#] Example 1: Getting the DateTime under the mouse__ 
{{region radtimeline-features-conversion-api-0}}
	private void UIElement_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		Point mousePosition = e.GetPosition(radTimeline);
		DateTime date = radTimeline.ConvertPointToDateTime(mousePosition);
	}
{{endregion}}

## See Also
 * [Getting Started]({%slug radtimebar-mvvm-support%})
 * [Properties]({%slug radtimebar-properties%})
