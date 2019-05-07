---
title: Video Flip
page_title: Video Flip
description: This article shows how to flip the video using the FlipHorizontally and FlipVertically properties of RadWebCam.
slug: radwebcam-features-video-flip
tags: vertical,horizontal,flip
published: True
position: 4
---

# Video Flip

RadWebCam allows you to chanage the flip of the video feed from the attached camera. To do this, set the __FlipVertically__ and __FlipHorizontally__ properties of RadWebCam to __true__.

#### __[XAML] Example 1: Setting the flip in XAML__
{{region radwebcam-features-video-flip-0}}
	<telerik:RadWebCam FlipVertically="True" FlipHorizontally="True" />
{{endregion}}

#### __[C#] Example 2: Setting the flip in code__
{{region radwebcam-features-video-flip-1}}
	this.radWebCam.FlipVertically = true;
	this.radWebCam.FlipHorizontally = true;
{{endregion}}

#### Figure 1: Flipped Video
![](images/radwebcam-features-video-flip-0.png)

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Unavailable Camera Content]({%slug radwebcam-features-no-camera-content%})
* [SnapshotTaken]({%slug radwebcam-events%})
