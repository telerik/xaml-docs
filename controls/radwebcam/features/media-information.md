---
title: Media Information
page_title: Media Information
description: RadWebCam gives the ability to get information about the connected devices (cameras) and change the control's device and video format based on this.
slug: radwebcam-features-media-information
tags: mediafoundationdeviceinfo, mediafoundationvideoformatinfo
published: True
position: 2
---

# Media Information

The RadWebCam API allows you to get information about the connected devices (cameras) and change the control's device and video format based on this.

## MediaFoundationDeviceInfo

The __MediaFoundationDeviceInfo__ object provides information about the connected device. This object is used by the control to read video.

## MediaFoundationVideoFormatInfo

The __MediaFoundationVideoFormatInfo__ object provides information about the video format used by the connected camera.

## Get Video Capture Devices

To get the available video capture devices (cameras), use the __RadWebCam.GetVideoCaptureDevices__ static method.

#### __[C#] Example 1: Getting the available cameras__
{{region radwebcam-features-get-media-information-0}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();
{{endregion}}

## Get Video Formats

To get the available video file formats for the connected device, you can use the __RadWebCam.GetVideoFormats__ static method.

#### __[C#] Example 2: Getting the available video formats__
{{region radwebcam-features-get-media-information-1}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
{{endregion}}

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [SnapshotTaken]({%slug radwebcam-events%})
* [Commands]({%slug radwebcam-events%})
