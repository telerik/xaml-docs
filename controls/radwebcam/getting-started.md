---
title: Getting Started
page_title: Getting Started
description: This tutorial will walk you through the creation of a sample application that contains RadWebCam.
slug: radwebcam-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadWebCam__.

## Assembly References

In order to use __RadWebCam__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Media__
* __Telerik.Windows.MediaFoundation__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%})help article.

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

![](images/radwebcam-getting-started-0.png)

## Connect to the Webcam Manually

To connect to a webcam manually, call the __Start__ method of the control.

#### __[C#] Example 3: __
{{region radwebcam-getting-started-2}}
	radWebCam.Start();
{{endregion}}

By default the control gets and connects to the first camera and microphone devices it finds. You can change this by calling the parameterized overload of the __Start__ method. This way you can provide different devices to the control. 

#### __[C#] Example 3: __
{{region radwebcam-getting-started-2}}
	ReadOnlyCollection<MediaFoundationDeviceInfo> videoDevices = RadWebCam.GetVideoCaptureDevices();	
	ReadOnlyCollection<MediaFoundationDeviceInfo> audioDevices = RadWebCam.GetAudioCaptureDevices();
	ReadOnlyCollection<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(videoDevices[1]);
	
	this.radWebCam.Start(videoDevices[1], videoFormats[1])
{{endregion}}

>tip Read more about the capture devices in the [Get Media Information]() article.

## Recording Video

To record a video you need to set __RecordingFilePath__ before start the recording. This is requried in order to specify where the recording will be stored on the file system.

#### __[C#] Example 3: Set the recording file path__
{{region radwebcam-getting-started-2}}
	videoFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "video.mp4");
	radWebCam.RecordingFilePath = myFilePath
{{endregion}}

To start recording, set the and press the "Record" button or call the __StartRecording__ method of RadWebCam. This will start writing the media stream to the corresponding file.

#### __[C#] Example 3: Start capturing a video__
{{region radwebcam-getting-started-2}}	
	radWebCam.StartRecording();
{{endregion}}

To stop recording, press the "Stop" button or call the __StopRecording__ method of RadWebCam. This will stop the recording and close the file stream.

#### __[C#] Example 3: Stop capturing a video__
{{region radwebcam-getting-started-2}}
	radWebCam.StopRecording();
{{endregion}}

You can indicate that the camera control is recording via its __IsRecording__ property.

## Taking a Snapshot

A snapshot of the currently displayed video feed can be taken using the __TakeSnapshot__ method of the control, or by pressing the "Take snapshot button". This will fire the __SnapshotTaken__ event where you get access the current snapshot as a __BitmapSource__ object.

#### __[C#] Example 3: Stop capturing a video__
{{region radwebcam-getting-started-2}}
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