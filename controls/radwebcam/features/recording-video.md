---
title: Recording Video
page_title: Recording Video
description: This article shows how to record a video using the RadWebCam control.
slug: radwebcam-features-recording-video
tags: startrecording,capture
published: True
position: 1
---

# {{ site.framework_name }} RadWebCam Recording Video

To start recording a video you can press the "Start recording" button or call the `StartRecording` method of the `RadWebCam` control. 

![{{ site.framework_name }} RadWebCam Start Recording Video Button](images/radwebcam-features-recording-video-0.png)

To enable video recording set the `RecordingFilePath` property of the control. This is the path to the video where the recording will be stored.

#### __[XAML] Set the recording file path in XAML__
{{region radwebcam-features-recording-video-0}}
	<telerik:RadWebCam RecordingFilePath="C:\\temp\\video.mp4"/>
{{endregion}}

#### __[C#] Set the recording file path in code__
{{region radwebcam-features-recording-video-1}}
	string videoFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "video.mp4");
	
	// If there is no "video.mp4" file, such file will get created. If the file exists, it will get overridden.
	radWebCam.RecordingFilePath = videoFileName
	
	radWebCam.StartRecording();
{{endregion}}

To stop recording, press the "Stop" button or call the `StopRecording` method of RadWebCam. This will stop the recording and close the file stream.

#### __[C#] Stop capturing a video__
{{region radwebcam-features-recording-video-2}}
	radWebCam.StopRecording();
{{endregion}}

You can indicate that the camera control is recording via its `IsRecording` property.

> Setting the `IsRecording` property of RadWebCam will also start or stop the recording.

## Elapsed Time Format

The control allows you to replace the default elapsed date-time format. To do this, set the `VideoRecordingElapsedTimeFormat` property of the RadWebCam control.

__Elapsed time default format__

![{{ site.framework_name }} RadWebCam Elapsed Time Default Format](images/radwebcam-features-recording-video-1.png)

#### __[XAML] Set VideoRecordingElapsedTimeFormat in XAML__
{{region radwebcam-features-recording-video-3}}
	<telerik:RadWebCam VideoRecordingElapsedTimeFormat="ss" />
{{endregion}}

#### __[C#] Set VideoRecordingElapsedTimeFormat in code__
{{region radwebcam-features-recording-video-4}}
	this.radWebCam.VideoRecordingElapsedTimeFormat = "ss";
{{endregion}}

__Elapsed time custom format__

![{{ site.framework_name }} RadWebCam Elapsed Time Custom Format](images/radwebcam-features-recording-video-2.png)

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Commands]({%slug radwebcam-features-commands%})
* [Events]({%slug radwebcam-events%})