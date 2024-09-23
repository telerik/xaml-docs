---
title: Getting Started
page_title: Getting Started
description: This tutorial will walk you through the creation of a sample application that contains RadWebCam.
slug: radwebcam-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} WebCam

This tutorial will walk you through the creation of a sample application that contains `RadWebCam`.

## Assembly References

In order to use `RadWebCam`, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Media__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.MediaFoundation__
* __MediaFoundation__: This dll is located in the *UI for WPF installation folder/Binaries or Binaries.NoXaml/{.NET Version}/MediaFoundation* folder.
* [SkiaSharp NuGet package](https://www.nuget.org/packages/SkiaSharp/2.88.6) (version 2.88.6).

For __.NET 6__ and later you will need to install also the `System.Drawing.Common` NuGet package. This is __required only if the Telerik assemblies are referenced manually__ in the project. In case you install the dlls using NuGet or the Telerik Visual Studio Extension, this package is included automatically.

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

>important With the 2024 Q4 release the __SharpDX__ library used for the rendering of the camera's video feed was replaced with the __SkiaSharp__ library. This was necessary because after March 2019, [SharpDX is no longer maintained](https://github.com/sharpdx/SharpDX).

> RadWebCam uses Microsoft [Media Foundation](https://docs.microsoft.com/en-us/windows/win32/medfound/about-the-media-foundation-sdk) which requires a __minimum OS version of Windows Vista or later__. Also, some versions of Windows 7 don't have the __Media Feature Package__ installed, so you may need to install it separately.

### Adding Telerik Assemblies Using NuGet

To use `RadWebCam` when working with NuGet packages, install the `Telerik.Windows.Controls.Media.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Setting up the Control

To start using the control you only need to add it in the visual tree through XAML or code-behind. This will automatically detect a web camera if one is connected to the device and start receiving the media stream, thus showing the camera input.

#### __[XAML] Defining RadWebCam in XAML__
{{region radwebcam-getting-started-0}}
	<telerik:RadWebCam />
{{endregion}}

#### __[C#] Defining RadWebCam in code__
{{region radwebcam-getting-started-1}}
	RadWebCam radWebCam = new RadWebCam();	
{{endregion}}

From this point on, you can start using the control without any additional set up.

__RadWebCam__

![{{ site.framework_name }} RadWebCam Overview](images/radwebcam-getting-started-0.png)

## Auto Start

By default the camera control will start automatically if a camera device is connected. You can change this by setting the `AutoStart` property of RadWebCam to `False`.

#### __[XAML] Setting AutoStart in XAML__
{{region radwebcam-getting-started-2}}
	 <telerik:RadWebCam AutoStart="False"/>
{{endregion}}

#### __[C#] Setting AutoStart in code__
{{region radwebcam-getting-started-3}}
	this.radWebCam.AutoStart = false;
{{endregion}}

## Connect to a Camera Manually

To start the webcam with the default settings you can call the `Start` method of the control. Additionally, you can start a specific camera device and choose a different video format and microphone by calling the `Initialize` method. Read more about this in the [Start the Camera]({%slug radwebcam-features-start-camera-manually%}) article.

## Stop the Camera

To stop the stream between the camera device and the RadWebCam control, call the `Stop` method.

#### __[C#] Stopping the camera__
{{region radwebcam-getting-started-4}}
	this.radWebCam.Stop();
{{endregion}}

## Recording Video

To record a video you need to set `RecordingFilePath` before start the recording. This is required in order to specify where the recording will be stored on the file system.

To start recording, press the "Start recording" button or call the `StartRecording` method of RadWebCam. This will start writing the media stream to the corresponding file.

#### __[XAML] Set the recording file path in XAML__
{{region radwebcam-getting-started-5}}
	<telerik:RadWebCam RecordingFilePath="C:\\temp\\video.mp4"/>
{{endregion}}

> Read more about this in the [Recording Video]({%slug radwebcam-features-recording-video%}) article.

## Taking Snapshot

A snapshot of the currently displayed video feed can be taken using the `TakeSnapshot` method of the control, or by pressing the "Take snapshot button". This will fire the `SnapshotTaken` event where you get access the current snapshot as a `BitmapSource` object.

#### __[C#] Subscribing to the SnapshotTaken event__
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

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF WebCam Component](https://www.telerik.com/products/wpf/webcam.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [SnapshotTaken]({%slug radwebcam-events%})
* [Visual Structure]({%slug radwebcam-visual-structure%})
* [Snapshots]({%slug radwebcam-features-snapshots%})
* [Media Information]({%slug radwebcam-features-media-information%})