---
title: Zooming
page_title: Zooming
description: This article demonstrates the zooming capabilities of the RadImageEditor control.
slug: radimageeditor-features-zooming
tags: zooming
published: True
position: 4
---

# Zooming

RadImageEditor provides out of the box zooming functionality. 

You can zoom in the opened image by holding **Ctrl** and spinning the **mouse wheel** or by using the slider and dropdown of the **ZoomController** provided by the [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%}).

#### Figure 1: Default zoom capabilities 
![Default zoom capabilities](images/default-zoom.gif)

## Disabling the MouseWheel Zooming

In order to disable the zooming with the mouse wheel, you can set the __AllowMouseWheelScaling__ property to __False__ as demonstrated in __Example 1__. 

__Example 1: Setting the AllowMouseWheelScaling property__
<snippet id='radimageeditor-features-zooming-example_1_setting_the_allowmousewheelscaling_property-xaml' />


## Zoom to Mouse Cursor

As can be seen in **Figure 1**, the default zooming mechanism does not take into account the position of the mouse cursor.

As of version **2018.2.716**, both RadImageEditor and RadImageEditorUI controls expose a **ZoomToCursor** property. By setting this property to **True**, holding **Ctrl** and spinning the **mouse wheel** will zoom towards the position of the mouse cursor. The result can be observed in **Figure 2**.

#### Figure 2: Zooming to the mouse cursor  
![Zooming to the mouse cursor](images/zoom-to-cursor.gif)

## Zooming Programmatically

The RadImageEditor API allows you to zoom programmatically via the __ScaleFactor__ property. 

The minimum allowed scale factor is 0, which is the default value. Setting ScaleFactor to 0 __autoscales__ the image. You can also do this by calling the RadImageEditor's __AutoScaleImage__ method.

The __value of 1__ means that the image is not zoomed-in and its original size is used. A value __less than 1__, zooms-out the image. A value __greater than 1__, zooms-in the image.

__Example 2: Setting ScaleFactor to zoom-in the image__
<snippet id='radimageeditor-features-zooming-example_2_setting_scalefactor_to_zoom_in_the_image-xaml' />


To get the actual scale factor, when the picture is autoscaled, check the __ActualScaleFactor__ property.

To listen for changes in the zoom level, use the __ScaleFactorChanged__ event of RadImageEditor.

__Example 3: Subscribing to the ScaleFactorChanged event__
<snippet id='radimageeditor-features-zooming-example_3_subscribing_to_the_scalefactorchanged_event-xaml' />


__Example 4: Defining ScaleFactorChanged event handler__
<snippet id='radimageeditor-features-zooming-example_4_defining_scalefactorchanged_event_handler-cs' />


## Using the Zoom Controller

The [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%}) control has a built-in zoom controller (a slider) element that allows you to zoom in and out. The slider is shown in __Figure 1__.

To use the control separately with __RadImageEditor__, you can define the __ZoomController__ element, and set its __ImageEditor__ control.

__Example 5: Using ZoomController__
<snippet id='radimageeditor-features-zooming-example_5_using_zoomcontroller-xaml' />


#### Figure 3: ZoomController
![{{ site.framework_name }} RadImageEditor ZoomController](images/radimageeditor-features-zooming-0.png)

## See Also  
 * [History]({%slug radimageeditor-features-history%})
 * [Panning]({%slug radimageeditor-tools-panning%})