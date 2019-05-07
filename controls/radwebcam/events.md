---
title: Events
page_title: Events
description: RadWebCam exposes a single event that is specific for the control - SnapshotTaken. 
slug: radwebcam-events
tags: events, snapshottaken
published: True
position: 3
---

# Events

__RadWebCam__ exposes a single event that is specific for the control - __SnapshotTaken__. 

The event fires when the "Take snapshot" button is pressed or when you call the __TakeSnapshot__ method of RadWebCam.

The purpose of the event is to notify you that a snapshot has been taken and you need to take action, like saving it to a file.

The event arguments are of type __SnapshotTakenEventArgs__ which exposes a __Snapshot__ property (of type BitmapSource).

#### __[C#] Example 1: Subscribing to the event__
{{region radwebcam-events-0}}
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
* [Getting Started]({%slug radwebcam-getting-started%})
* [Visual Structure]({%slug radwebcam-visual-structure%})
* [Snapshots]({%slug radwebcam-features-snapshots%})
