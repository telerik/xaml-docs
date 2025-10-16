---
title: Disable Audio Recording
page_title: Disable Audio Recording
description: This article shows how to stop the audio recording when capturing a video.
slug: radwebcam-disable-audio-recording
tags: video,audio,microphone,initialize,mute,stop,disable
published: True
position: 1
---

# Disable Audio Recording

This article shows how to stop the audio recording when a video is captured.

1. Add the control to the logical tree of the view and subscribe to its `Loaded` event. Then, set its `AutoStart` property to `False`.

	__Defining RadWebCam__
	```XAML
		<telerik:RadWebCam x:Name="radWebCam" AutoStart="False" Loaded="RadWebcam_Loaded"/>
	```

2. In the event handler, get the camera device and video format, and call the `Initialize` method of the control. To disable the audio, set the last parameter ("audioDevice") of the Initialize method to `null`. Then start the camera.

	__Starting the camera manually__
	```C#
		private void RadWebcam_Loaded(object sender, RoutedEventArgs e)
		{	    
			ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();            
			ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
			this.radWebCam.Initialize(videoDevices[0], videoFormats[0], null);
			this.radWebCam.Start();
		}
	```

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Recording Video]({%slug radwebcam-features-recording-video%})
* [Media Information]({%slug radwebcam-features-media-information%})
