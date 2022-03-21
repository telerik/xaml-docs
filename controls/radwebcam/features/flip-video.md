---
title: Video Flip
page_title: Video Flip
description: This article shows how to flip the video using the FlipHorizontally and FlipVertically properties of RadWebCam.
slug: radwebcam-features-video-flip
tags: vertical,horizontal,flip
published: True
position: 5
---

# Video Flip

The RadWebCam control allows you to change the flip of the video feed from the attached camera. To do this, set the `FlipVertically` and `FlipHorizontally` properties of RadWebCam to `True`.

#### __[XAML] Setting the flip in XAML__
{{region radwebcam-features-video-flip-0}}
	<telerik:RadWebCam FlipVertically="True" FlipHorizontally="True" />
{{endregion}}

#### __[C#] Setting the flip in code__
{{region radwebcam-features-video-flip-1}}
	this.radWebCam.FlipVertically = true;
	this.radWebCam.FlipHorizontally = true;
{{endregion}}

__Flipped Video__

![](images/radwebcam-features-video-flip-0.png)

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Events]({%slug radwebcam-events%})
* [Errors]({%slug radwebcam-features-errors%})
