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

## Connect to a Camera Manually

To start the webcam with the default settings you can call the __Start__ method of the control. Additionally, you can start a specific camera device, choose a different video format and microphone by calling the __Initialize__ method. Read more about this in the [Start the Camera]({%slug radwebcam-features-start-camera-manually%}) article.

## Stop the Camera

To stop the stream between the camera device and the RadWebCam control, call the __Stop__ method.

#### __[C#] Example 5: Stopping the camera__
{{region radwebcam-getting-started-4}}
	this.radWebCam.Stop();
{{endregion}}

## Recording Video

To record a video you need to set __RecordingFilePath__ before start the recording. This is requried in order to specify where the recording will be stored on the file system.

To start recording, press the "Start recording" button or call the __StartRecording__ method of RadWebCam. This will start writing the media stream to the corresponding file.

#### __[XAML] Example 6: Set the recording file path in XAML__
{{region radwebcam-getting-started-5}}
	<telerik:RadWebCam RecordingFilePath="C:\\temp\\video.mp4"/>
{{endregion}}

> Read more about this in the [Recording Video]({%slug radwebcam-features-recording-video%}) article.

## Taking Snapshot

A snapshot of the currently displayed video feed can be taken using the __TakeSnapshot__ method of the control, or by pressing the "Take snapshot button". This will fire the __SnapshotTaken__ event where you get access the current snapshot as a __BitmapSource__ object.

#### __[C#] Example 7: Subscribing to the SnapshotTaken event__
{{region radwebcam-getting-started-6}}
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
* [Visual Structure]({%slug radwebcam-visual-structure%})
* [Snapshots]({%slug radwebcam-features-snapshots%})
* [Media Information]({%slug radwebcam-features-media-information%})