---
title: Recording Video
page_title: Recording Video
description: This article shows how to record a video using the RadWebCam control.
slug: radwebcam-features-recording-video
tags: startrecording,capture
published: True
position: 0
---

# Recording Video

To start recording a video you can press the "Start recording"  button or call the __StartRecording__ method of RadWebCam control. 

![](images/radwebcam-features-recording-video-0.png)

To enable video recording set the __RecordingFilePath__ property of the control. This is the path to the video where the recording will be stored.

#### __[XAML] Example 1: Set the recording file path in XAML__
{{region radwebcam-features-recording-video-0}}
	<telerik:RadWebCam RecordingFilePath="C:\\temp\\video.mp4"/>
{{endregion}}

#### __[C#] Example 2: Set the recording file path in code__
{{region radwebcam-features-recording-video-1}}
	string videoFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "video.mp4");
	radWebCam.RecordingFilePath = videoFileName
	
	radWebCam.StartRecording();
{{endregion}}

To stop recording, press the "Stop" button or call the __StopRecording__ method of RadWebCam. This will stop the recording and close the file stream.

#### __[C#] Example 3: Stop capturing a video__
{{region radwebcam-features-recording-video-2}}
	radWebCam.StopRecording();
{{endregion}}

You can indicate that the camera control is recording via its __IsRecording__ property.

> Setting the __IsRecording__ property of RadWebCam will also start or stop the recording.

## Elapsed Time Format

The control allows you to replace the default elapsed date-time format. To do this, set the __VideoRecordingElapsedTimeFormat__ property of the RadWebCam control.

#### Figure 2: Elapsed time default format
![](images/radwebcam-features-recording-video-1.png)

#### __[XAML] Example 4: Set VideoRecordingElapsedTimeFormat in XAML__
{{region radwebcam-features-recording-video-3}}
	<telerik:RadWebCam VideoRecordingElapsedTimeFormat="ss" />
{{endregion}}

#### __[C#] Example 5: Set VideoRecordingElapsedTimeFormat in code__
{{region radwebcam-features-recording-video-4}}
	this.radWebCam.VideoRecordingElapsedTimeFormat = "ss";
{{endregion}}

#### Figure 3: Elapsed time custom format
![](images/radwebcam-features-recording-video-2.png)

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Commands]({%slug radwebcam-features-commands%})