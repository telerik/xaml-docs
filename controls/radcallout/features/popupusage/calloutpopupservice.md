---
title: CalloutPopupService
page_title: CalloutPopupService
description: Check our &quot;CalloutPopupService&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-features-calloutpopupservice
tags: calloutpopupservice, show, close
published: True
position: 0
---

# CalloutPopupService

The __CalloutPopupService__ class provides methods and events for showing the RadCallout in an animated Popup. The service exposes the following methods.

> The events of the RadCallout are described in the [Events]({%slug radcallout-events%}) help article. 

## Show RadCallout

To display the RadCallout control you can use the __Show()__ method of the CalloutPopupService. The different overloads of the method are listed below.

* **static void Show(RadCallout callout, FrameworkElement placementTarget, CalloutPopupSettings settings)**
* **static void Show(RadCallout callout, FrameworkElement placementTarget)**

## Close RadCallout

To close the RadCallout control you can use the __Close()__ method of the CalloutPopupService. The different overloads of the method are listed below.

* **static void Close(RadCallout callout)**

## Close All Shown RadCallouts

To close all opened RadCallout controls you can use the __CloseAll()__ method of the CalloutPopupService. 

* **static void CloseAll()**

## Disable Animation

To globally disable the animation for all Popups elements holding RadCallout controls, __CalloutPopupService.IsAnimationEnabled__ static property can be set to false.

__Example 1: Disable Animation__
```C#
	public MainWindow()
	{           
		InitializeComponent();
		CalloutPopupService.IsAnimationEnabled = false;
	}
```

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
