---
title: Get Media Information
page_title: Get Media Information
description: 
slug: radwebcam-features-get-media-information
tags: mediafoundationdeviceinfo, mediafoundationvideoformatinfo
published: True
position: 1
---

# Get Media Information

The RadWebCam API allows you to get information about the connected devices (cameras) and change the control's device and video format.

## MediaFoundationDeviceInfo

The __MediaFoundationDeviceInfo__ object provides information about the connected device (camera or microphone). This object is used by the control to read audio and video.

## MediaFoundationVideoFormatInfo

The __MediaFoundationVideoFormatInfo__ object provides information about the video format used by the connected camera.

## Video and Audio Capture Devices

By default the control gets and connects to the first camera and microphone devices it finds. To change this you can set the __VideoCaptureDevice__ and __AudioCaptureDevice__ properties of RadWebCam. Or call the parameterized overload of the __Start__ method. 

> See how to use the __Start__ method in the [Getting Started]({%slug radwebcam-getting-started%}#connect-to-the-webcam-manually) article.

## Get Video and Audio Capture Devices

To get the available video capture devices (cameras), use the __RadWebCam.GetVideoCaptureDevices__ static method.

#### __[C#] Example 1: Getting the available cameras__
{{region radwebcam-features-get-media-information-0}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();
{{endregion}}

To get the available audio capture devices (microphones), use the __RadWebCam.GetAudioCaptureDevices__ static method.

#### __[C#] Example 2: Getting the available microphones__
{{region radwebcam-features-get-media-information-1}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> audioDevices = RadWebCam.GetAudioCaptureDevices();
{{endregion}}

## Get Video Formats

To get the available video file formats for the connnected device you can use the __RadWebCam.GetVideoFormats__ static method.

#### __[C#] Example 3: Getting the available video formats__
{{region radwebcam-features-get-media-information-2}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
{{endregion}}

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [SnapshotTaken]({%slug radwebcam-events%})
