---
title: Set the Best View for the InformationLayer
page_title: Set the Best View for the InformationLayer
description: Check our &quot;Set the Best View for the InformationLayer&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-how-to-set-the-best-view-for-the-informationlayer
tags: set,the,best,view,for,the,informationlayer
published: True
position: 3
---

# Set the Best View for the InformationLayer

In case you have a set of elements displayed by the __InformationLayer__, you might want to be able to display all of them in the visible area of the map and to set the optimal zoom for them. This can be done by using the __Best View__ feature of the __RadMap__. To use it you have to call the __GetBestView()__ method of the __InformationLayer__ and pass its items to it. This method will return a LocationRect object which represents the best view for the items in the __InformationLayer__. You can use it in order to adjust the __RadMap__ center and zoom level. Here is an example:        

#### __C#__
```C#
	private void SetBestView()
	{
	    LocationRect rect = this.informationLayer.GetBestView(this.informationLayer.Items.Cast<object>());
	    rect.MapControl = this.radMap;
	    this.radMap.Center = rect.Center;
	    this.radMap.ZoomLevel = rect.ZoomLevel;
	}
```

#### __VB.NET__
```VB.NET
	Private Sub SetBestView()
		Dim rect As LocationRect = Me.informationLayer.GetBestView(Me.informationLayer.Items.Cast(Of Object)())
		rect.MapControl = Me.radMap
		Me.radMap.Center = rect.Center
		Me.radMap.ZoomLevel = rect.ZoomLevel
	End Sub
```

## See Also
 * [Information Layer]({%slug radmap-features-information-layer%})
 * [Navigation]({%slug radmap-features-navigation%})
 * [Put a Mark on the clicked Location]({%slug radmap-how-to-put-a-mark-on-the-clicked-location%})
 * [Bring a Location into View]({%slug radmap-how-to-bring-a-location-into-view%})