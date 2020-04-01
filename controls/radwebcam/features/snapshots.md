---
title: Snapshots
page_title: Snapshots
description: RadWebCam allows you to snapshot the currently displayed video feed.
slug: radwebcam-features-snapshots
tags: takesnapshot,snapshottaken
published: True
position: 2
---

# Snapshots

RadWebCam allows you to snapshot the currently displayed video feed.

This can be done via the "Take snapshot" button of the control, or the __TakeSnapshot__ method. This will fire the __SnapshotTaken__ event where you can get the __BitmapSource__ object with the image.

#### Figure 1: Take snapshot button
![](images/radwebcam-features-snapshots-0.png)

#### __[XAML] Example 1: Taking a snapshot in code__
{{region radwebcam-features-snapshots-0}}
	public MainWindow()
	{
		InitializeComponent();		
		this.radWebCam.SnapshotTaken += RadWebCam_SnapshotTaken;
	}
	
	public void OnTakeSnapshot()
	{
		this.radWebCam.TakeSnapshot();
	}

	private void RadWebCam_SnapshotTaken(object sender, SnapshotTakenEventArgs e)
	{
		BitmapSource snapshot = e.Snapshot;
		// here you save the source to a file, in memory, or to show it in the UI
	}
{{endregion}}

To discard the snapshot preview, call the __DiscardSnapshot__ method of RadWebCam. The method works only when a snapshot is taken and is currently being previewed.

Additionally, there is a __SaveSnapshot__ method which fires the SnapshotTaken event. The method works only when a snapshot is taken and is currently being previewed.

## Preview Snapshots

By default when you take a snapshot a preview of the image will be shown. To disable this, set the __PreviewSnapshots__ property to False.

#### __[XAML] Example 2: Disable snapshots preview in XAML__
{{region radwebcam-features-snapshots-1}}
	<telerik:RadWebCam PreviewSnapshots="False" />
{{endregion}}

#### __[C#] Example 3: Disable snapshots preview in code__
{{region radwebcam-features-snapshots-2}}
	this.radWebCam.PreviewSnapshots = false;
{{endregion}}

You can indicate if the snapshot preview is displayed via the __IsPreviewingSnapshot__ property of RadWebCam.

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Commands]({%slug radwebcam-features-commands%})
* [Save Snapshot to File]({%slug radwebcam-features-commands%})
