---
title: Snapshots
page_title: Snapshots
description: RadWebCam allows you to snapshot the currently displayed video feed.
slug: radwebcam-features-snapshots
tags: takesnapshot,snapshottaken
published: True
position: 2
---

# {{ site.framework_name }} RadWebCam Snapshots

The `RadWebCam` control allows you to snapshot the currently displayed video feed.

This can be done via the "Take snapshot" button of the control, or the `TakeSnapshot` method. This will fire the `SnapshotTaken` event where you can get the `BitmapSource` object with the image.

__Take snapshot button__

![{{ site.framework_name }} RadWebCam Take Snapshot Button](images/radwebcam-features-snapshots-0.png)

#### __[XAML] Taking a snapshot in code__
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

#### __[VB.NET] Taking a snapshot in code__
{{region vb-radwebcam-features-snapshots-0}}
	Public Sub New()
        InitializeComponent()
        Me.radWebCam.SnapshotTaken += AddressOf RadWebCam_SnapshotTaken
    End Sub

    Public Sub OnTakeSnapshot()
        Me.radWebCam.TakeSnapshot()
    End Sub

    Private Sub RadWebCam_SnapshotTaken(ByVal sender As Object, ByVal e As SnapshotTakenEventArgs)
        Dim snapshot As BitmapSource = e.Snapshot
		' here you save the source to a file, in memory, or to show it in the UI
    End Sub
{{endregion}}

To discard the snapshot preview, call the `DiscardSnapshot` method of RadWebCam. The method works only when a snapshot is taken and is currently being previewed.

Additionally, there is a `SaveSnapshot` method which fires the SnapshotTaken event. The method works only when a snapshot is taken and is currently being previewed.

## Preview Snapshots

By default when you take a snapshot a preview of the image will be shown. To disable this, set the `PreviewSnapshots` property to `False`.

#### __[XAML] Disable snapshots preview in XAML__
{{region radwebcam-features-snapshots-1}}
	<telerik:RadWebCam PreviewSnapshots="False" />
{{endregion}}

#### __[C#] Disable snapshots preview in code__
{{region radwebcam-features-snapshots-2}}
	this.radWebCam.PreviewSnapshots = false;
{{endregion}}

#### __[VB.NET] Disable snapshots preview in code__
{{region vb-radwebcam-features-snapshots-2}}
	Me.radWebCam.PreviewSnapshots = False
{{endregion}}

You can indicate if the snapshot preview is displayed via the `IsPreviewingSnapshot` property of RadWebCam.

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Commands]({%slug radwebcam-features-commands%})
* [Save Snapshot to File]({%slug radwebcam-features-commands%})
