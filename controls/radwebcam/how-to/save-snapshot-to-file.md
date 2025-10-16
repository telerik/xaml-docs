---
title: Save Snapshot to File
page_title: Save Snapshot to File
description: This article shows how to take and save a snapshot from RadWebCam to a file.
slug: radwebcam-save-snapshot-to-file
tags: takesnapshot,save,store,file,png,picture,snapshottaken,dialog
published: True
position: 0
---

# Save Snapshot to File

This article shows how to take and save a snapshot to a file.

## Setting up the Control

Add the control to the logical tree of the view and subscribe to the `SnapshotTaken` event.

__Defining RadWebCam__
```XAML
	<telerik:RadWebCam x:Name="radWebCam" SnapshotTaken="RadWebCam_SnapshotTaken"/>
```

In the event handler you get access to a `BitmapSource` object holding the snapshot. You can use this to save it to the file system. 

__Opening a file dialog in the SnapshotTaken event handler and saving it to a file__
```C#
	private void RadWebCam_SnapshotTaken(object sender, RoutedEventArgs e)
	{
	    var args = (SnapshotTakenEventArgs)e;
		SaveFileDialog dialog = new SaveFileDialog();
		dialog.Filter = "Images|*.png;*.bmp;*.jpg";
		dialog.DefaultExt = ".png";
		dialog.FilterIndex = 0;
		if (dialog.ShowDialog() == true)
		{
			using (var fileStream = dialog.OpenFile())
			{
				BitmapEncoder encoder = new PngBitmapEncoder();
				encoder.Frames.Add(BitmapFrame.Create(args.Snapshot));
				encoder.Save(fileStream);
			}
		}
	}
```

## Taking Snapshot

To take the snapshot press the "Take snapshot" button. Or call the `TakeSnapshot` method. This will fire the `SnapshotTaken` event.

> By default a preview of the snapshot will be shown that allows you to choose if it should be saved or not. If you choose to save it the SnapshotTaken event will fire. To disable the preview set the `IsPreviewingSnapshot` property of RadWebCam to `False`.

__Take snapshot button__

![{{ site.framework_name }} RadWebCam Take Snapshot Button](images/radwebcam-save-snapshot-to-file-0.png)

__Take Snapshot__
```C#
	this.radWebCam.TakeSnapshot();
```

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [SnapshotTaken]({%slug radwebcam-events%})
* [Commands]({%slug radwebcam-features-commands%})