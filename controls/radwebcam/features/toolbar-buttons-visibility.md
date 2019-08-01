---
title: Toolbar Buttons Visibility
page_title: Toolbar Buttons Visibility
description: This article shows how to hide/show the buttons of RadWebCam.
slug: radwebcam-features-toolbar-buttons-visibility
tags: commands, radwebcamcommands
published: True
position: 8
---

# Toolbar Buttons Visibility

The toolbar of RadWebCam is the element shown at the bottom part of the control, which holds the camera buttons. The control allows you to hide each button individually or the whole toolbar at once.

The following properties are used to control the visibility of the buttons.

* __ToolbarPanelVisibility__: Toggles the visibility of the toolbar panel that hosts all buttons.

* __SettingsButtonVisibility__: Toggles the visibility of the Open Settings Dialog Button that opens the dialog with the [CameraSettings]({%slug radwebcam-features-camera-settings-control%}) control.

* __SnapshotButtonVisibility__: Toggles the visibility of the Take Snapshot button.

* __RecordingButtonVisibility__: Toggles the visibility of the Start Recording button.

* __RecordingLabelVisibility__: Toggles the visibility of the Elapsed Time label.

>tip Check the [Visual Structure]({%slug radwebcam-visual-structure%}) article to see the different buttons in the RadWebCam's UI.

#### __[XAML] Example 1: Hiding the toolbar panel__
{{region radwebcam-features-toolbar-buttons-visibility-0}}
	<telerik:RadWebCam ToolbarPanelVisibility="Collapsed" />
{{endregion}}

#### Figure 1: Hidden button's toolbar
![](images/radwebcam-features-toolbar-buttons-visibility-0.png)

#### __[XAML] Example 2: Hiding the recording button__
{{region radwebcam-features-toolbar-buttons-visibility-1}}
	<telerik:RadWebCam RecordingButtonVisibility="Collapsed" />
{{endregion}}

#### Figure 2: Hidden recording button
![](images/radwebcam-features-toolbar-buttons-visibility-1.png)

## See Also
* [Getting Started]({%slug radwebcam-getting-started%})
* [Recording Video]({%slug radwebcam-features-recording-video%})
* [Snapshots]({%slug radwebcam-features-snapshots%})
