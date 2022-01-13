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

The RadWebCam control automatically connects to the first camera and recording device it finds. Then it selects the highest available resolution and starts the video.

## Disable Auto Start

To disable the automatic start of the camera, set the __AutoStart__ property to __False__. The default value is **True**.

#### __[XAML] Example 1: Disable auto start__
{{region radwebcam-radwebcam-features-initialize-camera-0}}
	<telerik:RadWebCam AutoStart="False"/>
{{endregion}}}

To start the camera at a later moment in time, call the __Start__ method of RadWebCam.

#### __[C#] Example 2: Starting the camera__
{{region radwebcam-radwebcam-features-initialize-camera-1}}
	this.radWebCam.Start();
{{endregion}}

## Start Camera Manually

To start the camera manually, select a camera device, video format and recording device, and then call the __Initialize__ method of RadWebCam. The following steps describe how to do this.

1. __Get the camera devices__ by calling the __RadWebCam.GetVideoCaptureDevices__ static method.
2. __Get the video formats__ supported by the camera device by calling the __RadWebCam.GetVideoFormats__ static methods.
3. __Initialize the camera__ control using the collected settings. To do this, call the __Initialize__ method of RadWebCam.
4. __Start the webcam__ control by calling the __Start__ method.

#### __[C#] Example 3: Starting the camera with manually set device and video format__
{{region radwebcam-radwebcam-features-initialize-camera-2}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();            
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
	this.radWebCam.Initialize(videoDevices[0], videoFormats[0]);
	this.radWebCam.Start();
{{endregion}}

Optionally, you can select a different recording device by passing a new device to the __Initialize__ method.

#### __[C#] Example 4: Starting the camera with manually set device, video format and audio format__
{{region radwebcam-radwebcam-features-initialize-camera-3}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();            
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
	ReadOnlyCollection<MediaFoundationDeviceInfo> recordingDevices = RadWebCam.GetAudioCaptureDevices();
	this.radWebCam.Initialize(videoDevices[0], videoFormats[0], recordingDevices[0]);
	this.radWebCam.Start();
{{endregion}}

Passing an empty recording device (__null__) to the __Initialize__ method will disable the audio recording.

>tip Read more about the capture devices in the [Media Information]({%slug radwebcam-features-media-information%}) article.

>important The manual initialization of RadWebCam should be executed after the control gets loaded. For example, you can use its Loaded event.

## Stop the Camera

To stop the camera manually call the __Stop__ method of RadWebCam. 

To disconnect from the camera, call the __ShutDown__ method.

#### __[C#] Example 5: Stopping the camera__
{{region radwebcam-radwebcam-features-initialize-camera-4}}
	this.radWebCam.Stop();
{{endregion}}
	
#### __[C#] Example 6: Shutdown the camera__
{{region radwebcam-radwebcam-features-initialize-camera-5}}
	this.radWebCam.ShutDown();
{{endregion}}

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Commands]({%slug radwebcam-features-commands%})
* [Save Snapshot to File]({%slug radwebcam-features-commands%})
