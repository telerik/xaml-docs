---
title: Toolbar Buttons Visibility
page_title: Toolbar Buttons Visibility
description: This article shows how to hide/show the buttons of RadWebCam.
slug: radwebcam-features-toolbar-buttons-visibility
tags: commands, radwebcamcommands
published: True
position: 8
---

# {{ site.framework_name }} RadWebCam Toolbar Buttons Visibility

The toolbar of RadWebCam is the element shown at the bottom part of the control, which holds the camera buttons. The control allows you to hide each button individually or the whole toolbar at once.

The following properties are used to control the visibility of the buttons.

* `ToolbarPanelVisibility`&mdash;Toggles the visibility of the toolbar panel that hosts all buttons.

* `SettingsButtonVisibility`&mdash;Toggles the visibility of the Open Settings Dialog Button that opens the dialog with the [CameraSettings]({%slug radwebcam-features-camera-settings-control%}) control.

* `SnapshotButtonVisibility`&mdash;Toggles the visibility of the Take Snapshot button.

* `RecordingButtonVisibility`&mdash;Toggles the visibility of the Start Recording button.

* `RecordingLabelVisibility`&mdash;Toggles the visibility of the Elapsed Time label.

>tip Check the [Visual Structure]({%slug radwebcam-visual-structure%}) article to see the different buttons in the RadWebCam's UI.

#### __[XAML] Hiding the toolbar panel__
{{region radwebcam-features-toolbar-buttons-visibility-0}}
	<telerik:RadWebCam ToolbarPanelVisibility="Collapsed" />
{{endregion}}

__Hidden button's toolbar__

![{{ site.framework_name }} RadWebCam Hidden Button's Toolbar](images/radwebcam-features-toolbar-buttons-visibility-0.png)

#### __[XAML] Hiding the recording button__
{{region radwebcam-features-toolbar-buttons-visibility-1}}
	<telerik:RadWebCam RecordingButtonVisibility="Collapsed" />
{{endregion}}

__Hidden recording button__

![{{ site.framework_name }} RadWebCam Hidden Recording Button](images/radwebcam-features-toolbar-buttons-visibility-1.png)

## See Also
* [Getting Started]({%slug radwebcam-getting-started%})
* [Recording Video]({%slug radwebcam-features-recording-video%})
* [Snapshots]({%slug radwebcam-features-snapshots%})
