---
title: CalloutPopupSettings
page_title: CalloutPopupSettings
description: Check our &quot;Overview&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-features-calloutpopupsettings
tags: calloutpopupsettings
published: True
position: 0
---

# CalloutPopupSettings

The __CalloutPopupSettings__ class provides properties to control the display of RadCallout. 

This article will list the key properties provided by the __CalloutPopupSettings__ class.

* __AutoClose__: A __boolean__ property that gets or sets a value indicating whether the host Popup of the callout will automatically close. By default, the control will capture the mouse, so clicking outside of the RadCallout, will close it. When this behavior is disabled, the control can be closed from the __CalloutPopupService.Close() or CloseAll()__ method.

* __ShowAnimationType__: A property of type __CalloutAnimation__ that gets or sets the type of shown animation. 
	
* __CloseAnimationType__: A property of type __CalloutAnimation__ that gets or sets the type of close animation.

	The __CalloutAnimation__ is an enumeration and it allows the following values:
	* __None__ 
	* __Fade__ 
	* __Move__ 
	* __FadeAndMove__ 
	* __Reveal__ 
	* __FadeAndReveal__ 
	* __Scale__ 
	* __FadeAndScale__ 

* __ShowAnimationDuration__: A property of type __double__ that gets or sets a duration of the animation when shown, in seconds.

* __CloseAnimationDuration__: A property of type __double__ that gets or sets a duration of the animation when closed, in seconds.

* __ShowAnimationEasing__: A property of type __IEasingFunction__ that gets or sets the easing function of the shown animation.

* __CloseAnimationEasing__: A property of type __IEasingFunction__ that gets or sets the easing function of the close animation.

* __ShowAnimationDelay__: A property of type __double__ that gets or sets a delay of the animation when shown, in seconds.

* __CloseAnimationDelay__: A property of type __double__ that gets or sets a delay of the animation when closed, in seconds.

* __MoveWithPlacementTargetParentWindow__: A __boolean__ property that gets or sets a value indicating whether the host popup will move along with the parent window of the placement target. 

>This property has effect only when __Telerik.Windows.Controls.CalloutPopupSettings.AutoClose__ is __false__.

* __ShowPopupExceedingScreen__: A __boolean__ property that gets or sets a value indicating whether the popup will be shown in intended placement position even if it exceeds the monitor boundaries. Default value is __false__.
 
* __Placement__: A property of type __PlacementMode__ that gets or sets the placement of the Popup host. The __PlacementMode__ is an enumeration and it allows the following values:

	* __Absolute__: The Popup will be positioned in the top-left corner of the __screen__. If the screen edge obscures the Popup, the control then repositions itself to align with the edge.
	* __Relative__: The Popup will be positioned in the top-left corner of the __PlacementTarget__ element.
	* __Bottom__: The Popup control will align its upper/left edge with the lower/left edge of the __PlacementTarget__ element.
	* __Center__: The Popup control will be centered over the PlacementTarget element.
	* __Right__: The Popup control will align its left/upper edge with the right/upper edge of the __PlacementTarget__ element.
	* __AbsolutePoint__: The Popup will be positioned in the top-left corner of the __screen__. If the screen edge obscures the Popup, the control extends opposite the axis defined by the HorizontalOffset or VerticalOffset property.
	* __RelativePoint__: The Popup control will align its upper/left edge with the lower/left edge of the __PlacementTarget__ element. If the screen edge obscures the Popup, the control extends opposite the axis defined by the HorizontalOffset or VerticalOffset property.
	* __Mouse__: The Popup control will align with the lower edge of the mouse's bounding box and align its left edge with the left edge of the mouse's bounding box.
	* __MousePoint__: The Popup control will be placed in position relative to the tip of the mouse cursor.
	* __Left__: The Popup control will align its right edge with the left edge of the __PlacementTarget__ and align its upper edge with the upper edge of the __PlacementTarget__ element.
	* __Top__: The Popup control will align its lower edge with the upper edge of the PlacementTarget and align its left edge with the left edge of the PlacementTarget.
	* __Custom__: The Popup will be positioned and repositioned depending on the __CustomPopupPlacementCallback__ property of the Popup.
		
* __AutoCenter__: A __boolean__ property that gets or sets a value indicating whether the Popup will be auto-centered to the placement target. By default, this behavior is enabled and will offset the control so that it is centered to its target. The RadCallout can be additionally offset by using the following properties.

* __VerticalOffset__: A __boolean__ property that gets or sets the vertical offset of the host Popup. Default value is 0.

* __HorizontalOffset__: A __boolean__ property that gets or sets the horizontal offset of the host Popup. Default value is 0.

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
* [CalloutPopupService]({%slug radcallout-features-calloutpopupservice%})
