---
title: Getting Started
page_title: Getting Started
description: This tutorial will walk you through the creation of a sample application that contains RadWebCam.
slug: radwebcam-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadWebCam__.

## Assembly References

In order to use __RadWebCam__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Media__
* __Telerik.Windows.MediaFoundation__
* __MediaFoundation__: This dll is located in the *UI for WPF installation folder/Binaries/WPF40/MediaFoundation* folder.
* __SharpDX__: This dll is located in the *UI for WPF installation folder/Binaries/WPF40/SharpDX* folder.
* __SharpDX.Direct3D9__: This dll is located in the *UI for WPF installation folder/Binaries/WPF40/SharpDX* folder.

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Setting up the Control

To start using the control you only need to add it in the visual tree through XAML or code-behind. This will automatically detect a web camera if one is connected to the device and start reciving the media stream, thus showing the camera input.

#### __[XAML] Example 1: Defining RadWebCam in XAML__
{{region radwebcam-getting-started-0}}
	<telerik:RadWebCam />
{{endregion}}

#### __[C#] Example 2: Defining RadWebCam in code__
{{region radwebcam-getting-started-1}}
	RadWebCam radWebCam = new RadWebCam();	
{{endregion}}

From this point on, you can start using the control without any additional set up.

#### Figure 1: RadWebCam
![](images/radwebcam-getting-started-0.png)

## Auto Start

By default the camera control will start automatically if a camera device is connected. You can change this by setting the __AutoStart__ property of RadWebCam to False.

#### __[XAML] Example 3: Setting AutoStart in XAML__
{{region radwebcam-getting-started-2}}
	 <telerik:RadWebCam AutoStart="False"/>
{{endregion}}

#### __[C#] Example 4: Setting AutoStart in code__
{{region radwebcam-getting-started-3}}
	this.radWebCam.AutoStart = false;
{{endregion}}

## Connect to the Webcam Manually

To connect to the webcam manually you can call the __Start__ method of the control. 

#### __[C#] Example 5: Starting the camera__
{{region radwebcam-getting-started-4}}
	this.radWebCam.Start();
{{endregion}}

To connect to a webcam manually, execute the following steps.

1. __Get the camera__ device. To do this, use the RadWebCam __GetVideoCaptureDevices__ static method.
2. __Get a video format__ from the camera. To do this, use the RadWebCam __GetVideoFormats__ static methods.
3. __Initialize the camera device__ in the control. To do this, use the __Initialize__ method of the RadWebCam control.
4. __Start the webcam__ control. To do this, use the __Start__ method of the control.

#### __[C#] Example 6: Starting the camera with manually set device and video format__
{{region radwebcam-getting-started-5}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();            
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[0]);
	this.radWebCam.Initialize(videoDevices[0], videoFormats[0]);
	this.radWebCam.Start();
{{endregion}}

>tip Read more about the capture devices in the [Media Information]({%slug radwebcam-features-media-information%}) article.

## Stop the Camera Control

To stop the stream between the camera device and the RadWebCam control, call the __Stop__ method.

#### __[C#] Example 7: Stopping the camera__
{{region radwebcam-getting-started-6}}
	this.radWebCam.Stop();
{{endregion}}

## Recording Video

To record a video you need to set __RecordingFilePath__ before start the recording. This is requried in order to specify where the recording will be stored on the file system.

To start recording, set the and press the "Start recording" button or call the __StartRecording__ method of RadWebCam. This will start writing the media stream to the corresponding file.

#### __[XAML] Example 8: Set the recording file path in XAML__
{{region radwebcam-getting-started-7}}
	<telerik:RadWebCam RecordingFilePath="C:\\temp\\video.mp4"/>
{{endregion}}

> Read more about this in the [Recording Video]({%slug radwebcam-features-recording-video%}) article.

## Taking Snapshot

A snapshot of the currently displayed video feed can be taken using the __TakeSnapshot__ method of the control, or by pressing the "Take snapshot button". This will fire the __SnapshotTaken__ event where you get access the current snapshot as a __BitmapSource__ object.

#### __[C#] Example 9: Subscribing to the SnapshotTaken event__
{{region radwebcam-getting-started-8}}
	public MainWindow()
	{
		InitializeComponent();
		
		this.radWebCam.SnapshotTaken += RadWebCam_SnapshotTaken;
	}

	private void RadWebCam_SnapshotTaken(object sender, SnapshotTakenEventArgs e)
	{
		BitmapSource snapshot = e.Snapshot;
		// here you save the source to a file, in memory, or to show it in the UI
	}
{{endregion}}

## See Also  
* [SnapshotTaken]({%slug radwebcam-events%})
* [Snapshots]({%slug radwebcam-features-snapshots%})