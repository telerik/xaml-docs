---
title: Bring a Location into View
page_title: Bring a Location into View
description: Check our &quot;Bring a Location into View&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-how-to-bring-a-location-into-view
tags: bring,a,location,into,view
published: True
position: 5
---

# Bring a Location into View

In order to bring a location point into view, you simply have to set the __Center__ property of the __RadMap__ property. Here is an example:

#### __XAML__
```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480" />
```

#### __C#__
```C#
	private void BringLocationIntoView( Location desiredLocation )
	{
	    this.radMap.Center = desiredLocation;
	}
```

#### __VB.NET__
```VB.NET
	Private Sub BringLocationIntoView(ByVal desiredLocation As Location)
		Me.radMap.Center = desiredLocation
	End Sub
```

## See Also
 * [Navigation]({%slug radmap-features-navigation%})
 * [Set the Best View for the InformationLayer]({%slug radmap-how-to-set-the-best-view-for-the-informationlayer%})
 * [Put a Mark on the clicked Location]({%slug radmap-how-to-put-a-mark-on-the-clicked-location%})