---
title: Bring a Location into View
page_title: Bring a Location into View
description: Bring a Location into View
slug: radmap-how-to-bring-a-location-into-view
tags: bring,a,location,into,view
publish: True
position: 5
---

# Bring a Location into View



## 

In order to bring a location point into view, you simply have to set the __Center__ property of the __RadMap__ property. Here is an example:

#### __XAML__

{{region radmap-how-to-bring-a-location-into-view_0}}
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480" />
	{{endregion}}



#### __C#__

{{region radmap-how-to-bring-a-location-into-view_1}}
	private void BringLocationIntoView( Location desiredLocation )
	{
	    this.radMap.Center = desiredLocation;
	}
	{{endregion}}



#### __VB.NET__

{{region radmap-how-to-bring-a-location-into-view_2}}
	Private Sub BringLocationIntoView(ByVal desiredLocation As Location)
	 Me.radMap.Center = desiredLocation
	End Sub
	{{endregion}}



# See Also

 * [Navigation]({%slug radmap-features-navigation%})

 * [Set the Best View for the InformationLayer]({%slug radmap-how-to-set-the-best-view-for-the-informationlayer%})

 * [Put a Mark on the clicked Location]({%slug radmap-how-to-put-a-mark-on-the-clicked-location%})
