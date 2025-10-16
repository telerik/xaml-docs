---
title: Media Information
page_title: Media Information
description: RadWebCam gives the ability to get information about the connected devices (cameras and microphones) and change the control's device and video format based on this.
slug: radwebcam-features-media-information
tags: mediafoundationdeviceinfo, mediafoundationvideoformatinfo
published: True
position: 3
---

# Media Information

The RadWebCam API allows you to get information about the connected devices (cameras and microphones) and change the control's devices and video format based on this.

>tip See how to use the media information in the [Getting Started]({%slug radwebcam-getting-started%}) article.

## MediaFoundationDeviceInfo

The `MediaFoundationDeviceInfo` object provides information about the connected device. This object is used by the control to read video and to record audio.

## MediaFoundationVideoFormatInfo

The `MediaFoundationVideoFormatInfo` object provides information about the video format used by the connected camera.

## Get Audio Capture Devices

To get the available audio capture devices (microphones), use the `RadWebCam.GetAudioCaptureDevices` static method.

__Getting the available microphones__
```C#
	ReadOnlyCollection<MediaFoundationDeviceInfo> recordingDevices = RadWebCam.GetAudioCaptureDevices();
```

## Get Video Capture Devices

To get the available video capture devices (cameras), use the `RadWebCam.GetVideoCaptureDevices` static method.

__Getting the available cameras__
```C#
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();
```

## Get Video Formats

To get the available video file formats for the connected device, you can use the `RadWebCam.GetVideoFormats` static method.

__Getting the available video formats__
```C#
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
```

> The RadWebCam.GetVideoCaptureDevices call will throw an `UnauthorizedAccessException` if the access to the camera device is forbidden by the OS settings or any third party software.

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [SnapshotTaken]({%slug radwebcam-events%})
* [Commands]({%slug radwebcam-events%})
