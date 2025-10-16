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

__Setting the flip in XAML__
```XAML
	<telerik:RadWebCam FlipVertically="True" FlipHorizontally="True" />
```

__Setting the flip in code__
```C#
	this.radWebCam.FlipVertically = true;
	this.radWebCam.FlipHorizontally = true;
```

__Flipped Video__

![{{ site.framework_name }} RadWebCam Flipped Video](images/radwebcam-features-video-flip-0.png)

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Events]({%slug radwebcam-events%})
* [Errors]({%slug radwebcam-features-errors%})
