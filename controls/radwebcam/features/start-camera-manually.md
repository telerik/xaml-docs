---
title: Start the Camera
page_title: Start Camera
description: This article shows how to start the RadWebCam control manually by selecting a camera, video format and recording device.
slug: radwebcam-features-start-camera-manually
tags: autostart,initialize,stop,shutdown
published: True
position: 0
---

# Start the Camera

The `RadWebCam` control automatically connects to the first camera and recording device it finds. Then it selects the highest available resolution and starts the video.

## Disable Auto Start

To disable the automatic start of the camera, set the `AutoStart` property to `False`. The default value is `True`.

__Disable auto start__
```XAML
	<telerik:RadWebCam AutoStart="False"/>
```}

To start the camera at a later moment in time, call the `Start` method of RadWebCam.

__Starting the camera__
```C#
	this.radWebCam.Start();
```

## Start Camera Manually

To start the camera manually, select a camera device, video format and recording device, and then call the `Initialize` method of RadWebCam. The following steps describe how to do this.

1. __Get the camera devices__ by calling the `RadWebCam.GetVideoCaptureDevices` static method.
2. __Get the video formats__ supported by the camera device by calling the `RadWebCam.GetVideoFormats` static methods.
3. __Initialize the camera__ control using the collected settings. To do this, call the Initialize method of RadWebCam.
4. __Start the webcam__ control by calling the `Start` method.

__Starting the camera with manually set device and video format__
```C#
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();            
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
	this.radWebCam.Initialize(videoDevices[0], videoFormats[0]);
	this.radWebCam.Start();
```

Optionally, you can select a different recording device by passing a new device to the Initialize method.

__Starting the camera with manually set device, video format and audio format__
```C#
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();            
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
	ReadOnlyCollection<MediaFoundationDeviceInfo> recordingDevices = RadWebCam.GetAudioCaptureDevices();
	this.radWebCam.Initialize(videoDevices[0], videoFormats[0], recordingDevices[0]);
	this.radWebCam.Start();
```

Passing an empty recording device (`null`) to the `Initialize` method will disable the audio recording.

>tip Read more about the capture devices in the [Media Information]({%slug radwebcam-features-media-information%}) article.

>important The manual initialization of RadWebCam should be executed after the control gets loaded. For example, you can use its Loaded event.

## Stop the Camera

To stop the camera manually call the `Stop` method of RadWebCam. 

To disconnect from the camera, call the `ShutDown` method.

__Stopping the camera__
```C#
	this.radWebCam.Stop();
```
	
__Shutdown the camera__
```C#
	this.radWebCam.ShutDown();
```

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Commands]({%slug radwebcam-features-commands%})
* [Save Snapshot to File]({%slug radwebcam-features-commands%})
